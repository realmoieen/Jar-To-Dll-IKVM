using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ascertia.Test.API.Exec
{
    public class CallAPIFromExe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calling Hello Service from EXE");
            new API().sayHelloFromNet("called from exe");
        }
    }
}
