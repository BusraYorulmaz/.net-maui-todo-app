using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        // data ve mesaj ver
        public SuccessDataResult(T data, string message):base(data,true,message)
        {

        }

        // data ver
        public SuccessDataResult(T data) :base(data,true)
        {


        }

        //mesaj ver
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        //hiçbir şey verme
        public SuccessDataResult() :base(default,true)
        {

        }

    }
}
