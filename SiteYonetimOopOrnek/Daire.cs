using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimOopOrnek
{
    class Daire : Mulk
    {
        public Daire()
        {
            CevreAidatKatsayisi = 0.2m;
            GuvenlikAidatKatsayisi = 1.3m;
            
        }
        public override string BilgileriOluştur()
        {
            decimal mulkSahibiAidati = KiraciVarMi ? HesaplaCevreAidati() : HesaplaCevreAidati() + HesaplaGuvenlikAidati();

            return "Daire :" +BlokNo +" Bloktadır." + " Mülk Sahibi :"+ MulkSahibi + " Kişisi Aylık " + mulkSahibiAidati.ToString() + " ₺ Tutarında aidat öder. Kiracısı :" + (KiraciVarMi?  HesaplaGuvenlikAidati() + " ₺ tutarında aidat öder" : " Yok ");

           
        }

        public override decimal HesaplaCevreAidati()
        {
           return MetreKare* CevreAidatKatsayisi;

        }

        public override decimal HesaplaGuvenlikAidati()
        {
            return MetreKare * GuvenlikAidatKatsayisi;
        }
    }
}
