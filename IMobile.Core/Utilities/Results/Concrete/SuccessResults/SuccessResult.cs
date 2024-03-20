using IMobile.Core.Utilities.Results.Abstract;
using System;

namespace IMobile.Core.Utilities.Results.Concrete.SuccessResults
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult() : base(true)
        {
        }

        public SuccessResult(string message) : base(true, message)
        {
        }
    }
}

