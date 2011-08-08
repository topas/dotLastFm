//-----------------------------------------------------------------------
// <copyright file="AlbumApiTest.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.IntegrationTests
{
    using System.Linq;

    using Xunit;

    /// <summary>
    /// Test for Last.fm's Album methods
    /// </summary>
    public class AlbumApiTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumApiTest"/> class.
        /// </summary>
        public AlbumApiTest()
        {
            this.Api = new LastFmApi(new TestLastFmConfig());
        }

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>
        /// The API.
        /// </value>
        private LastFmApi Api
        {
            get;
            set;
        }

        /// <summary>
        /// Album.getInfo method.
        /// </summary>
        [Fact]
        public void AlbumGetInfo()
        {
            const string artist = "Moby";
            const string albumName = "Play";
            var album = this.Api.Album.GetInfo(albumName, artist);
            Assert.NotNull(album);
            Assert.Equal(albumName, album.Name);
            Assert.NotNull(album.Tracks);
            Assert.Equal(artist, album.ArtistName);
            Assert.NotNull(album.Tags);
            Assert.NotNull(album.Wiki);
        }

        /// <summary>
        /// Album.getTopTags method.
        /// </summary>
        [Fact]
        public void AlbumGetTopTags()
        {
            var list = this.Api.Album.GetTopTags("Moby", "Play");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }
    }
}
