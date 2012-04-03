//-----------------------------------------------------------------------
// <copyright file="LastFmResponse.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Generic response
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    internal class LastFmResponse<TModel>
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public TModel Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the status of the response.
        /// </summary>
        /// <value>
        /// The status of the response.
        /// </value>
        public string Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Last.fm error
        /// </summary>
        public LastFmError Error
        {
            get;
            set;
        }
    }
}
