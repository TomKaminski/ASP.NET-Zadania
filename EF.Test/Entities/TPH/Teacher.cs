using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Test.Entities.TPH
{
    public class Teacher:Person
    {
        public string Title { get; set; }
    }
}
