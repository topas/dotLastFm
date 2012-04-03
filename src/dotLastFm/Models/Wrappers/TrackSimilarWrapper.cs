//-----------------------------------------------------------------------
// <copyright file="TrackSimilarWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models.Wrappers
{
    using System.Collections.Generic;
    using RestSharp.Deserializers;

    /// <summary>
    /// Wrapper for similar tracks
    /// </summary>
    public class TrackSimilarWrapper
    {
        /// <summary>
        /// Gets or sets the similar tracks.
        /// </summary>
        /// <value>
        /// The similar tracks.
        /// </value>
        [DeserializeAs(Name = "similartracks")]
        public List<TrackSimilar> SimilarTracks
        {
            get;
            set;
        }
    }
}
