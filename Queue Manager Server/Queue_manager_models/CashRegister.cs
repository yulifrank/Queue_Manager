using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_manager_models
{
    internal class Position
    {
        public int Id { get; set; }
        public string representative { get; set; }
        public Person Person { get; set; }
        public Queue Queue { get; set; }
        
    }
}
