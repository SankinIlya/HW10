using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }

        public List<History> histories = new List<History>();

        public User (int id, string lastName, string firstName, string patronymic, string phone, string passport)
        {
            Id = id;
            Patronymic= patronymic;
            FirstName = firstName;
            LastName = lastName;
            Passport = passport;
            Phone = phone;
        }

        public User(User other)
        {
            Id = other.Id;
            Patronymic = other.Patronymic;
            FirstName = other.FirstName;
            LastName = other.LastName;
            Passport = other.Passport;
            Phone = other.Phone;
           
        }

        public override string ToString()
        {
            return $"ID: {Id} Пользователь: {LastName} {FirstName} {Patronymic}\nТелефон: {Phone}\nСерия, номер пасспорта: {Passport}\n";
        }




    }
}
