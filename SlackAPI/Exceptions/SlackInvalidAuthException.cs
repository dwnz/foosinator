// <copyright file="SlackInvalidAuthException.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the exception that is thrown when the error message is an invalid authentication token
// </summary>

namespace SlackAPI.Exceptions
{
    using System;

    /// <summary>
    /// Thrown when the error message is an invalid authentication token
    /// </summary>
    public class SlackInvalidAuthException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInvalidAuthException" /> class
        /// </summary>
        public SlackInvalidAuthException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInvalidAuthException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        public SlackInvalidAuthException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackInvalidAuthException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="inner">The inner exception</param>
        public SlackInvalidAuthException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #endregion
    }
}
