


namespace overloadingList
{
    public class List
    {
        
        public int NumberItems { get; set; }
        public float Type { get; set; }

        public List()
        {
            
            NumberItems = 0;
            Type = 0;
        }

        public List(int NumberItems, float TripTIme)
        {
           
            this.NumberItems = NumberItems;
            this.Type = TripTIme;
        }

       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
