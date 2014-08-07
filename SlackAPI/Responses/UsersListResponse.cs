// <copyright file="UsersListResponse.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines the response that contains the list of users
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Responses
{
    using System.Collections.Generic;
    using Models;
    using Abstract;

    /// <summary>
    /// The response that contains the list of users
    /// </summary>
    public class UsersListResponse : BaseResponse
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListResponse" /> class
        /// </summary>
        public UsersListResponse()
        {
            this.Members = new List<Member>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets list of users
        /// </summary>
        [DeserializeAs(Name = "members")]
        public List<Member> Members { get; set; }

        #endregion
    }
}
