//-----------------------------------------------------------------------
// <copyright file="LastFmError.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Last.fm return error
    /// </summary>
    public class LastFmError
    {
        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public string Code
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the error value.
        /// </summary>
        /// <value>
        /// The error value.
        /// </value>
        public string Value
        {
            get;
            set;
        }
    }
}
