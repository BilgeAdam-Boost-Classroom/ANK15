using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15LoadingChangeTracker.Concrete
{
    public class Onay
    {
        public int Id { get; set; } 
        public bool IsSuccess { get; set; }   
        public virtual Bandrol Bandrol { get; set; }
    }
}
