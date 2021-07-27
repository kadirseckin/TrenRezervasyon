using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TrenRezervasyon.BusinessLayer.Abstract;
using TrenRezervasyon.Entities;
using TrenRezervasyon.Entities.Response;

namespace TrenRezervasyon.API.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class RezervasyonController : ControllerBase
    {
        private IRezervasyonService _service;

        //dependency injection
        public RezervasyonController(IRezervasyonService service)
        {
            _service = service;    
        }

        /// <summary>
        /// Rezervasyon istenilen trenin bilgileri, vagon ayrıntıları, kaç kişilik rezervasyon istenildiği ve kişilerin farklı vagonlara yerleştirilip yerleştirilemeyeceği bilgilerini verdiğinizde size rezervasyonun yapılıp yapılamayacağını ve yapılabiliyorsa hangi vagonlara kaç kişinin yerleştirildiğini bilgisini döner.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public RezervasyonResponse Post([FromBody]RezervasyonRequest request)
        {
            return _service.RezervasyonYap(request);
        }
    }
}
