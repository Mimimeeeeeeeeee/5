using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лб4.Model;

namespace Лб4.Helper
{
    internal class FindPerson
    {
        private int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Person role)
        {
            return role.Id == id;
        }
    }
}
