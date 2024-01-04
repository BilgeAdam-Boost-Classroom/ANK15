using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;

namespace TranskriptApp.Models.Classes.Managed
{
    public class OgrenciManager : BaseManager<Ogrenci>
    {
        public OgrenciManager(List<Ogrenci> list) : base(list)
        {
        }

        public override void Put(int id, Ogrenci ogrenciUpdate)
        {
            var ogrenci = _list.FirstOrDefault(o => o.Id == id);

            if (ogrenci != null)
            {
                ogrenci.Name = string.IsNullOrEmpty(ogrenciUpdate.Name) ? ogrenciUpdate.Name : ogrenci.Name;
                ogrenci.SurName = string.IsNullOrEmpty(ogrenciUpdate.SurName) ? ogrenciUpdate.SurName : ogrenci.SurName;
                ogrenci.Number = string.IsNullOrEmpty(ogrenciUpdate.Number) ? ogrenciUpdate.Number : ogrenci.Number;
            }
            else
            {
                MessageBox.Show("Ogrenci Bulunmamaktadir");
            }
        }
    }
}
