namespace TerjeOppgave1Rewrite2
{
    public class Walk
    {
        public string Date { get; private set; }
        public double Distance { get; private set; }

        public Walk(string date, double distance)
        {
            Date = date;
            Distance = distance;
        }

        public double CalculateDistance()
        { 
            return Distance;
        }
        
    }
}