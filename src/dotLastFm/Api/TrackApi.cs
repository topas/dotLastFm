//-----------------------------------------------------------------------
// <copyright file="TrackApi.cs" company="IxoneCz">
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
    /// Last.fm track API
    /// </summary>
    public class TrackApi : LastFmApiBase, ITrackApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackApi"/> class.
        /// </summary>
        /// <param name="api">The api wapper.</param>
        public TrackApi(ILastFmApi api)
            : base(api)
        {           
        }

        /// <summary>
        /// Get the top tags for this track on Last.fm, ordered by tag count using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist, string track, bool autocorrect)
        {
            var call = Rest.Method("track.getTopTags")
                            .AddParam("artist", artist)
                            .AddParam("track", track)
                            .AddParam("autocorrect", autocorrect ? "1" : "0");

            var wrapper = call.Execute<TopTagListWrapper>();

            if (wrapper != null)
            {
                return wrapper.Tags;
            }

            return null;
        }

        /// <summary>
        /// Get the top tags for this track on Last.fm, ordered by tag count using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>
        /// List of TopTags objects.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags(string artist, string track)
        {
            return GetTopTags(artist, track, false);
        }

        /// <summary>
        /// Get the metadata for a track on Last.fm using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this track and whether they have loved the track is included in the response.</param>
        /// <returns>
        /// The Track object with metadata.
        /// </returns>
        public TrackWithDetails GetInfo(string artist, string track, bool autocorrect, string username)
        {
            var call = Rest.Method("track.getInfo")
                           .AddParam("artist", artist)
                           .AddParam("track", track)
                           .AddParam("autocorrect", autocorrect ? "1" : "0");

            if (username != null)
            {
                call.AddParam("username", username);
            }

            var wrapper = call.Execute<TrackWithDetailsWrapper>();

            if (wrapper != null)
            {
                return wrapper.Track;
            }

            return null;
        }

        /// <summary>
        /// Get the metadata for a track on Last.fm using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>
        /// The Track object with metadata.
        /// </returns>
        public TrackWithDetails GetInfo(string artist, string track)
        {
            return GetInfo(artist, track, false, null);
        }

        /// <summary>
        /// Get the similar tracks for this track on Last.fm, based on listening data.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <param name="limit">Maximum number of similar tracks to return.</param>
        /// <returns>
        /// The Track object with metadata.
        /// </returns>
        public IEnumerable<TrackSimilar> GetSimilar(string artist, string track, bool autocorrect, int limit)
        {
            var call = Rest.Method("track.getSimilar")
                           .AddParam("artist", artist)
                           .AddParam("track", track)
                           .AddParam("autocorrect", autocorrect ? "1" : "0");

            if (limit > 0)
            {
                call.AddParam("limit", limit);
            }

            var wrapper = call.Execute<TrackSimilarWrapper>();

            if (wrapper != null)
            {
                return wrapper.SimilarTracks;
            }

            return null;
        }

        /// <summary>
        /// Get the similar tracks for this track on Last.fm, based on listening data.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>
        /// The Track object with metadata.
        /// </returns>
        public IEnumerable<TrackSimilar> GetSimilar(string artist, string track)
        {
            return GetSimilar(artist, track, false, 0);
        }
    }
}
