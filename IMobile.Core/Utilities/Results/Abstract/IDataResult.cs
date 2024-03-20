using System;

namespace IMobile.Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; }
    }
}

