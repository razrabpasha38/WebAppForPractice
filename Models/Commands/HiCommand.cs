using Telegram.Bot;
using Telegram.Bot.Types;

namespace WebAppForPractice.Models.Commands
{
    public class HiCommand : Command
    {
        public override string Name => "Hi";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Bot logic ^_^

            await client.SendTextMessageAsync(chatId, "It is practice!", replyToMessageId: messageId); 
        }
    }
}