using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Menu
    {
        public int ChooseEmployee()
        {            
            Console.WriteLine("1-Cons \n2-Man");
            int result = int.Parse(Console.ReadLine());
            return result;
        }       

        public int ChooseUserId()
        {
            Console.WriteLine("Введите id пользователя для просмотра информации");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public int ChooseCorrect()
        {
            Console.WriteLine("1 - Изменить имя \n2 - Изменить фамилию \n3 - Изменить отчество \n" +
                "4 - Изменить паспорт \n5 - Изменить телефон \n6 - Показать всех клиентов \n7 - Создать пользователя");
            int result = int.Parse(Console.ReadLine());
            return result;
        }      



    }
}
