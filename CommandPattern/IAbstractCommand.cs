namespace CommandPattern
{
    public interface IAbstractCommand
    {
        public void Execute(LocalOffice lf);
        public void Undo(LocalOffice lf);
    }
}