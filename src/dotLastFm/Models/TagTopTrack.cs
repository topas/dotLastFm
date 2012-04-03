//-----------------------------------------------------------------------
// <copyright file="TagTopTrack.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Last.fm top track
    /// </summary>
    public class TagTopTrack : Track
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
    }
}
