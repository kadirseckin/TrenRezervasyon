using System;
using System.Collections.Generic;
using System.Text;
using TrenRezervasyon.BusinessLayer.Abstract;
using TrenRezervasyon.Entities;
using TrenRezervasyon.Entities.Response;
namespace TrenRezervasyon.BusinessLayer
{
    public class RezervasyonManager : IRezervasyonService
    {
        public RezervasyonResponse RezervasyonYap(RezervasyonRequest request)
        {
            RezervasyonResponse response = new RezervasyonResponse();
            Dictionary<string, int> vagonBilgiler = new Dictionary<string, int>();
            List<YerlesimAyrinti> yerlesim_list = new List<YerlesimAyrinti>();
            int kisi_sayi = request.RezervasyonYapilacakKisiSayisi;
            bool farkliVagonYerlesim = request.KisilerFarkliVagonlaraYerlestirilebilir;

            //Rezervasyon yapılabilecek koltuk sayılarını ve vagon isimlerini alıyoruz.
            foreach (Vagon vagon in request.Tren.Vagonlar)
            {
                int bosKoltukSayisi = 0;
                if (vagon.Kapasite * 0.7 - vagon.DoluKoltukAdet > 0)
                {
                    bosKoltukSayisi = Convert.ToInt32(vagon.Kapasite * 0.7 - vagon.DoluKoltukAdet);
                }

                vagonBilgiler.Add(vagon.Ad, bosKoltukSayisi);
            }



            foreach (var vagonBilgi in vagonBilgiler)
            {
                if (kisi_sayi > 0)
                {
                    if (vagonBilgi.Value != 0)
                    {
                        if (kisi_sayi > vagonBilgi.Value && farkliVagonYerlesim)
                        {
                            yerlesim_list.Add(new YerlesimAyrinti()
                            {
                                KisiSayisi = vagonBilgi.Value,
                                VagonAdi = vagonBilgi.Key,

                            });

                            kisi_sayi -= vagonBilgi.Value;

                        }
                        else if (kisi_sayi <= vagonBilgi.Value)
                        {
                            yerlesim_list.Add(new YerlesimAyrinti()
                            {
                                KisiSayisi = kisi_sayi,
                                VagonAdi = vagonBilgi.Key,

                            });

                            kisi_sayi = 0;

                        }
                    }

                    if (kisi_sayi == 0)
                    {
                        response.YerlesimAyrintilar = yerlesim_list;
                        response.RezervasyonYapilabilir = true;
                        return response;
                    }
                }

            }

            response.RezervasyonYapilabilir = false;
            response.YerlesimAyrintilar = new List<YerlesimAyrinti>();
            return response;
        }

    }
}
