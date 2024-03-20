using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete.ErrorResults;
using IMobile.Core.Utilities.Results.Concrete.SuccessResults;
using System;

namespace IMobile.Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult CheckRules(params IResult[] logic)
        {
            foreach (var method in logic)
            {
                if (!method.Success)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}

