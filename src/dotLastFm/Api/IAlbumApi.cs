//-----------------------------------------------------------------------
// <copyright file="IAlbumApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using System.Collections.Generic;

    using Models;

    /// <summary>
    /// Last.fm Album API
    /// </summary>
    public interface IAlbumApi
    {
        /// <summary>
        /// Get the metadata for an album on Last.fm using the album name.
        /// </summary>
        /// <param name="album">The album name.</param>
        /// <param name="artist">The artist name.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artist names, returning the correct version instead.</param>
        /// <param name="username">The username for the context of the request. If supplied, the user's playcount for this album is included in the response.</param>
        /// <returns>Album with details object.</returns>
        AlbumWithDetails GetInfo(string album, string artist, bool autocorrect, string username);

        /// <summary>
        /// Get the metadata for an album on Last.fm using the album name.
        /// </summary>
        /// <param name="album">The album name.</param>
        /// <param name="artist">The artist name.</param>
        /// <returns>Album with details object.</returns>
        AlbumWithDetails GetInfo(string album, string artist);

        /// <summary>
        /// Get the top tags for this album on Last.fm, ordered by tag count using the artist/album name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="album">The album name.</param>
        /// <param name="autocorrect">Transform misspelled artist names into correct artist names, returning the correct version instead.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist, string album, bool autocorrect);

        /// <summary>
        /// Get the top tags for this album on Last.fm, ordered by tag count using the artist/album name.
        /// </summary>
        /// <param name="artist">The artist name.</param>
        /// <param name="album">The album name.</param>
        /// <returns>List of TopTags objects.</returns>
        IEnumerable<TopTag> GetTopTags(string artist, string album);
    }
}
