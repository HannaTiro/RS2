﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.VM
{
    public class frmFotografiVM
    {
        public int FotografId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public string TipFotografa { get; set; }
        public double DnevnaCijena { get; set; }
        public string Status { get; set; }
        public string Opis { get; set; }

    }
}
