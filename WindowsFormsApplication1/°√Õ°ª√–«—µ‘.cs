using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        void saveData()
        {
            StreamWriter sw = new StreamWriter("data.txt");
            string text = "";
            for (int i = 0; i < Form1.user.Count; i++)
            {
                text = Form1.user[i].ToString();
                sw.WriteLine(text);
            }
            sw.Close();
        }
        private void กรอกประวัติ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = "";
            data += textBox2.Text + "#" + textBox3.Text + "#" + textBox4.Text + "/" + textBox5.Text + "/" + textBox6.Text + "#" + textBox1.Text + "#" + textBox10.Text + "#" + comboBox1.Text + "#" + textBox11.Text + "/" + textBox9.Text + "/" + textBox8.Text + "#" + textBox7.Text + "#" + "0";
            Form1.user.Add(data);
            saveData();
            MessageBox.Show("เพื่มข้อมูลเรียนร้อย ^_^");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
