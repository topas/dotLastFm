//-----------------------------------------------------------------------
// <copyright file="TagWithDetailsWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models.Wrappers
{
    using RestSharp.Deserializers;

    /// <summary>
    /// Tag with details wrapper
    /// </summary>
    public class TagWithDetailsWrapper
    {
        /// <summary>
        /// Gets or sets the tag object.
        /// </summary>
        /// <value>
        /// The tag object.
        /// </value>
        [DeserializeAs(Name = "tag")]
        public TagWithDetails Tag
        {
            get;
            set;
        }
    }
}
