using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15LoadingChangeTracker.Concrete
{
    public class Bandrol
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int OnayId { get; set; } 
        public virtual Onay Onay { get; set; }  
        public virtual Urun Urun { get; set; }  
    }
}
