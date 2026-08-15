using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace SkillFactory.AllHomeWorks.Visual
{
    internal class MainMenu
    {

        internal static async Task SendMainMenu(long chatId,ITelegramBotClient _telegramClient, CancellationToken cancellationToken)
        {
            var button = new ReplyKeyboardMarkup(new[]
            {
                new KeyboardButton("Подсчет символов"),
                new KeyboardButton("Сумма чисел")
            })
            {

                ResizeKeyboard = true,
                OneTimeKeyboard = false
            };


            await _telegramClient.SendTextMessageAsync(chatId, "Сначала выберите действие", replyMarkup: button, cancellationToken: cancellationToken);
        }
    }
}
