using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimOopOrnek
{
    class SiteBilgileri
    {
        //listeleri ve blok sayısını tutcaz
        //2.yol
        //public SiteBilgileri()
        //{
        //   DaireListesi = new List<Daire>();
        //}

        public List<Daire> DaireListesi { get; set; } = new List<Daire>(); //1. yol //bunu yapmazsak daire listesi null kalıyor yeni oluşturmuyor.
        public List<Dukkan> DukkanListesi { get; set; } = new List<Dukkan>();
        public int BlokSayisi { get; set; } = 10;
    }
}
