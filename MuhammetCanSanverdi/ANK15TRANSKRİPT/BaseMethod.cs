using ANK15TRANSKRİPT.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15TRANSKRİPT
{
    public class BaseMethod
    {
        public static void AddHeadDataGridView(Type type,DataGridView dataGridView)
        {
            foreach (var property in type.GetProperties())
            {
                dataGridView.Columns.Add(property.Name, property.Name);
            }
        }
    }
}
