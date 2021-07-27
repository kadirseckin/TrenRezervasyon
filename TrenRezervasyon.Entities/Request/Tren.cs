using System;
using System.Collections.Generic;
using System.Text;

namespace TrenRezervasyon.Entities
{
    public class Tren
    {
        public string Ad { get; set; }
        public List<Vagon> Vagonlar { get; set; }
    }
}
