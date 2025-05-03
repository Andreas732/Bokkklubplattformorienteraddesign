namespace Bokklubbplattform
{
    public abstract class Innehåll
    {
        public abstract void Visa();
    }

    public class Recension : Innehåll
    {
        public override void Visa()
        {
            Console.WriteLine("Detta är en bokrecension från en medlem.");
        }
    }

    public class Diskussion : Innehåll
    {
        public override void Visa()
        {
            Console.WriteLine("Detta är en diskussionstråd om en bok.");
        }
    }

    public class Event : Innehåll
    {
        public override void Visa()
        {
            Console.WriteLine("Detta är ett bokklubbsevent (t.ex. digital träff).");
        }
    }
}
