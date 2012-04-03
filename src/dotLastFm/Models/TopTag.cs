//-----------------------------------------------------------------------
// <copyright file="TopTag.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using RestSharp.Serializers;

    /// <summary>
    /// Last.fm music Tag with count
    /// </summary>
    [SerializeAs(Name = "tag")]
    public class TopTag : Tag
    {
        /// <summary>
        /// Gets or sets the count of the tag.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int Count
        {
            get;
            set;
        }
    }
}
