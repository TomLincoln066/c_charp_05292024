/*
Write a program that parses an URL given in the following format:
[protocol]://[server]/[resource]
The parsing extracts its parts: protocol, server and resource.
The [server] part is mandatory.
The [protocol] and [resource] parts are optional
*/

// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         // Read the URL from the console
//         Console.WriteLine("Enter the URL:");
//         string url = Console.ReadLine();

//         // Parse the URL
//         ParseUrl(url);
//     }

//     static void ParseUrl(string url)
//     {
//         string pattern = @"^(?:(?<protocol>\w+)://)?(?<server>[^/]+)(?:/(?<resource>.*))?$";
//         Regex regex = new Regex(pattern);
//         Match match = regex.Match(url);

//         if (match.Success)
//         {
//             string protocol = match.Groups["protocol"].Value;
//             string server = match.Groups["server"].Value;
//             string resource = match.Groups["resource"].Value;

//             Console.WriteLine("[protocol] = \"" + (string.IsNullOrEmpty(protocol) ? "" : protocol) + "\"");
//             Console.WriteLine("[server] = \"" + server + "\"");
//             Console.WriteLine("[resource] = \"" + (string.IsNullOrEmpty(resource) ? "" : resource) + "\"");
//         }
//         else
//         {
//             Console.WriteLine("The URL is not in the correct format.");
//         }
//     }
// }
