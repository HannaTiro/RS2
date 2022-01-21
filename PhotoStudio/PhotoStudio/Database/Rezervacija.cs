﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PhotoStudio.Database
{ 
    public partial class Rezervacija
    {
        public int RezervacijaId { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }

        public virtual Fotograf Fotograf{ get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}