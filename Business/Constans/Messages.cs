using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araç listeye eklendi.";
        public static string ColorAdded = "Araç rengi listeye eklendi. ";
        public static string BrandAdded = "Araç markası listeye eklendi.";

        public static string CarUpdate = "Araç güncellemesi başarılı.";
        public static string CarDeleted = "Araç listeden kaldırıldı.";
        public static string CarNotUpdate = "Araç güncellenmedi,lütfen araç ismini ve günlük fiyatını kontrol ediniz.";
        public static string CarNotDeleted = "Araç listeden kaldırılmadı lütfen araç ismini ve aracın günlük fiyatını kontrol ediniz.";
        public static string CarNotAdded = "Araç eklenmedi,lütfen araç ismini ve günlük fiyatını kontrol ediniz.";
        public static string CarNameInvalid = "Araç ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda...";
        public static string DailyPriceInvalid = "Aracın günlük fiyatı geçersiz ! ";
        public static string DailyPriceBigFromZero = "Aracın günlük fiyatı sıfırdan büyük olmalıdır.";
        public static string CarNameLengthBigFromTwo = "Araç isminin uzunluğu 2 karakterden uzun olmalıdır.";

        public static string CarsListed = "Araçlar listelendi : ";
        public static string ColorListed = "Araç renkleri listelendi :";
        public static string BranListed = "Araç markaları listelendi : ";

    }
}
