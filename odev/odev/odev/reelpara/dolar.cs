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
    public class dolar : ContentPage
    {
        public dolar()
        {
            Title = "DOLAR";
            string bugun = "https://www.tcmb.gov.tr/kurlar/today.xml"; // kur fiyatları çekilecek olan web adresi
            var xmldoc = new XmlDocument();
            xmldoc.Load(bugun);
            //istenilen alış ve satış fiyatı verileri xml formatında filtrelenerek çekiliyor
            string dolar_satis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            string dolar_alis = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            Content = new StackLayout
            {
                BackgroundColor = Color.SkyBlue, //arka plan resmi ayarlanıyor
                Children = {
                    new Label {
                        Text = "DOLAR ALIŞ FİYATI : "+ dolar_alis + "\nDOLAR SATIŞ FİYATI : "+ dolar_satis, //ekrana çekilen fiyatlar yazdırılıyor

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