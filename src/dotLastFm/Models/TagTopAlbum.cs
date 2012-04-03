//-----------------------------------------------------------------------
// <copyright file="TagTopAlbum.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Last.fm tag's top album
    /// </summary>
    public class TagTopAlbum : Album
    {
        /// <summary>
        /// Gets or sets the tag count.
        /// </summary>
        /// <value>
        /// The tag count.
        /// </value>
        public int TagCount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the artist of the album.
        /// </summary>
        /// <value>
        /// The artist of the album.
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
