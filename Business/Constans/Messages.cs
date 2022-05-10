using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarsNotListed = "Arabalar listelenmedi";
        public static string CarDeleted = "Araba silindi";
        public static string CarGet = "Araç bilgisi getirildi";
        public static string CarNameAvailable = "Araba ismi var";
        public static string ColorLimit = "Renk eklenemez";
        public static string ModelLimit = "Bir modelden en fazla 10 adet olabilir";

        public static string CarImageAdded = "Araba fotoğrafı eklendi";
        public static string CarImageUpdated = "Araba fotoğrafı güncellendi";
        public static string CarImageLimitExceded = "Bir arabanın en fazla 5 fotoğrafı olabilir";
        public static string CarImageDeleted = "Araba Fotoğrafı silindi";
        public static string CarImagesListed = "Araba fotoğrafları listelendi";

        public static string AuthorizationDenied = "Yetkilendirme bulunmamaktadır";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string CardAdded = "Card Eklendi";
        public static string CreditCardNumberAllreadyExists = "Kredi Kartı Numarası Mevcut";
        public static string CardsDeleted = "Kredi Kartı Silindi";
        public static string CardsUpdated = "Kredi Kartı Güncellendi";
        public static string CardsListed = "Kredi Kartları listelendi";
        public static string GetCardPaymetsByCustomerIdListed = "Kredi Kartı Numarası ile Ödeme işlemi Müşteri Numarasına Göre Listelendi";

        public static string PaymentSuccessful = "Ödeme işlemi başarılı";

        public static string RentalError = "Araç şu anda kiralanamaz";
        public static string RentalAdded = "Kiralama bilgisi başarı ile eklendi";
        public static string RentalDeleted = "Kiralama bilgisi başarı ile silindi";
        public static string RentalUpdated = "Kiralama bilgisi başarı ile güncellendi";
        public static string ErrorRentalUpdate = "Araç şu anda kirada değil, sonlandırma başarısız";
        public static string SuccessRentalUpdate = "Kiralama başarı ile sonlandırıldı";

        public static string CustomerAdded = "Müşteri başarı ile eklendi";
        public static string CustomerDeleted = "Müşteri başarı ile silindi";
        public static string CustomerUpdated = "Müşteri başarı ile güncellendi";
        public static string CarIsNotAvailable { get; internal set; }

        public static string BrandDeleted = "Marka başarı ile silindi";
        public static string BrandUdpdated = "Marka başarı ile güncellendi";
        public static string BrandAdded = "Marka başarı ile eklendi";
    }
}
