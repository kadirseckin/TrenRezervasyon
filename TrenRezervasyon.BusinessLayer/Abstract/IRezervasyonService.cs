using System;
using System.Collections.Generic;
using System.Text;
using TrenRezervasyon.Entities;
using TrenRezervasyon.Entities.Response;

namespace TrenRezervasyon.BusinessLayer.Abstract
{
    public interface IRezervasyonService
    {
        RezervasyonResponse RezervasyonYap(RezervasyonRequest request);
    }
}
