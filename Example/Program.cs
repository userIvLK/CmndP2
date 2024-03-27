using CommandPattern;

class Program
{
    static void Main(string[] args)
    {
        //Create local offices
        LocalOffice lf1 = new ();
        LocalOffice lf2 = new ();
        LocalOffice lf3 = new ();
        LocalOffice lf4 = new ();

        //Connect local offices with main ones
        MainOffice m1 = new (new List<LocalOffice> { lf1, lf2 });
        MainOffice m2 = new (new List<LocalOffice> { lf3, lf4 });
        //PlaceHomeCommand
        Console.WriteLine(lf1.workType);
        m1.PlaceHome(lf1);
        Console.WriteLine(lf1.workType);
        m2.PlaceHome(lf2);
        m1.UndoPlaceHome (lf1);
        Console.WriteLine(lf1.workType);

        Console.WriteLine();

        //PayCommand
        m1.PayBonus(lf2);
        m1.PayBonus(lf3); 
    }
}