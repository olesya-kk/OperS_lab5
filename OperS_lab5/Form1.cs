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
    private Thread additionalThread;
    public Form1()
    {
        InitializeComponent();
        secondThread = new SecondThreadClass();
        secondThread.UpdateUI += HandleUpdateUI;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        StartMainWork();
    }
    private void HandleUpdateUI(object sender, string message)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => listBox1.Items.Add(message)));
        }
        else
        {
            listBox1.Items.Add(message);
        }
    }

    private void StartMainWork()
    {
        additionalThread = new Thread(() =>
        {
            while (true)
            {
                this.Invoke(new Action(() =>
                {
                    Text = $"Основной поток: {DateTime.Now}";
                }));
                Thread.Sleep(1000);
            }
        });
        additionalThread.IsBackground = true;
        additionalThread.Start();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        secondThread.CreateThread();
    }
    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        secondThread.StartThread();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (radioButton1.Checked)
            secondThread.SetPriority(ThreadPriority.Lowest);
        else if (radioButton2.Checked)
            secondThread.SetPriority(ThreadPriority.Normal);
        else if (radioButton3.Checked)
            secondThread.SetPriority(ThreadPriority.Highest);
    }
}

}
