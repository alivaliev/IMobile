using IMobile.Core.Utilities.Results.Abstract;
using System;

namespace IMobile.Core.Utilities.Results.Concrete.SuccessResults
{
    public class SuccessDataResult<T> : DataResult<T>, IDataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        public SuccessDataResult(T data) : base(data, true)
        {
        }

    }
}

