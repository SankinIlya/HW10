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

        public override bool TryEdit(User user, User editUser)
        {
            user = editUser;
            return true;
        }
    }
}
