using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess, string message):this(isSuccess) //iki parametre veren biri alttaki tek parametreli constructorı da çalıştırması için
        {
            Message = message; // Getterlar read-onlydir, constructor ile set edilebilir !!!! Bunu zaten cons dışında bir yerde set etmeyeceğimizi biliyoruz .
        }

        public Result(bool isSuccess)
        {
            Success = isSuccess;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
