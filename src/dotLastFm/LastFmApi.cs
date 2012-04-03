//-----------------------------------------------------------------------
// <copyright file="LastFmApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm
{
    using Api;

    /// <summary>
    /// Last.fm API sesspis
    /// </summary>
    public class LastFmApi : ILastFmApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastFmApi"/> class.
        /// </summary>
        /// <param name="config">The config.</param>
        public LastFmApi(ILastFmConfig config)
        {
            Config = config;

            Track = new TrackApi(this);
            Tag = new TagApi(this);
            Album = new AlbumApi(this);
            Artist = new ArtistApi(this);
        }

        /// <summary>
        /// Gets the config.
        /// </summary>
        public ILastFmConfig Config
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the album API.
        /// </summary>
        public IAlbumApi Album
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the artist API methods.
        /// </summary>
        public IArtistApi Artist
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the tag API methods.
        /// </summary>
        public ITagApi Tag
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the track API methods.
        /// </summary>
        public ITrackApi Track
        {
            get;
            private set;
        }
    }
}
