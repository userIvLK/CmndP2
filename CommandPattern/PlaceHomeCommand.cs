namespace CommandPattern
{
    internal class PlaceHomeCommand : IAbstractCommand
    {
        public void Execute(LocalOffice lf)
        {
            lf.workType = "online";
        }

        public void Undo(LocalOffice lf)
        {
            lf.workType = "offline";
        }
    }
}
