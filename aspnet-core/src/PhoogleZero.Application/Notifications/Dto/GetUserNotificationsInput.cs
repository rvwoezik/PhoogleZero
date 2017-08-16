using Abp.Notifications;
using PhoogleZero.Dto;

namespace PhoogleZero.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}