//-----------------------------------------------------------------------
// <copyright file="Album.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Models
{
    /// <summary>
    /// Last.fm album
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Gets or sets the title of the album.
        /// </summary>
        /// <value>
        /// The title of the album.
        /// </value>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the  musicbrainz id.
        /// </summary>
        /// <value>
        /// The musicbrainz id.
        /// </value>
        public string MbId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the URL of last.fm album profile.
        /// </summary>
        /// <value>
        /// The URL of last.fm album profile.
        /// </value>
        public string Url
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
