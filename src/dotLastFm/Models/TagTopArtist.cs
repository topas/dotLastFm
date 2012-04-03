//-----------------------------------------------------------------------
// <copyright file="TagTopArtist.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Top Tag artist
    /// </summary>
    public class TagTopArtist : Artist 
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TagTopArtist"/> is streamable.
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
        /// Gets or sets the rank of artist.
        /// </summary>
        /// <value>
        /// The rank of artist.
        /// </value>
        public int Rank
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
