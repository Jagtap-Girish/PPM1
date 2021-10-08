using System;
using System.Collections.Generic;
using PPM.UI.CLI;

namespace ProlificsProjectManager
{
    public static class Program
    {
        static void Main(string[] args)
        {


            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            CommonInterface commonInterface = new CommonInterface();
            commonInterface.StartProgram();
           
        }
    }
}
