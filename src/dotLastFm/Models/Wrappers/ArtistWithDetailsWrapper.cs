//-----------------------------------------------------------------------
// <copyright file="ArtistWithDetailsWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models.Wrappers
{
    using RestSharp.Deserializers;

    /// <summary>
    /// Artist with details wrapper
    /// </summary>
    public class ArtistWithDetailsWrapper
    {
        /// <summary>
        /// Gets or sets the artist object.
        /// </summary>
        /// <value>
        /// The artist object.
        /// </value>
        [DeserializeAs(Name = "artist")]
        public ArtistWithDetails Artist
        {
            get;
            set;
        }
    }
}
