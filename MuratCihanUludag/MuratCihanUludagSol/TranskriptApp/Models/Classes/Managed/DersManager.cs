using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptApp.Models.Classes.Managed
{
    public class DersManager : BaseManager<Ders>
    {
        public DersManager(List<Ders> list ) : base(list)
        {
        }
        public override void Put(int id,Ders dersUpdate)
        {
            var ders = _list.FirstOrDefault(o => o.Id == id);

            if (ders != null)
            {
                ders.Name = string.IsNullOrEmpty(dersUpdate.Name) ? dersUpdate.Name : ders.Name;
            }
            else
            {
                MessageBox.Show("Ders Bulunmamaktadir");
            }
        }
    }
}
