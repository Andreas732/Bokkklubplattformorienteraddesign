using System;

namespace Bokklubbplattform
{
    public class InnehållFabrik
    {
        public static Innehåll SkapaInnehåll(string typ)
        {
            return typ switch
            {
                "Recension" => new Recension(),
                "Diskussion" => new Diskussion(),
                "Event" => new Event(),
                _ => throw new ArgumentException("Ogiltig innehållstyp")
            };
        }
    }
}
