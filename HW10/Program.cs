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
            EditUser correct = new EditUser();

            int choose = menu.ChooseEmployee();

            if (choose == 1)
            {
                con = new Consultant();
                int id = menu.ChooseUserId();
                User user = rep.FindId(id);
                Console.WriteLine(con.Read(user).ToString());

                int change = menu.ChooseCorrect();

                if (change == 5)
                {
                    var editedUser = new User(user);
                    editedUser.Phone = correct.ChangePhone();
                    con.Edit(user, editedUser);
                }
                else Console.WriteLine("Нет прав");
            }
            else
            {
                con = new Manager();
                int id = menu.ChooseUserId(); //дублирование 
                User user = rep.FindId(id); //дублирование 
                Console.WriteLine(con.Read(user).ToString()); //дублирование 

                int change = menu.ChooseCorrect(); //дублирование 

                User editUser = new User(user);

                switch (change)
                {
                    case 1:
                        editUser.FirstName = correct.ChangeFirstName();
                        break;

                    case 2:
                        editUser.LastName = correct.ChangeLastName();
                        break;

                    case 3:
                        editUser.Patronymic = correct.ChangePatronymic();
                        break;

                    case 4:
                        editUser.Passport = correct.ChangePassport();
                        break;

                    case 5:
                        editUser.Phone = correct.ChangePhone();
                        break;
                }


            }



        }
    }
}