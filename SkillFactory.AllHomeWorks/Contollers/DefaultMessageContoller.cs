using Telegram.Bot;
using Telegram.Bot.Types;

namespace SkillFactory.AllHomeWorks.Contollers
{
    internal class DefaultMessageContoller
    {
        private readonly ITelegramBotClient _telegramClient;

        public DefaultMessageContoller(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено сообщение не поддерживаемого формата", cancellationToken: ct);
        }

    }
}
