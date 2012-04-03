//-----------------------------------------------------------------------
// <copyright file="AlbumTrack.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Track as part of the album
    /// </summary>
    public class AlbumTrack : Track
    {
        /// <summary>
        /// Gets or sets the rank of the track.
        /// </summary>
        /// <value>
        /// The rank of the track.
        /// </value>
        public int Rank
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
