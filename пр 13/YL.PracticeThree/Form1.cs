using System;
using System.Windows.Forms;

namespace YL.PracticeThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Додаємо обробник подій для numericUpDown1, щоб він не використовував загальний обробник із зміною кількості або маси порцій.
            numericUpDown1.ValueChanged += new EventHandler(CalculateCaloriesPerPortion);
            CalculateCaloriesPerPortion(null, null); // Викликаємо метод для ініціалізаційного розрахунку калорій на порцію.
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Оновлення маси порції або кількості порцій
            if (sender == numericUpDown2 || sender == numericUpDown3)
            {
                if (numericUpDown2.Value > 0 && numericUpDown3.Value > 0) // Перевірка, щоб уникнути ділення на нуль
                {
                    decimal totalWeight = numericUpDown2.Value;
                    decimal portionsCount = numericUpDown3.Value;
                    numericUpDown4.Value = Math.Round(totalWeight / portionsCount, 2); // Оновлюємо масу однієї порції
                }
            }
            else if (sender == numericUpDown4)
            {
                if (numericUpDown2.Value > 0 && numericUpDown4.Value > 0) // Перевірка, щоб уникнути ділення на нуль
                {
                    decimal totalWeight = numericUpDown2.Value;
                    decimal portionWeight = numericUpDown4.Value;
                    numericUpDown3.Value = Math.Round(totalWeight / portionWeight, 2); // Оновлюємо кількість порцій
                }
            }

            CalculateCaloriesPerPortion(sender, e);
        }

        private void CalculateCaloriesPerPortion(object sender, EventArgs e)
        {
            // Розрахунок калорій на порцію
            if (numericUpDown1.Value > 0 && numericUpDown2.Value > 0 && numericUpDown4.Value > 0)
            {
                decimal totalCalories = numericUpDown1.Value;
                decimal totalWeight = numericUpDown2.Value;
                decimal portionWeight = numericUpDown4.Value;

                decimal caloriesPerPortion = (totalCalories / totalWeight) * portionWeight;
                // Вивід калорій на порцію. Вам потрібно додати контрол Label для відображення результату.
                // Припустимо, що у вас є label з іменем labelResult для відображення калорій на порцію:
                labelResult.Text = $"Калорії на порцію: {caloriesPerPortion:F2}";
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
