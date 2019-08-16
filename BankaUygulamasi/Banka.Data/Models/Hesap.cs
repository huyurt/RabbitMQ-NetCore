using System;
using System.Collections.Generic;
using System.Text;

namespace Banka.Data.Models
{
    public class Hesap
    {
        public int Id { get; set; }
        public string HesapTuru { get; set; }
        public decimal Bakiye { get; set; }
    }
}
