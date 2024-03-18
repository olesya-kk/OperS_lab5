using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperS_lab5
{
    public partial class Form1 : Form
    {
        private SecondThreadClass secondThread;
        private Thread mainThread;

        public Form1()
        {
            InitializeComponent();

            secondThread = new SecondThreadClass();
            secondThread.UpdateUI += HandleUpdateUI;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secondThread.StartThread();
            StartMainWork(); // Запускаем работу в основном потоке
        }

        private void HandleUpdateUI(object sender, string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => richTextBox1.AppendText(message + Environment.NewLine)));
            }
            else
            {
                richTextBox1.AppendText(message + Environment.NewLine);
            }
        }
        private void StartMainWork()
        {
            mainThread = new Thread(() =>
            {
                while (true)
                {
                    this.Invoke(new Action(() =>
                    {
                        Text = $"Основной поток: {DateTime.Now}";
                    }));
                    Thread.Sleep(1000); // Имитация работы, пауза 1 секунда
                }
            })
            { IsBackground = true };
            mainThread.Start();
        }

        private void increasePriorityButton_Click_1(object sender, EventArgs e)
        {
            if (secondThread != null)
            {
                secondThread.IncreasePriority();
            }
        }

        private void decreasePriorityButton_Click_1(object sender, EventArgs e)
        {
            if (secondThread != null)
            {
                secondThread.DecreasePriority();
            }
        }

        private void stopThreadButton_Click_1(object sender, EventArgs e)
        {
            if (mainThread != null)
            {
                mainThread.Abort();
            }
        }

        private void createThreadButton_Click_1(object sender, EventArgs e)
        {
            mainThread = new Thread(StartMainWork)
            { IsBackground = true };
            mainThread.Start();
        }
    }

}
