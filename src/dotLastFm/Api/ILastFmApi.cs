//-----------------------------------------------------------------------
// <copyright file="ILastFmApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    /// <summary>
    /// Last.fm session interface
    /// </summary>
    public interface ILastFmApi
    {
        /// <summary>
        /// Gets the track API.
        /// </summary>
        ITrackApi Track
        {
            get;
        }

        /// <summary>
        /// Gets the tag API.
        /// </summary>
        ITagApi Tag
        {
            get;
        }

        /// <summary>
        /// Gets the album API.
        /// </summary>
        IAlbumApi Album
        {
            get;
        }

        /// <summary>
        /// Gets the artist API.
        /// </summary>
        IArtistApi Artist
        {
            get;
        }

        /// <summary>
        /// Gets the config of last.fm client.
        /// </summary>
        ILastFmConfig Config
        {
            get;
        }
    }
}
