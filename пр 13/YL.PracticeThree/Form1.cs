using System;
using System.Windows.Forms;

namespace YL.PracticeThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������ �������� ���� ��� numericUpDown1, ��� �� �� �������������� ��������� �������� �� ����� ������� ��� ���� ������.
            numericUpDown1.ValueChanged += new EventHandler(CalculateCaloriesPerPortion);
            CalculateCaloriesPerPortion(null, null); // ��������� ����� ��� ��������������� ���������� ������ �� ������.
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // ��������� ���� ������ ��� ������� ������
            if (sender == numericUpDown2 || sender == numericUpDown3)
            {
                if (numericUpDown2.Value > 0 && numericUpDown3.Value > 0) // ��������, ��� �������� ������ �� ����
                {
                    decimal totalWeight = numericUpDown2.Value;
                    decimal portionsCount = numericUpDown3.Value;
                    numericUpDown4.Value = Math.Round(totalWeight / portionsCount, 2); // ��������� ���� ���� ������
                }
            }
            else if (sender == numericUpDown4)
            {
                if (numericUpDown2.Value > 0 && numericUpDown4.Value > 0) // ��������, ��� �������� ������ �� ����
                {
                    decimal totalWeight = numericUpDown2.Value;
                    decimal portionWeight = numericUpDown4.Value;
                    numericUpDown3.Value = Math.Round(totalWeight / portionWeight, 2); // ��������� ������� ������
                }
            }

            CalculateCaloriesPerPortion(sender, e);
        }

        private void CalculateCaloriesPerPortion(object sender, EventArgs e)
        {
            // ���������� ������ �� ������
            if (numericUpDown1.Value > 0 && numericUpDown2.Value > 0 && numericUpDown4.Value > 0)
            {
                decimal totalCalories = numericUpDown1.Value;
                decimal totalWeight = numericUpDown2.Value;
                decimal portionWeight = numericUpDown4.Value;

                decimal caloriesPerPortion = (totalCalories / totalWeight) * portionWeight;
                // ���� ������ �� ������. ��� ������� ������ ������� Label ��� ����������� ����������.
                // ����������, �� � ��� � label � ������ labelResult ��� ����������� ������ �� ������:
                labelResult.Text = $"����� �� ������: {caloriesPerPortion:F2}";
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
