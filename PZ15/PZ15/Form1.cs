using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string defaultFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            LoadImages(defaultFolderPath);
        }

        private void LoadImages(string folderPath)
        {
            // Очищаємо список та зображення
            listBoxImages.Items.Clear();
            imageView.Image = null;

            // Перевіряємо чи папка існує
            if (Directory.Exists(folderPath))
            {
                // Отримуємо всі файли у папці
                string[] files = Directory.GetFiles(folderPath);

                // Фільтруємо файли, залишаючи тільки зображення
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);
                    if (extension != null && (extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                              extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                              extension.Equals(".png", StringComparison.OrdinalIgnoreCase) ||
                                              extension.Equals(".gif", StringComparison.OrdinalIgnoreCase) ||
                                              extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase)))
                    {
                        // Додаємо шлях до списку
                        listBoxImages.Items.Add(file);
                    }
                }
            }
            else
            {
                MessageBox.Show("Папка не існує.");
            }
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex != -1)
            {
                string selectedImagePath = listBoxImages.SelectedItem.ToString();
                if (File.Exists(selectedImagePath))
                {
                    imageView.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                LoadImages(selectedFolderPath);
            }
        }
    }
}
