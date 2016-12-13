﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientPortApp
{
    public class Apparaat
    {
        public string macadres { get; private set; }
        public int blockedport { get; private set; }
        public bool block { get; private set; }

        public Apparaat(string macadres)
        {
            this.macadres = macadres;
        }
        public Apparaat(int blockedport, bool block)
        {
            this.blockedport = blockedport;
            this.block = block;
        }
    }
}
