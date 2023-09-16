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
            UserReader correct = new UserReader();

            int choose = menu.ChooseEmployee();

            if (choose == 1)
            {
                con = new Consultant();
            }
            else con = new Manager();

            while (true)
            {                
                int id = menu.ChooseUserId();                
                User user = rep.FindId(id);
                Console.WriteLine(con.Read(user).ToString());
                int change = menu.ChooseCorrect();

                if (con.GetType() == typeof(Consultant) && (change != 5 && change != 6))
                {
                    Console.WriteLine("Нет прав");
                    continue;
                }
                else if (change == 6)
                {
                    for (int i = 0; i < rep.Users.Count; i++)
                    {
                        user = rep.Users[i];
                        Console.WriteLine(con.Read(user).ToString());
                    }
                    continue;
                }

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
                    case 6:
                        Console.WriteLine(con.Read(user).ToString);
                        break;
                }

                bool result = con.TryEdit(user, editUser);

                Console.WriteLine(result ?
                    "Успешно" : "Не успешно");

                if (result)
                {
                    List<User> users = new List<User>(rep.Users);

                    for (int i = 0; i < users.Count; i++)
                    {
                        if (editUser.Id == users[i].Id)
                        {
                            users[i] = editUser;
                            rep.Save(users);
                            rep.Load();
                        }
                    }
                }                              
                
            }













        }
    }
}