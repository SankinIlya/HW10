using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class UserReader
    {
        public string ChangePhone()
        {
            Console.WriteLine("Введите телефон:");
            string newPhone = Console.ReadLine();
            return newPhone;
        }

        public string ChangeFirstName()
        {
            Console.WriteLine("Введите имя:");
            string newFirstName = Console.ReadLine();
            return newFirstName;
        }

        public string ChangeLastName()
        {
            Console.WriteLine("Введите Фамилию:");
            string newLastName = Console.ReadLine();
            return newLastName;
        }

        public string ChangePatronymic()
        {
            Console.WriteLine("Введите отчество");
            string newPatronymic = Console.ReadLine();
            return newPatronymic;
        }

        public string ChangePassport()
        {
            Console.WriteLine("Введите паспортные данные:");
            string newPassport = Console.ReadLine();
            return newPassport;
        }

        public User AddNewUser()
        {
            User user = new(1, ChangeLastName(), ChangeFirstName(), ChangePatronymic(), ChangePhone(), ChangePassport());
            return user;
        }
    }
}
