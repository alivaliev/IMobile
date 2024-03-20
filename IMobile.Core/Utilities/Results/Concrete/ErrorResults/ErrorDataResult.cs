using IMobile.Core.Utilities.Results.Abstract;
using System;

namespace IMobile.Core.Utilities.Results.Concrete.ErrorResults
{
    public class ErrorDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}

