using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        // Method injection
        public void BasvuruYap(IKrediManager krediManeger, List<ILoggerService> loggerServices)
        {
            // Basvuran bilgilerini degerlendirme
            // 
            krediManeger.Hesapla();
            
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
