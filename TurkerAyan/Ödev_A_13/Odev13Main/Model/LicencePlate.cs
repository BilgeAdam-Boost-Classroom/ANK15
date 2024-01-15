using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_A_13.Model
{
    internal class LicencePlate
    {
        public int Id { get; set; }
        public string PlateNumber{ get; set; }
        public Car Car { get; set; }
    }
}
