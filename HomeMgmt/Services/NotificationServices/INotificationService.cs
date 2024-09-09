﻿using HomeMgmt.DTOs.NotificationDTOs;
using HomeMgmt.Models.NotificationModels;

namespace Backend.Services.NotificationServices
{
    public interface INotificationService
    {
        Task<bool> ClearNotification(ClearNotificationDTO clearDTO);
        Task<Notification> GenerateNotification(GenerateNotificationDTO generateDTO);
        Task<NotificationsAndCountReturnDTO> ReadNotifications(ReadNotificationsDTO readDTO);
    }
}
