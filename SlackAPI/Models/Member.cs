// <copyright file="Member.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines a user in the team
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Models
{

    /// <summary>
    /// A user in the team
    /// </summary>
    public class Member
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user's identifier
        /// </summary>
        [DeserializeAs(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the user's name
        /// </summary>
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is deleted or not
        /// </summary>
        [DeserializeAs(Name = "deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the user's color
        /// </summary>
        [DeserializeAs(Name = "color")]
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the user's profile
        /// </summary>
        [DeserializeAs(Name = "profile")]
        public Profile Profile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is an admin or not
        /// </summary>
        [DeserializeAs(Name = "is_admin")]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is an owner or not
        /// </summary>
        [DeserializeAs(Name = "is_owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has files or notY
        /// </summary>
        [DeserializeAs(Name = "has_files")]
        public bool HasFiles { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the name of the member
        /// </summary>
        /// <returns>The name of the member</returns>
        public override string ToString()
        {
            return string.Format("{0} - {1} {2}", this.Name, this.Profile.FirstName, this.Profile.LastName);
        }

        #endregion
    }
}
