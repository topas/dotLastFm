//-----------------------------------------------------------------------
// <copyright file="TrackSimilar.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Last.fm's similar track model
    /// </summary>
    public class TrackSimilar : Track
    {
        /// <summary>
        /// Gets or sets the match ratio.
        /// </summary>
        /// <value>
        /// The match ratio.
        /// </value>
        public float Match
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
