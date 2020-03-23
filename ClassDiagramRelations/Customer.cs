using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagramRelations
{
    public class Customer: People
    {
        public int CustomerId { get; set; }
        public Account Account { get; set; }
    }
}
