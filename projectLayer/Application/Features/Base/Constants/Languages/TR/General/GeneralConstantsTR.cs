using eCommerceLayer.Application.Features.Base.Constants.Standart.General;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;

namespace eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General
{
    public static class GeneralConstantsTR
    {
        private class Worker : GeneralConstantsStandart.GeneralWorker
        {
            internal override string MaxCharacter(int number)
            {
                return $"{BaseConstantsTR.Max} {number} {BaseConstantsTR.Character} {BaseConstantsTR.Entered}";
            }
            internal override string InvalidFileExtension()
            {
                return $"{BaseConstantsTR.Invalid} {BaseConstantsTR.File} {BaseConstantsTR.Extension}si";
            }
        }
        readonly static Worker worker = new Worker();
        public static string Max50Character = worker.MaxCharacter(50);
        public static string Max30Character = worker.MaxCharacter(30);
        public static string Max20Character = worker.MaxCharacter(20);
        public static string[] ValidImageFileTypes = GeneralConstantsStandart.ValidImageFileTypes;
        public static string InvalidFileExtension = worker.InvalidFileExtension();
    }
}