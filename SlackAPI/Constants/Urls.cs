// <copyright file="Urls.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the URL constants within Slack
// </summary>

namespace SlackAPI.Constants
{
    /// <summary>
    /// Contains the URL constants within Slack
    /// </summary>
    internal class Urls
    {
        /// <summary>
        /// The base URI to the Slack API
        /// </summary>
        internal const string BaseUri = "https://slack.com/api/";

        /// <summary>
        /// The Users-specific URL constants
        /// </summary>
        internal class Users
        {
            /// <summary>
            /// The URL to get the list of users
            /// </summary>
            internal const string List = "users.list?token={0}";
        }

        /// <summary>
        /// The Channels-specific URL constants
        /// </summary>
        internal class Channels
        {
            /// <summary>
            /// The URL to get the list of channels
            /// </summary>
            internal const string List = "channels.list?token={0}&exclude_archived={1}";
        }
    }
}
