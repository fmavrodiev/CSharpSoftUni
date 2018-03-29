using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AnonymousDownsite
{
    public class StartUp
    {
        public static void Main()
        {
            int countOfAffectedWebSites = int.Parse(Console.ReadLine());
            byte securityToken = byte.Parse(Console.ReadLine());
            WebSite affectedWebSite = new WebSite();

            decimal siteTotalLoss = 0;
            List<string> websiteInfo = new List<string>();

            for (int i = 0; i < countOfAffectedWebSites; i++)
            {
                websiteInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                affectedWebSite.siteName = websiteInfo[0];
                affectedWebSite.siteVisits = ulong.Parse(websiteInfo[1]);
                affectedWebSite.siteCommercialPricePerVisit = decimal.Parse(websiteInfo[2]);
                siteTotalLoss += affectedWebSite.siteVisits * affectedWebSite.siteCommercialPricePerVisit;
                Console.WriteLine(affectedWebSite.siteName);
            }
            Console.WriteLine($"Total Loss: {siteTotalLoss:0.00000000000000000000}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityToken), countOfAffectedWebSites)}");
        }
    }

    public class WebSite
    {
        public string siteName { get; set; }
        public ulong siteVisits { get; set; }
        public decimal siteCommercialPricePerVisit { get; set; }
    }
}
