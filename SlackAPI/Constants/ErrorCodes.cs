// <copyright file="ErrorCodes.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the Slack error codes
// </summary>

namespace SlackAPI.Constants
{
    /// <summary>
    /// Slack error codes
    /// </summary>
    public class ErrorCodes
    {
        /// <summary>
        /// Invalid authentication token error
        /// </summary>
        public const string InvalidAuth = "invalid_auth";

        /// <summary>
        /// Authentication token is for a deleted user or team error
        /// </summary>
        public const string AccountInactive = "account_inactive";
    }
}
