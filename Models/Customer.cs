﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969MatthewSmith.Models
{
    public class Customer
    {
   
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string AddressName { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; } 
        public string Phone { get; set; }
        public int AddressId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
    }
}
