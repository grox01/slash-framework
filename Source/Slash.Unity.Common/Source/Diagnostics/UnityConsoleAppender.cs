﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityConsoleAppender.cs" company="Slash Games">
//   Copyright (c) Slash Games. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Slash.Unity.Common.Diagnostics
{
    using log4net.Appender;
    using log4net.Core;

    using UnityEngine;

    public class UnityConsoleAppender : AppenderSkeleton
    {
        #region Methods

        protected override void Append(LoggingEvent loggingEvent)
        {
            var message = this.RenderLoggingEvent(loggingEvent);
            if (loggingEvent.Level == Level.Error)
            {
                Debug.LogError(message);
            }
            else if (loggingEvent.Level == Level.Warn)
            {
                Debug.LogWarning(message);
            }
            else
            {
                Debug.Log(message);
            }
        }

        #endregion
    }
}