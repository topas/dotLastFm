//-----------------------------------------------------------------------
// <copyright file="TagWithDetails.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Last.fm tag with full details
    /// </summary>
    public class TagWithDetails : Tag
    {
        /// <summary>
        /// Gets or sets the reach of the tag.
        /// </summary>
        /// <value>
        /// The reach of the tag.
        /// </value>
        public int Reach
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the count of taggings users.
        /// </summary>
        /// <value>
        /// The  count of taggings users.
        /// </value>
        public int Taggings
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the wiki info.
        /// </summary>
        /// <value>
        /// The wiki info.
        /// </value>
        public Wiki Wiki
        {
            get;
            set;
        }
    }
}
