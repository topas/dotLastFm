//-----------------------------------------------------------------------
// <copyright file="TrackWithDetails.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;

    using RestSharp.Deserializers;

    /// <summary>
    /// Last.fm's track with full details
    /// </summary>
    public class TrackWithDetails : Track
    {
        /// <summary>
        /// Gets or sets the artist of the track.
        /// </summary>
        /// <value>
        /// The artist of the track.
        /// </value>
        public Artist Artist
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the album.
        /// </summary>
        /// <value>
        /// The album.
        /// </value>
        public TrackAlbum Album
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the playcount.
        /// </summary>
        /// <value>
        /// The playcount.
        /// </value>
        public int Playcount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the listeners.
        /// </summary>
        /// <value>
        /// The listeners.
        /// </value>
        public int Listeners
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the tags of the track.
        /// </summary>
        /// <value>
        /// The tags of the track.
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
            return string.Format("{0} - {1}", Artist.Name, Name);
        }
    }
}
