using projectLayer.Application.Features.Base.Constants.Standart.Base;

namespace projectLayer.Application.Features.Base.Constants.Standart.General
{
    internal static class GeneralConstantsStandart
    {
        internal class GeneralWorker
        {
            internal virtual string Character()
            {
                return $"Character";
            }
            internal virtual string Max50Character()
            {
                return $"{BaseConstantsStandart.Max} 50 {GeneralConstantsStandart.Character} {BaseConstantsStandart.Entered}";
            }
            internal virtual string Max30Character()
            {
                return $"{BaseConstantsStandart.Max} 30 {GeneralConstantsStandart.Character} {BaseConstantsStandart.Entered}";
            }
            internal virtual string Max20Character()
            {
                return $"{BaseConstantsStandart.Max} 20 {GeneralConstantsStandart.Character} {BaseConstantsStandart.Entered}";
            }
            internal virtual string InvalidFileExtension()
            {
                return $"{BaseConstantsStandart.Invalid} {BaseConstantsStandart.File} Extension";
            }
        }
        readonly static GeneralWorker worker = new GeneralWorker();
        internal static string Character = worker.Character();
        internal static string Max50Character = worker.Max50Character();
        internal static string Max30Character = worker.Max30Character();
        internal static string Max20Character = worker.Max20Character();
        internal static string[] ValidImageFileTypes = { ".JPG", ".JPEG", ".PNG", ".TIF", ".TIFF", ".GIF", ".BMP", ".ICO" };
        internal static string InvalidFileExtension = worker.InvalidFileExtension();
    }
}
