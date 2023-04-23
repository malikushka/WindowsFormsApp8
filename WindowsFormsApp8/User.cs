using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }     
        public string Telephone { get; set;}
        public string Direction { get; set; }
        public string Number_Work { get; set; }
        public string First_Publication { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        
        public User()
        { }
        public User(string Login, string Password, string Email, string Role, string name, string lastName, string dateofBirth, string telephone, string direction, string numberWorks, string firstPublication)
        {
            this.Login = Login;
            this.Password = Password;
           
            this.Email = Email;
            this.Name = name;
            this.LastName = lastName;
            this.Birthday = dateofBirth;
            this.Telephone = telephone;
            this.Direction = direction;
            this.Number_Work = numberWorks;
            this.First_Publication = firstPublication;
        }

    }
}
