using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimOopOrnek
{
    abstract class Mulk
    {
        public string BlokNo { get; set; }
        public string MulkSahibi { get; set; }
        public int MetreKare { get; set; }
        public bool KiraciVarMi { get; set; }
        public abstract decimal HesaplaCevreAidati();
        public abstract decimal HesaplaGuvenlikAidati();
        public abstract string BilgileriOluştur();
        
        public decimal GuvenlikAidatKatsayisi { get; set; }
        public decimal CevreAidatKatsayisi { get; set; }


    }
}
