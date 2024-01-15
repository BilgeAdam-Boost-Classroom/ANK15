using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_A_13.Model
{
    internal class Engineer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CarId { get; set; }
        public virtual ICollection<Car> Cars { get; set; }  
    }
}
