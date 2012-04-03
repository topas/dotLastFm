//-----------------------------------------------------------------------
// <copyright file="TagApi.cs" company="IxoneCz">
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
    /// Last.fm Tag API
    /// </summary>
    public class TagApi : LastFmApiBase, ITagApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagApi"/> class.
        /// </summary>
        /// <param name="api">The API wrapper.</param>
        public TagApi(ILastFmApi api)
            : base(api)
        {
        }

        /// <summary>
        /// Fetches the top global tags on Last.fm, sorted by popularity (number of times used)
        /// </summary>
        /// <returns>
        /// List of top tags.
        /// </returns>
        public IEnumerable<TopTag> GetTopTags()
        {
            var call = Rest.Method("tag.getTopTags");

            var wrapper = call.Execute<TopTagListWrapper>();

            if (wrapper != null)
            {
                return wrapper.Tags;
            }

            return null;
        }

        /// <summary>
        /// Search for tags similar to this one. Returns tags ranked by similarity, based on listening data.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Tag objects.
        /// </returns>
        public IEnumerable<Tag> GetSimilar(string tag)
        {
            var call = Rest.Method("tag.getSimilar").AddParam("tag", tag);

            var wrapper = call.Execute<TagSimilarWrapper>();

            if (wrapper != null)
            {
                return wrapper.SimilarTags;
            }

            return null;
        }

        /// <summary>
        /// Get the metadata for a tag
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// Tag with details object
        /// </returns>
        public TagWithDetails GetInfo(string tag)
        {
            var call = Rest.Method("tag.getInfo").AddParam("tag", tag);

            var wrapper = call.Execute<TagWithDetailsWrapper>();

            if (wrapper != null)
            {
                return wrapper.Tag;
            }

            return null;
        }

        /// <summary>
        /// Get the top artists tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        public IEnumerable<TagTopArtist> GetTopArtists(string tag)
        {
            return GetTopArtists(tag, 0, 0);
        }

        /// <summary>
        /// Get the top artists tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        public IEnumerable<TagTopArtist> GetTopArtists(string tag, int limit, int page)
        {
            var call = Rest.Method("tag.getTopArtists").AddParam("tag", tag);

            if (limit > 0)
            {
                call.AddParam("limit", limit);
            }

            if (page > 0)
            {
                call.AddParam("page", page);
            }

            var wrapper = call.Execute<TagTopArtistWrapper>();

            if (wrapper != null)
            {
                return wrapper.TopArtists;
            }

            return null;
        }

        /// <summary>
        /// Get the top albums tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        public IEnumerable<TagTopAlbum> GetTopAlbums(string tag)
        {
            return GetTopAlbums(tag, 0, 0);
        }

        /// <summary>
        /// Get the top albums tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Artist objects.
        /// </returns>
        public IEnumerable<TagTopAlbum> GetTopAlbums(string tag, int limit, int page)
        {
            var call = Rest.Method("tag.getTopAlbums").AddParam("tag", tag);

            if (limit > 0)
            {
                call.AddParam("limit", limit);
            }

            if (page > 0)
            {
                call.AddParam("page", page);
            }

            var wrapper = call.Execute<TagTopAlbumWrapper>();

            if (wrapper != null)
            {
                return wrapper.TopAlbums;
            }

            return null;
        }

        /// <summary>
        /// Get the top tracks tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <returns>
        /// List of Track objects.
        /// </returns>
        public IEnumerable<TagTopTrack> GetTopTracks(string tag)
        {
            return GetTopTracks(tag, 0, 0);
        }

        /// <summary>
        /// Get the top tracks tagged by this tag, ordered by tag count.
        /// </summary>
        /// <param name="tag">The tag name.</param>
        /// <param name="limit">The number of results to fetch per page. Defaults to 50.</param>
        /// <param name="page">The page number to fetch. Defaults to first page.</param>
        /// <returns>
        /// List of Track objects.
        /// </returns>
        public IEnumerable<TagTopTrack> GetTopTracks(string tag, int limit, int page)
        {
            var call = Rest.Method("tag.getTopTracks").AddParam("tag", tag);

            if (limit > 0)
            {
                call.AddParam("limit", limit);
            }

            if (page > 0)
            {
                call.AddParam("page", page);
            }

            var wrapper = call.Execute<TagTopTracksWrapper>();

            if (wrapper != null)
            {
                return wrapper.TopTracks;
            }

            return null;
        }
    }
}
