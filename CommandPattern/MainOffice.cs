namespace CommandPattern
{
    public class MainOffice
    {
        readonly List<LocalOffice> _officeList;
        public MainOffice(List<LocalOffice> officeList)
        {
            _officeList = officeList;
        }
        public void PlaceHome(LocalOffice lf)
        {
            if (_officeList.Contains(lf))
            {
                lf.PlaceHome();
            }
            else
            {
                Console.WriteLine("no such an office");
            }
        }
        public void UndoPlaceHome(LocalOffice lf)
        {
            if (_officeList.Contains(lf))
            {
                lf.ReturnWorkers();
            }
            else
            {
                Console.WriteLine("no such an office");
            }

        }
        public void PayBonus(LocalOffice lf)
        {
            if (_officeList.Contains(lf))
            {
                lf.Pay();
            }
            else
            {
                Console.WriteLine("no such an office");
            }

        }
    }
}
