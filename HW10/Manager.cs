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
            
            if (editUser.Phone == string.Empty)
            {
                return false;
            }
            return true;
        }

        protected override bool CheckInfo(User user, User editUser)
        {
            return true;
        }
    }
}
