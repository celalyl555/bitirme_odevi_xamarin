using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using System.IO;
using System.Net;
using System.Xml;

namespace odev.reelpara
{
    public class euro : ContentPage
    {
        public euro()
        {
            Title = "EURO";
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml";// kur fiyatları çekilecek olan web adresi
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            //istenilen alış ve satış fiyatı verileri xml formatında filtrelenerek çekiliyor
            string euro_satis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            string euro_alis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            Content = new StackLayout
            {
                BackgroundColor = Color.SkyBlue,//arka plan resmi ayarlanıyor
                Children = {
                    new Label {
                        Text = "EURO ALIŞ FİYATI : "+ euro_alis + "\nEURO SATIŞ FİYATI : "+ euro_satis, //ekrana çekilen fiyatlar yazdırılıyor

                        BackgroundColor = Color.Black,//yazı yazan yerin arka planı ayarlanıyor
                        TextColor= Color.White, //yazı rengi ayarlanıyor
                        VerticalOptions= LayoutOptions.CenterAndExpand,//x ekseninde ortalanıyor
                        HorizontalOptions= LayoutOptions.CenterAndExpand,//y ekseninde ortaşanıyor
                        FontSize=25,//yazı boutu ayarlanıyor
                        



                    }



                }
            };






        }
    }
}