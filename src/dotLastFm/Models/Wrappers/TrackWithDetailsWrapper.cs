//-----------------------------------------------------------------------
// <copyright file="TrackWithDetailsWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models.Wrappers
{
    using RestSharp.Deserializers;

    /// <summary>
    /// Track with details wrapper
    /// </summary>
    public class TrackWithDetailsWrapper
    {
        /// <summary>
        /// Gets or sets the track.
        /// </summary>
        /// <value>
        /// The track.
        /// </value>
        [DeserializeAs(Name = "track")]
        public TrackWithDetails Track
        {
            get;
            set;
        }
    }
}
