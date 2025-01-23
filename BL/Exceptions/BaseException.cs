using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Exceptions;

public class BaseException : Exception
{
    public BaseException(string mes) : base(mes) { }
    public BaseException() : base("Something went wrong") { }
    
}
