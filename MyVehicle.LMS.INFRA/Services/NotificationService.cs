using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Repoisitory;
using MyVehicle.LMS.CORE.Services;
using MyVehicle.LMS.INFRA.Repoisitory;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyVehicle.LMS.INFRA.Services
{
  public   class NotificationService: INotificationService
    {
        private readonly INotificationRepository notificationRepository;
        public NotificationService(NotificationRepository notificationRepository)
        {
            this.notificationRepository = notificationRepository;
        }

        public bool DeleteNotification(Notification notification)
        {
            return notificationRepository.DeleteNotification(notification);
        }

        public List<Notification> GetAllNotification()
        {
            return notificationRepository.GetAllNotification();
        }

        public bool InsertNotification(Notification notification)
        {
            return notificationRepository.InsertNotification(notification);
        }

        public bool UpdateNotification(Notification notification)
        {
            return notificationRepository.UpdateNotification(notification);
        }
    }
}
