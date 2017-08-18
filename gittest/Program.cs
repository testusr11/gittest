using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace gittest
{//Task 1
    public class Program
    {
        public static void  
            Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                
                //vxcvxcv
                //know anything at all about something in an outer circle. In particular, the name of 
                //vxc
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                //22
                .UseApplicationInsights()
                .Build();
///
            zxvxvxcv
            host.Run();
        }
    }
}
