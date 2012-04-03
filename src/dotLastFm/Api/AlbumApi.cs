//-----------------------------------------------------------------------
// <copyright file="AlbumApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using System.Collections.Generic;
    using Models;
    using Models.Wrappers;
    using Rest;

    /// <summary>
    /// Last.fm Album API
    /// </summary>
    public class AlbumApi : LastFmApiBase, IAlbumApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumApi"/> class.
        /// </summary>
        /// <param name="api">The API wrapper.</param>
        public AlbumApi(ILastFmApi api)
            : base(api)
        {
        }

        /// <summary>
        /// Get the metadata for an album on Last.fm using the album name.
        /// </summary>
        /// <param name="album">The album name.</param>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this album is included in the response.</param>
        /// <returns>
        /// Album with details object.
        /// </returns>
        public AlbumWithDetails GetInfo(string album, string artist, bool autocorrect, string username)
        {
            var call = Rest.Method("album.getInfo")
                          .AddParam("album", album)
                          .AddParam("artist", artist)
                          .AddParam("autocorrect", autocorrect ? "1" : "0");

            if (username != null)
            {
                call.AddParam("username", username);
            }

            var wrapper = call.Execute<AlbumWithDetailsWrapper>();

            if (wrapper != null)
            {
                return wrapper.Album;
            }

            return null;
        }

        /// <summary>
        /// Get the metadata for an album on Last.fm using the album name.
        /// </summary>
        /// <param name="album">The album name.</param>
        /// <param name="artist">The artist name.</param>
        /// <returns>
        /// Album with details object.
        /// </returns>
        public AlbumWithDetails GetInfo(string album, string artist)
        {
            return GetInfo(album, artist, false, null);
        }

        /// <summary>
        /// Get the top tags for this album on Last.fm, ordered by tag count using the artist/album name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="album">The album name.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artist names, returning the correct version instead.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist, string album, bool autocorrect)
        {
            var call = Rest.Method("album.getTopTags")
                            .AddParam("artist", artist)
                            .AddParam("album", album)
                            .AddParam("autocorrect", autocorrect ? "1" : "0");

            var wrapper = call.Execute<TopTagListWrapper>();

            if (wrapper != null)
            {
                return wrapper.Tags;
            }

            return null;
        }

        /// <summary>
        /// Get the top tags for this album on Last.fm, ordered by tag count using the artist/album name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="album">The album name.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist, string album)
        {
            return GetTopTags(artist, album, false);
        }
    }
}
