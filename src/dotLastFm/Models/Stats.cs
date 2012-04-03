//-----------------------------------------------------------------------
// <copyright file="Stats.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Last.fm statistics summary
    /// </summary>
    public class Stats  
    {
        /// <summary>
        /// Gets or sets the listeners count.
        /// </summary>
        /// <value>
        /// The listeners count.
        /// </value>
        public int Listeners
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the plays count.
        /// </summary>
        /// <value>
        /// The plays count.
        /// </value>
        public int PlayCount
        {
            get;
            set;
        }
    }
}
