using Banka.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Application.Interfaces
{
    public interface IHesapServisi
    {
        IEnumerable<Hesap> GetHesaps();
    }
}
