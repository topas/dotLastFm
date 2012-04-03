//-----------------------------------------------------------------------
// <copyright file="ITagApi.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using System.Collections.Generic;
    using Models;

    /// <summary>
    /// Last.fm Tag API
    /// </summary>
    public interface ITagApi
    {
        /// <summary>
        /// Search for tags similar to this one. Returns tags ranked by similarity, based on listening data.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>List of Tag objects.</returns>
        IEnumerable<Tag> GetSimilar(string tag);

        /// <summary>
        /// Get the metadata for a tag
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>Tag with details object</returns>
        TagWithDetails GetInfo(string tag);

        /// <summary>
        /// Fetches the top global tags on Last.fm, sorted by popularity (number of times used)
        /// </summary>
        /// <returns>List of top tags.</returns>
        IEnumerable<TopTag> GetTopTags();
            
        /// <summary>
        /// Get the top artists tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        IEnumerable<TagTopArtist> GetTopArtists(string tag);

        /// <summary>
        /// Get the top artists tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        IEnumerable<TagTopArtist> GetTopArtists(string tag, int limit, int page);

        /// <summary>
        /// Get the top albums tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        IEnumerable<TagTopAlbum> GetTopAlbums(string tag);

        /// <summary>
        /// Get the top albums tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        IEnumerable<TagTopAlbum> GetTopAlbums(string tag, int limit, int page);

        /// <summary>
        /// Get the top tracks tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Track objects.
        /// </returns>
        IEnumerable<TagTopTrack> GetTopTracks(string tag);

        /// <summary>
        /// Get the top tracks tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Track objects.
        /// </returns>
        IEnumerable<TagTopTrack> GetTopTracks(string tag, int limit, int page);
    }
}
