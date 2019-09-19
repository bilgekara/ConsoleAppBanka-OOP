using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBanka
{
    public interface IPersonel//personel class ında yazdıgımız metodlar icin sablon olarak bu interface i kullandık
    {
        void dosyayaYaz();
        void PersonelKayit();
        void Listele();
    }
}
