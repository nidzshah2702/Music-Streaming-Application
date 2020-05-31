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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBox1.Text;
            u.Email = textBox2.Text;
            u.ContactNo = textBox3.Text;
            u.Password = textBox4.Text;
           if(User.Register(u) == true)
            {
                MessageBox.Show("Registration Successfull");
                Form2 f = new Form2();
               
                f.Show();
                 this.Close();

            }

        }
    }
}
