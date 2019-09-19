using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanka
{
    interface IMusteri//musteri class ında yazdıgımız metodlar icin sablon olarak bu interface i kullandık
    {
        void dosyayaYaz();
        void MusteriKayit();
        void Para();
        void ara();
        void dosyaOku();
        void musteriIslem();
    }
}
