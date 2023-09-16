using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class History
    {
        public DateTime TimeEdit { get; set; } = DateTime.Now;

        public string WhatEdit { get; set; } 

        public string WhoEdit { get; set; }

        public History(DateTime timeEdit, string whatEdit, string whoEdit) 
        {
            TimeEdit = timeEdit;
            WhatEdit = whatEdit;
            WhoEdit = whoEdit;
        }

        public History() 
        {

        }

        public override string ToString()
        {
            return $"Время изменения {TimeEdit}, Изменил {WhoEdit}, Изменение {WhatEdit}";
        }
    }
}
