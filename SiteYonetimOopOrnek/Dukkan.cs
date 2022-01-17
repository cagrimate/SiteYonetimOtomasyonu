using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimOopOrnek
{
    class Dukkan : Mulk
    {
        public Dukkan()
        {
            CevreAidatKatsayisi = 0.7m;
            GuvenlikAidatKatsayisi = 1.7m;

        }
        public override string BilgileriOluştur()
        {
            decimal mulkSahibiAidati = KiraciVarMi ? HesaplaCevreAidati(): HesaplaCevreAidati() + HesaplaGuvenlikAidati();

            return " Dükkan : " +BlokNo +" Bloktadır. " + " Mülk Sahibi : " +MulkSahibi + " Kişisi Aylık " + mulkSahibiAidati.ToString() + " ₺ Tutarında aidat öder. Kiracısı :" + (KiraciVarMi ? HesaplaGuvenlikAidati() + " ₺ tutarında aidat öder" : " Yok ");
        }

        public override decimal HesaplaCevreAidati()
        {
            return MetreKare * CevreAidatKatsayisi;
        }

        public override decimal HesaplaGuvenlikAidati()
        {
            return MetreKare * GuvenlikAidatKatsayisi;
        }
    }
}
