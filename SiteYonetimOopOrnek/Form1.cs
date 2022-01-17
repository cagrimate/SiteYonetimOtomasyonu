using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteYonetimOopOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SiteBilgileri site = new SiteBilgileri(); //site.bloksayısına erişmek icin burada belirliyoruz.
        //1.yol mulkler
        List<Mulk> mulkler;

        private void Form1_Load(object sender, EventArgs e)
        {
            //10 bloktan(bina) oluşan bir site olsun. adı YasamSitesi
            //bloklar A1,A2,A3...A10 a kadar isimlendirilmiştir.
            //her blokta son kullanıcı istediği kadar daire veya dükkan ekleyebilir.
            //her mülk için mülk sahibi olmalı, mülk sahibi adı soyadı yazılabilsin.
            //her mülk için metrekare bilgisi alınsın
            //her mülkin kiracısı var mı bilgisi alınmalı
            //her mülk daire ise metrekare basına 1.3(katsayı), dükkansa 1.7(katsayısı) ile güvenlik aidatı oluştur
            //her mülkün daire ise metrekare  0.2(katsayı), dükkan ise (0.7) katsayısı ile çevre giderleri aidatı oluştur
            //güvenlik aidatı kiracı tarafından ödenir
            //çevre gider aidatı mülk sahibi tarafından ödenir
            //kiracı yoksa ikisini de mülk sahibi öder
            //her kayıtta bir messagebox ile şu bilgiyi döndürelim:
            //      "ÖRNEK: Daire A3 Bloktadır. Mülk Sahibi : Ahmet Öz Kişisi Aylık 23 TL tutarında Aidat Öder. kiracı yok "
            //      "ÖRNEK: Daire A3 Bloktadır. Mülk Sahibi : Ahmet Öz Kişisi Aylık 23 TL tutarında Aidat Öder. kiracı 12.5 tl aidat öder "
            //kayıtları grid içerisinde listeleyelim ve bir dosyaya kaydedip program acıldıgında oradan okuyalım
            //                                              Çözümler                                                            .
            //1. yol mülk sınıfı abstract olacak. daire ve dükkan sınıfına kalıtım verecek
            //2. yol daire ve dükkan sınıfı alığ kalıtım almaya gerek kalmaz
            //daire sınıfı yaratıp virtual metotlar yazıp, dükkan sınıfına daire sınıfından miras verilir,virtual metotlar override edilir

            for (int i = 1; i <= site.BlokSayisi; i++)
            {
                // cmbBloklar.Items.Add($"A{i}");
                cmbBloklar.Items.Add("A" + i.ToString());
            }
            cmbBloklar.SelectedIndex = 0;
            rdbDaire.Checked = true;
            btnKaydet.Enabled = false;
            //1.yol mulkler
            mulkler = new List<Mulk>(site.DaireListesi);
            mulkler.AddRange(site.DukkanListesi);//liste vermek icin
            if (File.Exists("veri.json"))
            {
                string dosyamiz = File.ReadAllText("veri.json");
                site = JsonConvert.DeserializeObject<SiteBilgileri>(dosyamiz);
            }
            


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (rdbDaire.Checked == true)
            {
                Daire d = new Daire();
                d.BlokNo = cmbBloklar.SelectedItem.ToString();
                d.KiraciVarMi = chkKiraci.Checked;
                d.MetreKare = Convert.ToInt32(nmdMetreKareBilgisi.Value);
                d.MulkSahibi = txtMulkSahibi.Text;
                //3.yol
                //site.DaireListesi = new List<Daire>();
                site.DaireListesi.Add(d);
                mulkler.Add(d);

                MessageBox.Show(d.BilgileriOluştur());
            }
            else
            {
                Dukkan dk = new Dukkan();
                dk.BlokNo = cmbBloklar.SelectedItem.ToString();
                dk.KiraciVarMi = chkKiraci.Checked;
                dk.MetreKare = Convert.ToInt32(nmdMetreKareBilgisi.Value);
                dk.MulkSahibi = txtMulkSahibi.Text;
                site.DukkanListesi.Add(dk);
                mulkler.Add(dk);

                MessageBox.Show(dk.BilgileriOluştur());
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mulkler;
        }

        private void nmdMetreKareBilgisi_ValueChanged(object sender, EventArgs e)
        {
            kaydetBtnKontrol();
        }
        void kaydetBtnKontrol()//method oluşturduk
        {
            if (cmbBloklar.SelectedIndex != -1 && (rdbDaire.Checked == true || rdbDukkan.Checked == true) && (nmdMetreKareBilgisi.Value > 0) && txtMulkSahibi.Text != "" && !string.IsNullOrEmpty(txtMulkSahibi.Text))
            {
                btnKaydet.Enabled = true;
            }
            else
                btnKaydet.Enabled = false;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //form kapandıgında bilgileri saklamak icin yapıyoruz.
            string dosya = JsonConvert.SerializeObject(site);
            File.WriteAllText("veri.json", dosya);
        }
    }
}
