//-----------------------------------------------------------------------
// <copyright file="Track.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    using RestSharp.Deserializers;

    /// <summary>
    /// The Last.fm track
    /// </summary>
    public class Track
    {
        /// <summary>
        /// Gets or sets the name of the track.
        /// </summary>
        /// <value>
        /// The name of the track.
        /// </value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public int Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL of last.fm track profile.
        /// </summary>
        /// <value>
        /// The URL of last.fm track profile.
        /// </value>
        public string Url
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets or sets the streamable flag.
        /// </summary>
        /// <value>
        /// The streamable flag.
        /// </value>
        [DeserializeAs(Name = "streamable")]
        public StreamableFlag Streamable
        {
            get;
            set;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
