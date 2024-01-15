using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_A_13.Model
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LicencePlateId { get; set; }
        public LicencePlate LicencePlate { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int EngineerId { get; set; }
        public ICollection<Engineer> Engineers { get; set; }
    }
}
