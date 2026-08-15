using Telegram.Bot;
using Telegram.Bot.Types;

namespace SkillFactory.AllHomeWorks.Logic
{
    internal class SumNumbers
    {
        internal static async Task SumNumb(Message message,ITelegramBotClient _telegramClient, CancellationToken cancellationToken)
        {
            var numbers = message.Text.Split(' ').Select(n => int.TryParse(n, out int result) ? result : 0);
            var sum = numbers.Sum();
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Сумма чисел: {sum}", cancellationToken: cancellationToken);
        }
    }
}
