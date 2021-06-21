using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrisNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var http = new Uri("http://www.mywebsite.com");

            var httpScheme = http.Scheme;
            Console.WriteLine(httpScheme); // Will return a protocol of http variable - http.

            var httpHost = http.Host;
            Console.WriteLine(httpHost); // Will return a host of our variable(site) - www.mywebsite.com.

            var httpPort = http.Port;
            Console.WriteLine(httpPort); // Will return a port of our site, because we have http protocol it will return 80, but if we had https protocol, then it would return 443.

            var httpAuthority = http.Authority;
            Console.WriteLine(httpAuthority); // Will return the host and the port together, if port if specified!
            // Let's specify the port!
            var http1 = new Uri("http://www.mywebsite.com:8080");
            var httpAuthority1 = http1.Authority;
            Console.WriteLine(httpAuthority1);

            var httpPathU = new Uri("http://www.mywebsite.com/path/to/resource/?key=value&key2=value#fragment"); // Let's create Uri with path and Query

            var httpPath = httpPathU.AbsolutePath;
            Console.WriteLine(httpPath); // Will return "/path/to/resource/"

            var httpQuery = httpPathU.Query;
            Console.WriteLine(httpQuery); // Will return query, "?key=value&key2=value"

            var httpPathQuery = httpPathU.PathAndQuery;
            Console.WriteLine(httpPathQuery);

            var httpFragment = httpPathU.Fragment;
            Console.WriteLine(httpFragment); // #fragment

            var httpAbsolutuUri = httpPathU.AbsoluteUri;
            Console.WriteLine(httpAbsolutuUri); // http://www.mywebsite.com/path/to/resource/?key=value&key2=value#fragment

            Console.WriteLine("UNC TIME!");

            var unc = new Uri(@"\\servername\path\to\share\file.txt");
            // file://servername/path/to/share/file.txt

            var uncScheme = unc.Scheme; // file
            var uncHost = unc.Host; // servername
            var uncPort = unc.Port; // -1, there is no port in unc
            var uncAuthority = unc.Authority; // servername
            var uncPath = unc.AbsolutePath; // /path/to/share/file.txt
            var uncQuery = unc.Query; // string.Empty, there is no Query in file system, such as unc
            var uncPathQuery = unc.PathAndQuery; // /path/to/share/file.txt
            var uncFragment = unc.Fragment; // #fragment
            var uncAbsoluteUri = unc.AbsoluteUri; // file://servername/path/to/share/file.txt

            var escapedUri = Uri.EscapeUriString("http://www.mywebsite.com");
            var escapedStuff = Uri.EscapeDataString("string to escape");
            Console.WriteLine(escapedStuff);

        }
    }
}
