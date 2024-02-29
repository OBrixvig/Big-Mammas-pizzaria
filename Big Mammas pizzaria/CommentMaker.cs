using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Big_Mammas_pizzaria
{
    public class CommentMaker // thinking about destoying this class and make the same method in Order Class.
    {
        private string _comment;

        public void AddPizzaComment(string WhatYouWantTOSay)
        {
            _comment = WhatYouWantTOSay;
        }
        public string PizzaComment
        {
            get { return _comment; }
        }
        public override string ToString()
        {
            return _comment;
        }
    }
}
