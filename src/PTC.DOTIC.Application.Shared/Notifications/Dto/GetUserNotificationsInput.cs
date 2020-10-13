using Abp.Notifications;
using PTC.DOTIC.Dto;

namespace PTC.DOTIC.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}