//-----------------------------------------------------------------------
// <copyright file="TrackAlbum.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;
    using RestSharp.Deserializers;

    /// <summary>
    /// Last.fm's album
    /// </summary>
    public class TrackAlbum : Album
    {
        /// <summary>
        /// Gets or sets the artist name.
        /// </summary>
        /// <value>
        /// The artist name.
        /// </value>
        [DeserializeAs(Name = "Artist")]
        public string ArtistName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        /// <value>
        /// The title of the album.
        /// </value>
        [DeserializeAs(Name = "title")]
        public new string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the images collection.
        /// </summary>
        /// <value>
        /// The images collection.
        /// </value>
        public List<Image> Images
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the position of the track.
        /// </summary>
        /// <value>
        /// The position of the track.
        /// </value>
        [DeserializeAs(Name = "position", Attribute = true)]
        public int Position
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0} - {1}", ArtistName, Name);
        }
    }
}
