using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract.Managed;

namespace TranskriptApp.Models.Classes.Managed
{
    public class DonemManger : BaseManager<Donem>
    {
        public DonemManger(List<Donem> list) : base(list)
        {
        }
        public override void Put(int id, Donem donemUpdate)
        {
            var donem = _list.FirstOrDefault(o => o.Id == id);

            if (donem != null)
            {
                donem.Name = string.IsNullOrEmpty(donemUpdate.Name) ? donemUpdate.Name : donem.Name;
            }
            else
            {
                MessageBox.Show("Donem Bulunmamaktadir");
            }
        }
    }
}
