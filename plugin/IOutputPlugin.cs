namespace plugin
{
    public interface IOutputPlugin
    {
        void Execute(string json, string[] options);
    }
}