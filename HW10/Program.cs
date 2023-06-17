namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository("Consultant.txt");
            rep.Load();
            Consultant con = new Consultant();
            Console.WriteLine("1 - Зайти под конультантом;\n2 - зайти под менеджером.");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Введите id пользователя для просмотра информации");
                int id = int.Parse(Console.ReadLine());
                User user = rep.FindId(id);
                Console.WriteLine(con.Read(user).ToString());
                Console.WriteLine("Изменить номер телефона?\n1 - Да;\n2 - Нет.");
                int change = int.Parse(Console.ReadLine());
                if(change == 1)
                {
                    Console.Write("Введите новый номер:");
                    string newPhone = Console.ReadLine();
                    var editedUser = new User(user);
                    editedUser.Phone = newPhone;
                    con.Edit(user,editedUser);
                }

            }
            else if(choose == 2) 
            {
                Consultant man = new Manager();


            }
           


        }
    }
}