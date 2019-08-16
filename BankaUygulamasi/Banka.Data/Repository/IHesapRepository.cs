using Banka.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Data.Repository
{
    public interface IHesapRepository
    {
        IEnumerable<Hesap> GetHesaps();
    }
}
