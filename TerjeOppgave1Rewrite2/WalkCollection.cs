using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerjeOppgave1Rewrite2
{
    internal class WalkCollection
    {
        private List<Walk> _walks;

        public WalkCollection()
        {
            _walks = new List<Walk>();
        }

        public static WalkCollection ReadWalksFromFile(string fileName)
        {
            var viewWalks = new WalkCollection();

                foreach (string s in File.ReadLines(fileName))
                {
                    string[] splitString = s.Split(',');
                    var kmWalked = Double.Parse(splitString[1], System.Globalization.CultureInfo.InvariantCulture);
                    var Walk = new Walk(splitString[0], kmWalked);
                    viewWalks._walks.Add(Walk);
                }
            return viewWalks;
        }
        public string returnWalkString()
        {
            var walkString = "";
                foreach (var walkLine in _walks)
                {
                    walkString = walkString + walkLine.Date + " " + walkLine.Distance + "\n";
                }
            return walkString;
        }
        public double distanceWalked()
        {
            var totalDistance = 0.0;
                foreach (var Walk in _walks)
                {
                    totalDistance = totalDistance + Walk.CalculateDistance();
                }
            return totalDistance;
        }
        public string GetDescription()
        {
            return $"Nice work! You've walked {distanceWalked()} km" + "\n" + returnWalkString() + "\n";
        }
    }
}
