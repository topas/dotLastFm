//-----------------------------------------------------------------------
// <copyright file="Wiki.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using System;

    /// <summary>
    /// Last.fm wiki texts
    /// </summary>
    public class Wiki
    {
        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        /// <value>
        /// The published date.
        /// </value>
        public DateTime? Published
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the summary text.
        /// </summary>
        /// <value>
        /// The summary text.
        /// </value>
        public string Summary
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the content of the wiki.
        /// </summary>
        /// <value>
        /// The content of the wiki.
        /// </value>
        public string Content
        {
            get;
            set;
        }
    }
}
