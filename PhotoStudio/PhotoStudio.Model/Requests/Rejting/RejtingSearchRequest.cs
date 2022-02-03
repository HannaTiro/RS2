﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoStudio.Data.Requests.Rejting
{
   public  class RejtingSearchRequest
    {
        public string ImeFotografa { get; set; }
        public string PrezimeFotografa { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public int? Ocjena { get; set; }
        
        public int? KorisnikId { get; set; }
        public int? FotografId { get; set; }
        

     
    }
}
