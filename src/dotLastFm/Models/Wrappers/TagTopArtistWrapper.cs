//-----------------------------------------------------------------------
// <copyright file="TagTopArtistWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models.Wrappers
{
    using System.Collections.Generic;
    using RestSharp.Deserializers;

    /// <summary>
    /// Wrapper for tag's top artists
    /// </summary>
    public class TagTopArtistWrapper
    {
        /// <summary>
        /// Gets or sets the artists of the tag.
        /// </summary>
        /// <value>
        /// The artists of the tag.
        /// </value>
        [DeserializeAs(Name = "topartists")]
        public List<TagTopArtist> TopArtists
        {
            get;
            set;
        }
    }
}
