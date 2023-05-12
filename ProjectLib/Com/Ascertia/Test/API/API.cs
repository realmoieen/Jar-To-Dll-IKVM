using com.ascertia.test.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Ascertia.Test.API
{
    public class API
    {
       public void sayHelloFromNet(String name)
        {
            com.ascertia.test.service.HelloServiceLoader.loadMyHelloService().sayHello(name);
        }

        public static void Main(String[] args)
        {
            new API().sayHelloFromNet("called from projectLib");
        }
    }
}
