﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine_App.Model;
using Vaccine_App.View;
using Vaccine_App.ViewModel;

namespace Vaccine_App.Handler
{
    class BarnHandler
    {
        // denne klasse hed engang BrugerHandler
        public BrugerViewmodel BrugerViewmodel { get; set; }

        public BarnHandler(BrugerViewmodel bvm)
        {
            this.BrugerViewmodel = bvm;
        }

        
        public void CreateBarn()
        {
            Model.Barn tempBarn = new Model.Barn(BrugerViewmodel.Fødselsdato, BrugerViewmodel.DeviceId, BrugerViewmodel.Gender, BrugerViewmodel.BarnNavn, BrugerViewmodel.Tlfnr);
            tempBarn.Fødselsdato = BrugerViewmodel.Fødselsdato;
            tempBarn.DeviceId = BrugerViewmodel.DeviceId;
            tempBarn.Gender = BrugerViewmodel.Gender;
            tempBarn.BarnNavn = BrugerViewmodel.BarnNavn;
            tempBarn.Tlfnr = BrugerViewmodel.Tlfnr;
            BarnSingleton.Instance.AddBarn(tempBarn);
        }

        public void DeleteBarn()
        {
            BarnSingleton.Instance.RemoveBarn(BrugerViewmodel.SelectedBarn);
        }

    }
}
