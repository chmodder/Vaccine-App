﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine_App.Model
{
    class Vaccinehistorik
    {
        public string VaccineNavn { get; set; }
        public DateTime Dato { get; set; }
        public double Vaccineret { get; set; }

        public Vaccinehistorik(string VaccineNavn, DateTime Dato, double Vaccineret)
        {
            this.VaccineNavn = VaccineNavn;
            this.Vaccineret = Vaccineret;
            this.Dato = Dato;
        }
    }
}
