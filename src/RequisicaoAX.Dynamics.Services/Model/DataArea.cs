﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisicaoAX.Dynamics.Model
{
    public class DataArea
    {
        public string ID { get; set; }

        public string NAME { get; set; }

        public int ISVIRTUAL { get; set; }

        public int ALWAYSNATIVE { get; set; }

        public int TIMEZONE { get; set; }

        public int RECVERSION { get; set; }

        public long PARTITION { get; set; }

        public long RECID { get; set; }
    }
}
