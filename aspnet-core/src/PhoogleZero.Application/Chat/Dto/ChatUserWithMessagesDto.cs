using System.Collections.Generic;

namespace PhoogleZero.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}