namespace HW10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository rep = new Repository("Consultant.txt");
            rep.Load();
            Consultant con;
            Menu menu = new Menu();

            int choose = menu.ChooseEmployee();

            if (choose == 1)
            {
                con = new Consultant();
                int id = menu.ChooseUserId();
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

               // Тест Тест

            }
            else 
            {
                con = new Manager();


            }
           


        }
    }
}