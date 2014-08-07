// <copyright file="Channel.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines a channel
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Models
{

    /// <summary>
    /// A channel
    /// </summary>
    public class Channel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the created timestamp.
        /// </summary>
        [DeserializeAs(Name = "created")]
        public string Created { get; set; }

        /// <summary>
        /// Gets or sets the creator.
        /// </summary>
        [DeserializeAs(Name = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the channel is archived.
        /// </summary>
        [DeserializeAs(Name = "is_archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is member of the channel.
        /// </summary>
        [DeserializeAs(Name = "is_member")]
        public bool IsMember { get; set; }

        /// <summary>
        /// Gets or sets the number of members.
        /// </summary>
        [DeserializeAs(Name = "num_members")]
        public int NumberOfMembers { get; set; }

        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        [DeserializeAs(Name = "topic")]
        public Topic Topic { get; set; }

        /// <summary>
        /// Gets or sets the purpose.
        /// </summary>
        [DeserializeAs(Name = "purpose")]
        public Purpose Purpose { get; set; }

        #endregion
    }
}
