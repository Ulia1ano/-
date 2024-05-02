using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CountryCapitalApp
{
    public class Country
    {
        public string Name { get; set; }

        public string Capital { get; set; }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.FullRowSelect = true;

        }
        public Boolean isSelected = false;
        List<Country> allItems = new List<Country>();

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isSelected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string country = txtCountry.Text;
            string capital = txtCapital.Text;
            
            if (!string.IsNullOrWhiteSpace(country) && !string.IsNullOrWhiteSpace(capital))
            {
                var item = new Country
                {
                    Capital = capital,
                    Name = country,
                };

                allItems.Add(item);
                allItems = allItems.OrderBy(x => x.Name).ThenBy(x => x.Capital).ToList();

                Update();
            }

            txtCountry.Clear();
            txtCapital.Clear();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                var selectedItems = listView1.SelectedItems;
                var index = listView1.Items.IndexOf(selectedItems[0]);
                allItems.RemoveAt(index);

                Update();
            }
        }

        private void Update()
        {
            listView1.Items.Clear();
            var items = allItems
                .Where(x => x.Name.Contains(filter.Text))
                .Select(x => new ListViewItem(new[] { x.Name, x.Capital })).ToArray();
            listView1.Items.AddRange(items);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void filter_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
