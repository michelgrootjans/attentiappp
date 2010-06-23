namespace UniversalRemote
{
    internal interface ICommand
    {
        void Undo();
    }

    internal interface IOnCommand : ICommand
    {
        void Execute();
    }

    internal interface IOffCommand : ICommand
    {
        void Execute();
    }

}