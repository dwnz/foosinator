// <copyright file="BaseResponse.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the abstract base response object that all responses inherit from
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Responses.Abstract
{
    /// <summary>
    /// The abstract base response object that all responses inherit from
    /// </summary>
    public abstract class BaseResponse : IResponse
    {
        #region Properties

        /// <inheritdoc />
        [DeserializeAs(Name = "ok")]
        public bool Ok { get; set; }

        /// <inheritdoc />
        [DeserializeAs(Name = "error")]
        public string Error { get; set; }

        #endregion
    }
}
