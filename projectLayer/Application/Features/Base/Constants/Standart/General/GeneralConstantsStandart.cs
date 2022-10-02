using eCommerceLayer.Application.Features.Base.Constants.Standart.Base;

namespace eCommerceLayer.Application.Features.Base.Constants.Standart.General
{
    internal static class GeneralConstantsStandart
    {
        internal class GeneralWorker
        {

            internal virtual string MaxCharacter(int number)
            {
                return $"{BaseConstantsStandart.Max} {number} {BaseConstantsStandart.Character} {BaseConstantsStandart.Entered}";
            }
            internal virtual string InvalidFileExtension()
            {
                return $"{BaseConstantsStandart.Invalid} {BaseConstantsStandart.File} {BaseConstantsStandart.Extension}";
            }
        }
        readonly static GeneralWorker worker = new GeneralWorker();
        internal static string Max50Character = worker.MaxCharacter(50);
        internal static string Max30Character = worker.MaxCharacter(30);
        internal static string Max20Character = worker.MaxCharacter(20);
        internal static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        internal static string InvalidFileExtension = worker.InvalidFileExtension();
    }
}