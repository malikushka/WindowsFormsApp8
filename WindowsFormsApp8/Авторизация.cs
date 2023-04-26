using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        
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
                 foreach (User user in db.Users)
                 {
                    if (textBox1.Text == user.Email &&
                     this.GetHashString(textBox2.Text) ==
                    user.Password)
                     {
                        MessageBox.Show("Вход успешен!");
                        UserForm userForm = new UserForm();
                        userForm.label1.Text = user.Email;
                        userForm.Show();
                        //userForm.form1 = this;
                        this.Visible = false;
                        return;
                     }
                 }
                       MessageBox.Show("Логин или пароль указанневерно!");
            }
        }
    }
}

