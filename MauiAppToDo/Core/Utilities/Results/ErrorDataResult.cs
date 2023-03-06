using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        // data ve mesaj ver
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        // data ver
        public ErrorDataResult(T data) : base(data, false)
        {


        }

        //mesaj ver
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        //hiçbir şey verme
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
