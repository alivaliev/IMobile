using IMobile.Core.Utilities.Results.Abstract;
using System;

namespace IMobile.Core.Utilities.Results.Concrete.ErrorResults
{
    public class ErrorResult : Result, IResult
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}

