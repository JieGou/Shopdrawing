﻿using System;
using System.Runtime.Serialization;

namespace Shopdrawing.Core.Configuration
{
    /// <summary>
    /// Exception thrown when some code is trying to write to a read-only setting.
    /// </summary>
    [Serializable]
    public class SettingNotSupportedException : Exception
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SettingNotSupportedException() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        public SettingNotSupportedException(string message) : base(message) { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public SettingNotSupportedException(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="info">Serialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected SettingNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}