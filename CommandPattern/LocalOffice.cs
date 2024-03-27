namespace CommandPattern
{
    public class LocalOffice
    {
        readonly IAbstractCommand placeHome;
        readonly IAbstractCommand pay;
        public string workType;
        public LocalOffice()
        {
            placeHome = new PlaceHomeCommand();
            pay = new PayCommand();
            workType = "offline";
        }
        public void PlaceHome()
        {
            placeHome.Execute(this);
        }
        public void ReturnWorkers()
        {
            placeHome.Undo(this);
        }
        public void Pay()
        {
            pay.Execute(this);
        }
    }
}
