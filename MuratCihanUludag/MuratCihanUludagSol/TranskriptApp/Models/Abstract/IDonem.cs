﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranskriptApp.Models.Abstract
{
    public interface IDonem : IBaseEntity
    {
        public string Name { get; set; }

    }
}