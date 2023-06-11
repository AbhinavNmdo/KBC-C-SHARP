using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBC.Class
{
    class User
    {
        public string Name { get; set; }
        public List<UserQuestions> UserQuestions { get; set; }
        public int MoneyWon { get; set; }
        public int TempMoneyWon { get; set; }
    }
}
