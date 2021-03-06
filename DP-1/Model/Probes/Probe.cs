﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_1.Model.Probes
{
    public class Probe
    {
        public Gate Gate { get; set; }

        public string Name { get; set; }

        public bool? Result
        {
            get
            {
                return Gate.result();
            }
        }
        public override string ToString()
        {
            return this.Name + "\t" + this.Result;
        }


    }
}
