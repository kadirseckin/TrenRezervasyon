using System;
using System.Collections.Generic;
using System.Text;

namespace TrenRezervasyon.Entities
{
    public class RezervasyonRequest
    {
        public Tren Tren { get; set; }
        public int RezervasyonYapilacakKisiSayisi { get; set; }
        public bool KisilerFarkliVagonlaraYerlestirilebilir { get; set; }
    }
}
