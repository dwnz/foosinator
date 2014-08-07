// <copyright file="SlackUnexpectedException.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the exception that is thrown when there is an unexpected exception
// </summary>

namespace SlackAPI.Exceptions
{
    using System;

    /// <summary>
    /// Thrown when there is an unexpected exception
    /// </summary>
    public class SlackUnexpectedException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackUnexpectedException" /> class
        /// </summary>
        public SlackUnexpectedException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackUnexpectedException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        public SlackUnexpectedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackUnexpectedException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="inner">The inner exception</param>
        public SlackUnexpectedException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #endregion
    }
}
