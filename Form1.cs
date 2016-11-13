using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace bt
{
    public partial class Form1 : Form
    {
        string[] ports = SerialPort.GetPortNames();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.SelectedIndex = 1;
            if(serialPort1.IsOpen==false)
            label2.Text = "No connection now";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string result = serialPort1.ReadExisting();
                label1.Text = result + " alinan veridir";
            }
            catch (Exception)
            {
                label1.Text = "hata oldu!!!";
                timer1.Stop();
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(serialPort1.IsOpen==false)
            {
                if(comboBox1.Text=="")
                return;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt16(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    label2.Text = "I'm connected";
                }
                catch(Exception hata)
                {
                    label2.Text = "A problem has occured" + hata.Message;
                }
            }
            else
            {
                if(serialPort1.IsOpen==true)
                label2.Text = "I'm Already Connected!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(serialPort1.IsOpen==true)
            {
                serialPort1.Close();
                if(serialPort1.IsOpen==false)
                label2.Text = "Connection Closed";
            }
        }
    }
}
