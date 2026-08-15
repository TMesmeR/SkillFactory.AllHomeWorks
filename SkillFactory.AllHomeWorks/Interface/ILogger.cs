namespace SkillFactory.AllHomeWorks.Interface
{
    internal interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
