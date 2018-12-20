﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mijnZorgRooster.Models
{
    public class Certificaat
    {
        public int CertificaatID { get; set; }
        public int MedewerkerID { get; set; }
        public DateTime Datum { get; set; }
        public DateTime geldigTot { get; set; }

        public Medewerker Medewerker { get; set; }
    }
}
