﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFÖdev.Models
{
    public class Supplier:BaseModel
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set;}
        public string ContactTitle { get; set;}
        public string Address { get; set;}

    }
}
