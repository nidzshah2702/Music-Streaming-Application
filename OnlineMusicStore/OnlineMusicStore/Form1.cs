using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMusicStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           if(User.Login(textBox2.Text,textBox1.Text))
            {
                
                MessageBox.Show("Login successfull");
                Form1.ActiveForm.Hide();
                Form2 f = new Form2();
               
                f.Show();
            }else
            {
                MessageBox.Show("Login unsuccessfull");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.ActiveForm.Hide();
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
