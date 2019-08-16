using Banka.Data.Context;
using Banka.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Data.Repository
{
    public class HesapRepository : IHesapRepository
    {
        private BankaDbContext bankaDbContext;

        public HesapRepository(BankaDbContext bankaDbContext)
        {
            this.bankaDbContext = bankaDbContext;
        }

        public IEnumerable<Hesap> GetHesaps()
        {
            return bankaDbContext.Hesaps;
        }
    }
}
