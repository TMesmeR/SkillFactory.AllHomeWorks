namespace SkillFactory.AllHomeWorks.Moduls
{
    internal class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public async Task ExecuteCommandAsync()
        {
            await _command.ExecuteAsync();
        }
    }
}
