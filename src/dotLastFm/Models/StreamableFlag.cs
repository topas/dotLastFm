//-----------------------------------------------------------------------
// <copyright file="StreamableFlag.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using RestSharp.Deserializers;

    /// <summary>
    /// Last.fm's streamble flag
    /// </summary>
    [DeserializeAs(Name = "streamable")]
    public class StreamableFlag
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Track"/> is streamable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if streamable; otherwise, <c>false</c>.
        /// </value>
        public bool Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether full track is available.
        /// </summary>
        /// <value>
        ///   <c>true</c> if full track is available; otherwise, <c>false</c>.
        /// </value>
        [DeserializeAs(Attribute = true, Name = "fulltrack")]
        public bool FullTrack
        {
            get;
            set;
        }
    }
}
