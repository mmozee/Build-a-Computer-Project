﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birth_of_a_Computer
{
    class Applications

    {
        //member variable - Have A
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRam;
        public double RequiredStorage;

        public Applications()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRam = 4.0;
            RequiredStorage = 0.512;

        }
    }
}
