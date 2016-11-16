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

        private void BtnSendHour_Click(object sender, EventArgs e)
        {
            if(TxtHour.Text=="")
            {
                PicHour.Image = Properties.Resources._default;
            }
            else
            if (TxtHour.Text=="0")
            {
                PicHour.Image = Properties.Resources._0;
            }
            else
            if (TxtHour.Text == "1")
            {
                if (serialPort1.IsOpen == true)
                {
                    PicHour.Image = Properties.Resources._1;
                   
                }

            }
            else
            if (TxtHour.Text == "2")
            {
                PicHour.Image = Properties.Resources._2;
            }
            else
            if (TxtHour.Text == "3")
            {
                PicHour.Image = Properties.Resources._3;
            }
            else
            if (TxtHour.Text == "4")
            {
                PicHour.Image = Properties.Resources._4;
            }
            else
            if (TxtHour.Text == "5")
            {
                PicHour.Image = Properties.Resources._5;
            }
            else
            if (TxtHour.Text == "6")
            {
                PicHour.Image = Properties.Resources._6;
            }
            else
            if (TxtHour.Text == "7")
            {
                PicHour.Image = Properties.Resources._7;
            }
            else
            if (TxtHour.Text == "8")
            {
                PicHour.Image = Properties.Resources._8;
            }
            else
            if (TxtHour.Text == "9")
            {
                PicHour.Image = Properties.Resources._9;
            }
            else
            {
                PicHour.Image = Properties.Resources._default;
            }
        }

        private void BtnSendMin_Click(object sender, EventArgs e)
        {
            if (TxtMin.Text == "")
            {
                PicMin.Image = Properties.Resources._default;
            }
            else
           if (TxtMin.Text == "0")
            {
                PicMin.Image = Properties.Resources._0;
            }
            else
           if (TxtMin.Text == "1")
            {
                PicMin.Image = Properties.Resources._1;
            }
            else
           if (TxtMin.Text == "2")
            {
                PicMin.Image = Properties.Resources._2;
            }
            else
           if (TxtMin.Text == "3")
            {
                PicMin.Image = Properties.Resources._3;
            }
            else
           if (TxtMin.Text == "4")
            {
                PicMin.Image = Properties.Resources._4;
            }
            else
           if (TxtMin.Text == "5")
            {
                PicMin.Image = Properties.Resources._5;
            }
            else
           if (TxtMin.Text == "6")
            {
                PicMin.Image = Properties.Resources._6;
            }
            else
           if (TxtMin.Text == "7")
            {
                PicMin.Image = Properties.Resources._7;
            }
            else
           if (TxtMin.Text == "8")
            {
                PicMin.Image = Properties.Resources._8;
            }
            else
           if (TxtMin.Text == "9")
            {
                PicMin.Image = Properties.Resources._9;
            }
            else
            {
                PicMin.Image = Properties.Resources._default;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Write("39");
            else
            {
                serialPort1.Open();
                serialPort1.Write("39");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen==true)
            {
                serialPort1.Write("0");
               
            }
            else
            {
                if(serialPort1.IsOpen==false)
                {
                    serialPort1.Open();
                    serialPort1.Write("0");
                }
            }
        }
    }
}
