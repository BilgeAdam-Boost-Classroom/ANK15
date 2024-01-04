using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranskriptApp.Models.Abstract;

namespace TranskriptApp.Models.Classes
{
    public abstract class BaseEntity : IBaseEntity
    {
        private static int _idCounter = 0;
        private int _id;
        public BaseEntity()
        {
            _id = ++_idCounter;
        }
        public int Id => _id;
    }
}
