namespace CommandPattern
{
    internal class PayCommand : IAbstractCommand
    {
        public void Execute(LocalOffice lf)
        {
            Console.WriteLine("bonus paid");
        }

        public void Undo(LocalOffice lf)
        {
            Console.WriteLine("nothig happens");
        }
    }
}
