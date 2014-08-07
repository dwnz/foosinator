// <copyright file="IResponse.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the interface for all responses
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Responses.Abstract
{

    /// <summary>
    /// The interface for all responses
    /// </summary>
    public interface IResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether success or failure occurred
        /// </summary>
        [DeserializeAs(Name = "ok")]
        bool Ok { get; set; }

        /// <summary>
        /// Gets or sets the error from the message. Will be null if there is no error.
        /// </summary>
        [DeserializeAs(Name = "error")]
        string Error { get; set; }

        #endregion
    }
}
