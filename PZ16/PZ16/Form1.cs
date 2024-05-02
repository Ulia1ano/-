using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ16
{
    public partial class Form1 : Form
    {
        private const int Port = 12345;
        private const string ServerIP = "127.0.0.1"; // IP-адреса сервера

        private UdpClient client;
        private IPEndPoint serverEndPoint;

        public Form1()
        {
            InitializeComponent();
            client = new UdpClient();
            serverEndPoint = new IPEndPoint(IPAddress.Parse(ServerIP), Port);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                // Відправка даних на сервер
                string message = "Ping";
                byte[] data = Encoding.ASCII.GetBytes(message);
                client.Send(data, data.Length, serverEndPoint);

                // Отримання відповіді від сервера
                byte[] receivedData = client.Receive(ref serverEndPoint);
                string response = Encoding.ASCII.GetString(receivedData);

                // Оновлення інтерфейсу користувача
                UpdateUI(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void UpdateUI(string response)
        {
            // Оновлення Label з показниками пінгу
            string[] parts = response.Split(',');
            lblPacketCount.Text = parts[0];

            // Отримання перших двох символів пінгу
            string pingStr = parts[1].PadRight(2, '0'); // Доповнення до двоцифрового числа нулями
            lblCurrentPing.Text = pingStr;
        }

    }
}
