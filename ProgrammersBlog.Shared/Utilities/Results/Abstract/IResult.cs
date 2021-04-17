using System;
using ProgrammersBlog.Shared.Utilities.Results.Abstract.ComplexTypes;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus{ get; }//ResultStatus.succes or ResultStatus.error
        public string Message { get; }
        public Exception Exception { get;}
    }
}
