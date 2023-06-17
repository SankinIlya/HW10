using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Manager : Consultant
    {

        public override User Read(User user)
        {
            return user;
        }


        public override User Edit(User user, User editUser)
        {
            return user;
        }

    }
}
