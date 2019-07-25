using System;

namespace ConsoleApp13
{
    class Program
    {
        static void EkranaYaz(string yaz)
        {
            Console.WriteLine(yaz);
        }

        static string Oku()
        {
            return Console.ReadLine();
        }
        private static int IsGunuHesaplama(DateTime baslangic, DateTime bitis)
        {
            int gun = 0;
            while (baslangic < bitis)
            {
                if (baslangic.DayOfWeek != DayOfWeek.Saturday && baslangic.DayOfWeek != DayOfWeek.Sunday)
                {
                    ++gun;
                }
                baslangic = baslangic.AddDays(1);
            }
            return gun;
        }
        static void Main(string[] args)
        {
            EkranaYaz("Başlangıç Tarihini Giriniz: ");
            string baslangic = Oku();
            bool tarihMi1 = DateTime.TryParse(baslangic, out DateTime dt1);

            EkranaYaz("Bitiş Tarihini Giriniz: ");
            string bitis = Oku();
            bool tarihMi2 = DateTime.TryParse(bitis, out DateTime dt2);

            if (tarihMi1 && tarihMi2)
            {
                if (dt2 > dt1)
                {
                    EkranaYaz(IsGunuHesaplama(dt1, dt2).ToString());
                }
                else
                {
                    EkranaYaz("Başlangıç tarihi bitiş tarihinden daha önce olmalıdır");
                }
            }
            else
            {
                EkranaYaz("Geçerli bir tarih girmediniz!!");
            }
        }
    }
}
