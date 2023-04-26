using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);

            }
            return hash;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (User_Context db = new User_Context())
            {
               
                    User user = new User(textBox1.Text,textBox2.Text,
                    this.GetHashString(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,textBox9.Text,textBox10.Text);
                    db.Users.Add(user);
                    db.SaveChanges();
            }
                



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация f2 = new Авторизация();
            f2.Show();
        }
    }
}
 
    

