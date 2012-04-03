//-----------------------------------------------------------------------
// <copyright file="ArtistApi.cs" company="IxoneCz">
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
    /// Last.fm artist API
    /// </summary>
    public class ArtistApi : LastFmApiBase, IArtistApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistApi"/> class.
        /// </summary>
        /// <param name="api">The API wrapper.</param>
        public ArtistApi(ILastFmApi api)
            : base(api)
        {
        }

        /// <summary>
        /// Get the top tags for an artist on Last.fm, ordered by popularity.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist, bool autocorrect)
        {
            var call = Rest.Method("artist.getTopTags")
                            .AddParam("artist", artist)
                            .AddParam("autocorrect", autocorrect ? "1" : "0");

            var wrapper = call.Execute<TopTagListWrapper>();

            if (wrapper != null)
            {
                return wrapper.Tags;
            }

            return null;
        }

        /// <summary>
        /// Get the top tags for an artist on Last.fm, ordered by popularity.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist)
        {
            return GetTopTags(artist, false);
        }

        /// <summary>
        /// Get the metadata for an artist. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artis name, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this track and whether they have loved the track is included in the response.</param>
        /// <returns>
        /// The Artist object with metadata.
        /// </returns>
        public ArtistWithDetails GetInfo(string artist, bool autocorrect, string username)
        {
            var call = Rest.Method("artist.getInfo")
                           .AddParam("artist", artist)
                           .AddParam("autocorrect", autocorrect ? "1" : "0");

            if (username != null)
            {
                call.AddParam("username", username);
            }

            var wrapper = call.Execute<ArtistWithDetailsWrapper>();

            if (wrapper != null)
            {
                return wrapper.Artist;
            }

            return null;
        }

        /// <summary>
        /// Get the metadata for an artist. Includes biography.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <returns>
        /// The Artist object with metadata.
        /// </returns>
        public ArtistWithDetails GetInfo(string artist)
        {
            return GetInfo(artist, false, null);
        }
    }
}
