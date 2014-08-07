// <copyright file="Topic.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the topic of a channel
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Models
{


    /// <summary>
    /// The topic of a channel
    /// </summary>
    public class Topic
    {
        #region Properties

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [DeserializeAs(Name = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        [DeserializeAs(Name = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets the last set.
        /// </summary>
        [DeserializeAs(Name = "last_set")]
        public string LastSet { get; set; }

        #endregion
    }
}
