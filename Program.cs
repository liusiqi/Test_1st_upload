//============The namespaces below are all default, when the project is created, they are there already.==========================
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
//============The namespaces below are all default, when the project is created, they are there already.==========================

namespace Decode_Jason_Object
{
    class Program
    {
        // create a string variable for uri.
        static string uri = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Los%20Alamitos,CA&n=139&cnt=10&mode=json";
 
        static void Main(string[] args)
        {
            //define a WebClient variable.
            WebClient webClinet = new WebClient();

            // use DownloadString method of the WebClient namespace to convert the uri content into a string
            string letsee = webClinet.DownloadString(uri);

            //print the string/content out.
            Console.WriteLine(letsee);

            // hold the console, otherwise the console closes itself immediately.
            Console.Read();
        }
    }
}
