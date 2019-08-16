using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banka.Application.Interfaces;
using Banka.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banka.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankaController : ControllerBase
    {
        private readonly IHesapServisi hesapServisi;

        public BankaController(IHesapServisi hesapServisi)
        {
            this.hesapServisi = hesapServisi;
        }

        // GET api/banka
        [HttpGet]
        public ActionResult<IEnumerable<Hesap>> Get()
        {
            return Ok(hesapServisi.GetHesaps());
        }
    }
}
