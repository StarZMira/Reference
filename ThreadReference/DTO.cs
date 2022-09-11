﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadReference
{
    public class DTO
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public DTO(string id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
