﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly.Console.Models
{
    internal class Property : Street
    {
        public List<string> Prop { get; set; }
        public List<string> Rent { get; set; }
    }
}