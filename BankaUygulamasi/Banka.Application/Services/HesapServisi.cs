using Banka.Application.Interfaces;
using Banka.Data.Models;
using Banka.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Application.Services
{
    public class HesapServisi : IHesapServisi
    {
        private readonly IHesapRepository hesapRepository;

        public HesapServisi(IHesapRepository hesapRepository)
        {
            this.hesapRepository = hesapRepository;
        }

        public IEnumerable<Hesap> GetHesaps()
        {
            return hesapRepository.GetHesaps();
        }
    }
}
