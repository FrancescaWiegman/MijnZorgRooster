﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mijnZorgRooster.Models
{
    public class Certificaat
    {
        private int CertificaatID { get; set; }
        private int MedewerkerID { get; set; }
        private DateTime Datum { get; set; }
        private DateTime geldigTot { get; set; }

        public Medewerker Medewerker { get; set; }
    }
}
