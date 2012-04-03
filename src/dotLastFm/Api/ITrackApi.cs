//-----------------------------------------------------------------------
// <copyright file="ITrackApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Last.fm Track API
    /// </summary>
    public interface ITrackApi
    {
        /// <summary>
        /// Get the top tags for this track on Last.fm, ordered by tag count using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist, string track, bool autocorrect);

        /// <summary>
        /// Get the top tags for this track on Last.fm, ordered by tag count using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist, string track);

        /// <summary>
        /// Get the metadata for a track on Last.fm using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this track and whether they have loved the track is included in the response.</param>
        /// <returns>The Track object with metadata.</returns>
        TrackWithDetails GetInfo(string artist, string track, bool autocorrect, string username);

        /// <summary>
        /// Get the metadata for a track on Last.fm using the artist/track name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>The Track object with metadata.</returns>
        TrackWithDetails GetInfo(string artist, string track);

        /// <summary>
        /// Get the similar tracks for this track on Last.fm, based on listening data.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <param name="autocorrect">Transform misspelled artist and track names into correct artist and track names, returning the correct version instead.</param> 
        /// <param name="limit">Maximum number of similar tracks to return.</param>
        /// <returns>The Track object with metadata.</returns>
        IEnumerable<TrackSimilar> GetSimilar(string artist, string track, bool autocorrect, int limit);

        /// <summary>
        /// Get the similar tracks for this track on Last.fm, based on listening data.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="track">The track name.</param>
        /// <returns>The Track object with metadata.</returns>
        IEnumerable<TrackSimilar> GetSimilar(string artist, string track);
    }
}
