using coreLayer.Utilities.Results;

namespace coreLayer.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
