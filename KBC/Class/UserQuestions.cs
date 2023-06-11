using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBC.Class
{
    class UserQuestions
    {
        public Questions Questions { get; set; }
        public string UserAns { get; set; }

        public UserQuestions(Questions Questions, string UserAns)
        {
            this.Questions = Questions;
            this.UserAns = UserAns;
        }
    }
}
