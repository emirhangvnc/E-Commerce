using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base
{
    public static class BaseConstantsTR
    {
        private class TRWorker : BaseConstantsStandart.BaseWorker
        {
            internal override string NotNull()
            {
                return "Boş Geçilemez";
            }
            internal override string Added()
            {
                return "Eklendi";
            }
            internal override string Deleted()
            {
                return "Silindi";
            }
            internal override string Updated()
            {
                return "Güncellendi";
            }
            internal override string Listed()
            {
                return "Listelendi";
            }
            internal override string Search()
            {
                return "Aranan";
            }
            internal override string LoginSuccessful()
            {
                return "Giriş Başarılı";
            }
            internal override string Summoned()
            {
                return "İstenilen";
            }
            internal override string AlreadyExists()
            {
                return "Zaten Mevcut";
            }
            internal override string NotFound()
            {
                return "Bulunamadı";
            }
            internal override string Name()
            {
                return "İsim";
            }
            internal override string ID()
            {
                return "Birincil Anahtar(ID)";
            }
            internal override string Created()
            {
                return "Oluşturuldu";
            }
            internal override string Max()
            {
                return "Maksimum";
            }
            internal override string Min()
            {
                return "Minimum";
            }
            internal override string Entered()
            {
                return "Girilebilir";
            }
            internal override string Code()
            {
                return "Kod";
            }
            internal override string Password()
            {
                return "Şifre";
            }
            internal override string Invalid()
            {
                return "Geçersiz";
            }
            internal override string File()
            {
                return "Dosya";
            }
            internal override string Image()
            {
                return "Fotoraf";
            }
            internal override string For()
            {
                return "For";
            }
            internal override string Extension()
            {
                return "Uzantı";
            }
            internal override string Accepted()
            {
                return "Kabul Edilen";
            }
            internal override string FirstName()
            {
                return $"{BaseConstantsTR.Name}";
            }
            internal override string LastName()
            {
                return "Soyad";
            }
            internal override string DateOfBirth()
            {
                return "Doğum Günü";
            }
            internal override string Stock()
            {
                return "Stok";
            }
            internal override string Character()
            {
                return "Character";
            }
        }
        readonly static TRWorker worker = new TRWorker();
        public static string NotNull = worker.NotNull();
        public static string Added = worker.Added();
        public static string Deleted = worker.Deleted();
        public static string Updated = worker.Updated();
        public static string Listed = worker.Listed();
        public static string Search = worker.Search();
        public static string LoginSuccessful = worker.LoginSuccessful();
        public static string Summoned = worker.Summoned();
        public static string AlreadyExists = worker.AlreadyExists();
        public static string NotFound = worker.NotFound();
        public static string Name = worker.Name();
        public static string ID = worker.ID();
        public static string Created = worker.Created();
        public static string Max = worker.Max();
        public static string Min = worker.Min();
        public static string Entered = worker.Entered();
        public static string Code = worker.Code();
        public static string Password = worker.Password();
        public static string Invalid = worker.Invalid();
        public static string File = worker.File();
        public static string Image = worker.Image();
        public static string For = worker.For();
        public static string Extension = worker.Extension();
        public static string Accepted = worker.Accepted();
        public static string FirstName = worker.FirstName();
        public static string LastName = worker.LastName();
        public static string EMail = worker.EMail();
        public static string DateOfBirth = worker.DateOfBirth();
        public static string Stock = worker.Stock();
        public static string Character = worker.Character();
    }
}