// <copyright file="ChannelsListResponse.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the response that contains the list of channels
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Responses
{
    using System.Collections.Generic;


    using SlackAPI.Models;
    using SlackAPI.Responses.Abstract;

    /// <summary>
    /// The response that contains the list of channels
    /// </summary>
    public class ChannelsListResponse : BaseResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelsListResponse"/> class.
        /// </summary>
        public ChannelsListResponse()
        {
            this.Channels = new List<Channel>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the channels.
        /// </summary>
        [DeserializeAs(Name = "channels")]
        public List<Channel> Channels { get; set; }

        #endregion
    }
}
