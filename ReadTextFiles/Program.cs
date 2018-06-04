using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace ReadTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //read all files and store in a list
            var folderPath = @"D:\My Projects\ReadTextFiles\Input\DEBUG";

            DirectoryInfo di = new DirectoryInfo(folderPath);

            string[] files = Directory.GetFiles(folderPath, "*.txt");

            foreach (var file in files)
            {
                StringBuilder sb = new StringBuilder();

                using (StreamReader sr = new StreamReader(file))
                {
                    sb.Append(sr.ReadToEnd());
                }

                var inputString = sb.ToString();

                if(inputString.Contains("Search your tex here"))
                {
                    //Get the file name of the matched tex 
                    Console.WriteLine(file.ToString());
                }

                //Regex mypattern = new Regex("Request: (.*?) </SOAP-ENV:Envelope>");
                //string outputString = mypattern.Match(inputString).Groups[1].Value + "</SOAP-ENV:Envelope>";

                //XmlDocument xmlDoc = new XmlDocument();
                //xmlDoc.LoadXml(outputString);

                //XmlNamespaceManager nmspc = new XmlNamespaceManager(xmlDoc.NameTable);
                //nmspc.AddNamespace("SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/");
                //nmspc.AddNamespace("ns0", "http://www.telstra.com/schemas/soap/header/v1/");
                //nmspc.AddNamespace("dns", "http://www.nbnco.com.au/cim/manageWorkOrder/v5");

                //StringBuilder fileName = new StringBuilder();
                //fileName.Append(xmlDoc.SelectSingleNode("//SOAP-ENV:Envelope//SOAP-ENV:Header//ns0:Header//ns0:transactionName", nmspc).InnerText.ToString());
                //fileName.Append("_");

                //if(xmlDoc.SelectNodes("//SOAP-ENV:Envelope//SOAP-ENV:Body//dns:ManageWorkOrderRequest",nmspc) != null
                //    && xmlDoc.SelectNodes("//SOAP-ENV:Envelope//SOAP-ENV:Body//dns:ManageWorkOrderRequest", nmspc).Count !=0)
                //fileName.Append(xmlDoc.SelectSingleNode("//SOAP-ENV:Envelope//SOAP-ENV:Body//dns:ManageWorkOrderRequest//FieldWork//ID", nmspc).InnerText.ToString());


                //using (StreamWriter outfile = new StreamWriter(@"D:\My Projects\ReadTextFiles\Output" + @"\" +fileName.ToString()+ ".txt"))
                //{
                //    outfile.Write(outputString.ToString());
                //}
            }

        }
    }
}
