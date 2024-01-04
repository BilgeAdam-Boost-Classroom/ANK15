using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptApp.Models.Classes.Managed
{
    public class OgrenciDersManaged : BaseManager<OgrenciDers>
    {
        public OgrenciDersManaged(List<OgrenciDers> list) : base(list)
        {
        }
        public override void Put(int id, OgrenciDers item)
        {
            base.Put(id, item);
        }
    }
}
