﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookservice.WebAPI.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }


        public Publisher()
        {
        }

        public Publisher(int id, string name, string country)
        {
            this.Id = id; //
            Name = name;
            Country = country;
        }
    }
}
