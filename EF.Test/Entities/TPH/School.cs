using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Test.Entities.TPH
{
    public class School
    {
        public int Id { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        public School()
        {
            Persons=new HashSet<Person>();
        }
    }
}
