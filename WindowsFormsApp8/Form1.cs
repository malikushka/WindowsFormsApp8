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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (UserContext db = new UserContext())
        }
            foreach (User u in db.Users)
            {
             listBox1.Items.Add(u.Id + "." + u.Name + " " + u.LastName + "," + Birthday + "," + Telephone + "," + Email+ "," + Direction + "," +
             Numder_Work + "," + First_Publication + "," + Login + "," + Password);

    
          
        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
                 {

                 User user1 = new User(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),
                 textBox5.Text, textBox6.Text, Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), textBox9, Convert.ToInt32(textBox10.Text);
                 db.Users.Add(user1);
                 db.SaveChanges();
                 listBox1.Items.Add(user1.Id + "." + user1.Name + " " + user1.LastName + "," + user1.Birthday + "," + user1.Telephone + "," + user1.Email + "," + user1.Direction + "," +
                 user1.Number_Work + "," + user1.First_Publication + "," + user1.Login + "," + user1.Password);
                
        
            }
        }

    }
}
 
    

