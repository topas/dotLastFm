//-----------------------------------------------------------------------
// <copyright file="AlbumWithDetails.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System;
    using System.Collections.Generic;

    using RestSharp.Deserializers;

    /// <summary>
    /// Album with full details
    /// </summary>
    public class AlbumWithDetails : Album
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
        /// Gets or sets the count of listeners.
        /// </summary>
        /// <value>
        /// The count of listeners.
        /// </value>
        public int Listeners
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the play count.
        /// </summary>
        /// <value>
        /// The play count.
        /// </value>
        public int PlayCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the release date.
        /// </summary>
        /// <value>
        /// The release date.
        /// </value>
        public DateTime ReleaseDate
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
        /// Gets or sets the tracks.
        /// </summary>
        /// <value>
        /// The tracks.
        /// </value>
        public List<AlbumTrack> Tracks
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tags of the album.
        /// </summary>
        /// <value>
        /// The tags of the album.
        /// </value>
        [DeserializeAs(Name = "toptags")]
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the wiki texts.
        /// </summary>
        /// <value>
        /// The wiki texts.
        /// </value>
        public Wiki Wiki
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
