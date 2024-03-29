﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPal.Managers;

namespace TravelPal.Classes
{
    public class Vacation : Travel
    {
        public bool AllInclusive { get; set; }

        public Vacation(string destination, Country country, int travelers, bool allInclusive) : base(destination, country, travelers)
        {
            AllInclusive = allInclusive;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }

    }

}