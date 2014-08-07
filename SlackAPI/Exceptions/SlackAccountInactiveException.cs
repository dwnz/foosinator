// <copyright file="SlackAccountInactiveException.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the exception that is thrown when the authentication token is for a deleted user or team
// </summary>

namespace SlackAPI.Exceptions
{
    using System;

    /// <summary>
    /// Thrown when the authentication token is for a deleted user or team
    /// </summary>
    public class SlackAccountInactiveException : Exception
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAccountInactiveException" /> class
        /// </summary>
        public SlackAccountInactiveException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAccountInactiveException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        public SlackAccountInactiveException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAccountInactiveException" /> class
        /// </summary>
        /// <param name="message">The exception message</param>
        /// <param name="inner">The inner exception</param>
        public SlackAccountInactiveException(string message, Exception inner)
            : base(message, inner)
        {
        }

        #endregion
    }
}
