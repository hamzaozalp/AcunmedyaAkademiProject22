using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunmedyaAkademiProject2._0.Entities
{
    public class Tatli
    {
        public int Id { get; set; }
        public int SatisSayisi { get; set; } // Satış sayısı
        public string Ad { get; set; } // Tatlının adı
        public string ResimUrl { get; set; } // Tatlının resmi
        public string Aciklama { get; set; } // Tatlının açıklaması
        public decimal Fiyat { get; set; } // Tatlının fiyatı

    }
}