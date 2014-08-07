// <copyright file="Profile.cs" company="afmco">
//     Copyright (c) afmco. All rights reserved.
// </copyright>
// <author>
//     Tony Morris
// </author>
// <summary>
//     Defines a user's profile
// </summary>

using RestSharp.Deserializers;

namespace SlackAPI.Models
{
    
    /// <summary>
    /// A user's profile
    /// </summary>
    public class Profile
    {
        #region Properties

        /// <summary>
        /// Gets or sets the user's first name
        /// </summary>
        [DeserializeAs(Name = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the user's last name
        /// </summary>
        [DeserializeAs(Name ="last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the user's real name
        /// </summary>
        [DeserializeAs(Name = "real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// Gets or sets the user's email address
        /// </summary>
        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the user's Skype username
        /// </summary>
        [DeserializeAs(Name = "skype")]
        public string Skype { get; set; }

        /// <summary>
        /// Gets or sets the user's phone number
        /// </summary>
        [DeserializeAs(Name = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the user's 24x24 image
        /// </summary>
        [DeserializeAs(Name = "image_24")]
        public string Image24 { get; set; }

        /// <summary>
        /// Gets or sets the user's 32x32 image
        /// </summary>
        [DeserializeAs(Name = "image_32")]
        public string Image32 { get; set; }

        /// <summary>
        /// Gets or sets the user's 48x48 image
        /// </summary>
        [DeserializeAs(Name = "image_48")]
        public string Image48 { get; set; }

        /// <summary>
        /// Gets or sets the user's 72x72 image
        /// </summary>
        [DeserializeAs(Name = "image_72")]
        public string Image72 { get; set; }

        /// <summary>
        /// Gets or sets the user's 192x192 image
        /// </summary>
        [DeserializeAs(Name = "image_192")]
        public string Image192 { get; set; }

        #endregion
    }
}
