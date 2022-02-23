﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concepts
{
    class Package
    {
        public string Company { get; set; }
        public double Weight { get; set; }
        public long TrackingNumber { get; set; }

        public static void ToDictionaryEx1()
        {
            List<Package> packages =
                new List<Package>
                    { new Package { Company = "Coho Vineyard", Weight = 25.2, TrackingNumber = 89453312L },
              new Package { Company = "Lucerne Publishing", Weight = 18.7, TrackingNumber = 89112755L },
              new Package { Company = "Wingtip Toys", Weight = 6.0, TrackingNumber = 299456122L },
              new Package { Company = "Adventure Works", Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Dictionary of Package objects,
            // using TrackingNumber as the key.
            Dictionary<long, Package> dictionary =
                packages.ToDictionary(p => p.TrackingNumber);

            foreach (KeyValuePair<long, Package> kvp in dictionary)
            {
                Console.WriteLine(
                    "Key {0}: {1}, {2} pounds",
                    kvp.Key,
                    kvp.Value.Company,
                    kvp.Value.Weight);
            }
        }
        public static void ToLookupEx1()
        {
            // Create a list of Packages.
            List<Package> packages =
                new List<Package>
                    { new Package { Company = "Coho Vineyard",
                  Weight = 25.2, TrackingNumber = 89453312L },
              new Package { Company = "Lucerne Publishing",
                  Weight = 18.7, TrackingNumber = 89112755L },
              new Package { Company = "Wingtip Toys",
                  Weight = 6.0, TrackingNumber = 299456122L },
              new Package { Company = "Contoso Pharmaceuticals",
                  Weight = 9.3, TrackingNumber = 670053128L },
              new Package { Company = "Wide World Importers",
                  Weight = 33.8, TrackingNumber = 4665518773L } };

            // Create a Lookup to organize the packages.
            // Use the first character of Company as the key value.
            // Select Company appended to TrackingNumber
            // as the element values of the Lookup.
            ILookup<char, string> lookup =
                packages
                .ToLookup(p => p.Company[0],
                          p => p.Company + " " + p.TrackingNumber);

            // Iterate through each IGrouping in the Lookup.
            foreach (IGrouping<char, string> packageGroup in lookup)
            {
                // Print the key value of the IGrouping.
                Console.WriteLine(packageGroup.Key);
                // Iterate through each value in the
                // IGrouping and print its value.
                foreach (string str in packageGroup)
                    Console.WriteLine("    {0}", str);
            }
        }
    }

   





}
