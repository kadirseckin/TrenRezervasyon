using System;
using System.Collections.Generic;
using System.Text;

namespace TrenRezervasyon.Entities.Response
{
    public class RezervasyonResponse
    {
        public bool RezervasyonYapilabilir { get; set; }
        public List<YerlesimAyrinti> YerlesimAyrintilar { get; set; }
    }
}
