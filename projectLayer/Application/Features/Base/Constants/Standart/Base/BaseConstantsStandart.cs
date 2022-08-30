
namespace projectLayer.Application.Features.Base.Constants.Standart.Base
{
    internal static class BaseConstantsStandart
    {
        internal class BaseWorker
        {
            internal virtual string NotNull()
            {
                return "Not Null";
            }
            internal virtual string Added()
            {
                return "Added";
            }
            internal virtual string Deleted()
            {
                return "Deleted";
            }
            internal virtual string Updated()
            {
                return "Updated";
            }
            internal virtual string Listed()
            {
                return "Listed";
            }
            internal virtual string Search()
            {
                return "Search";
            }
            internal virtual string LoginSuccessful()
            {
                return "Login Successful";
            }
            internal virtual string Summoned()
            {
                return "Summoned";
            }
            internal virtual string AlreadyExists()
            {
                return "Already Exists";
            }
            internal virtual string NotFound()
            {
                return "Not Found";
            }
            internal virtual string Name()
            {
                return "Name";
            }
            internal virtual string ID()
            {
                return "ID";
            }
            internal virtual string Created()
            {
                return "Created";
            }
            internal virtual string Max()
            {
                return "Max";
            }
            internal virtual string Min()
            {
                return "Min";
            }
            internal virtual string Entered()
            {
                return "Can Be Entered";
            }
            internal virtual string Code()
            {
                return "Code";
            }
            internal virtual string Password()
            {
                return "Password";
            }
            internal virtual string Invalid()
            {
                return "Invalid";
            }
            internal virtual string File()
            {
                return "File";
            }
            internal virtual string Image()
            {
                return "Image";
            }
            internal virtual string For()
            {
                return "For";
            }
            internal virtual string Extension()
            {
                return "Extension";
            }
            internal virtual string Accepted()
            {
                return "Accepted";
            }
            internal virtual string FirstName()
            {
                return $"First {BaseConstantsStandart.Name}";
            }
            internal virtual string LastName()
            {
                return $"Last {BaseConstantsStandart.Name}";
            }
            internal virtual string EMail()
            {
                return "E-Mail";
            }
            internal virtual string DateOfBirth()
            {
                return "Date Of Birth";
            }
            internal virtual string Stock()
            {
                return "Stock";
            }
        }
        readonly static BaseWorker worker = new BaseWorker();
        internal static string NotNull = worker.NotNull();
        internal static string Added = worker.Added();
        internal static string Deleted = worker.Deleted();
        internal static string Updated = worker.Updated();
        internal static string Listed = worker.Listed();
        internal static string Search = worker.Search();
        internal static string LoginSuccessful = worker.LoginSuccessful();
        internal static string Summoned = worker.Summoned();
        internal static string AlreadyExists = worker.AlreadyExists();
        internal static string NotFound = worker.NotFound();
        internal static string Name = worker.Name();
        internal static string ID = worker.ID();
        internal static string Created = worker.Created();
        internal static string Max = worker.Max();
        internal static string Min = worker.Min();
        internal static string Entered = worker.Entered();
        internal static string Code = worker.Code();
        internal static string Password = worker.Password();
        internal static string Invalid = worker.Invalid();
        internal static string File = worker.File();
        internal static string Image = worker.Image();
        internal static string For = worker.For();
        internal static string Extension = worker.Extension();
        internal static string Accepted = worker.Accepted();
        internal static string FirstName = worker.FirstName();
        internal static string LastName = worker.LastName();
        internal static string EMail = worker.EMail();
        internal static string DateOfBirth = worker.DateOfBirth();
        internal static string Stock = worker.Stock();
    }
}
