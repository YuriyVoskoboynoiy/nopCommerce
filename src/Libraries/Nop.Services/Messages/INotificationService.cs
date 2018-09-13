﻿using System;
using Microsoft.AspNetCore.Http;

namespace Nop.Services.Messages
{
    /// <summary>
    /// Notification service interface
    /// </summary>
    public partial interface INotificationService
    {
        /// <summary>
        /// Display success notification
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// <param name="context">HttpContext</param>
        void SuccessNotification(string message, bool persistForTheNextRequest = true, HttpContext context = null);

        /// <summary>
        /// Display warning notification
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// <param name="context">HttpContext</param>
        void WarningNotification(string message, bool persistForTheNextRequest = true, HttpContext context = null);

        /// <summary>
        /// Display error notification
        /// </summary>
        /// <param name="message">Message</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// <param name="context">HttpContext</param>
        void ErrorNotification(string message, bool persistForTheNextRequest = true, HttpContext context = null);

        /// <summary>
        /// Display error notification
        /// </summary>
        /// <param name="exception">Exception</param>
        /// <param name="persistForTheNextRequest">A value indicating whether a message should be persisted for the next request</param>
        /// <param name="logException">A value indicating whether exception should be logged</param>
        /// <param name="context">HttpContext</param>
        void ErrorNotification(Exception exception, bool persistForTheNextRequest = true, bool logException = true, HttpContext context = null);
    }
}
