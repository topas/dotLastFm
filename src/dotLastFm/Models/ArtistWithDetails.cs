//-----------------------------------------------------------------------
// <copyright file="ArtistWithDetails.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;
    using RestSharp.Deserializers;

    /// <summary>
    /// Last.fm artist with full details
    /// </summary>
    public class ArtistWithDetails : Artist
    {
        /// <summary>
        /// Gets or sets the mb ID.
        /// </summary>
        /// <value>
        /// The valeu of mb ID.
        /// </value>
        public string MbId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the artist's stats.
        /// </summary>
        /// <value>
        /// The stats summary.
        /// </value>
        public Stats Stats
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this artists is streamable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if streamable; otherwise, <c>false</c>.
        /// </value>
        public bool Streamable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the similar artists collection.
        /// </summary>
        /// <value>
        /// The similar artists collection.
        /// </value>
        [DeserializeAs(Name = "similar")]
        public List<ArtistSimilarArtist> SimilarArtists
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
        /// Gets or sets the tags of the artist.
        /// </summary>
        /// <value>
        /// The tags of the artist.
        /// </value>
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
        public Wiki Bio
        {
            get;
            set;
        }
    }
}
