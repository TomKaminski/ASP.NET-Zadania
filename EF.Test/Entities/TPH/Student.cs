using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Test.Entities.TPH
{
    public class Student : Person
    {
        public int IndexNo { get; set; }
    }
}
