//-----------------------------------------------------------------------
// <copyright file="TagApiTest.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.IntegrationTests
{
    using System.Linq;
    using Xunit;

    /// <summary>
    /// Test for Last.fm's Tag methods
    /// </summary>
    public class TagApiTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagApiTest"/> class.
        /// </summary>
        public TagApiTest()
        {
            Api = new LastFmApi(new TestLastFmConfig());
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
        /// Tag.getTopArtists method.
        /// </summary>
        [Fact]
        public void TagGetTopArtists()
        {
            var list = Api.Tag.GetTopArtists("pop");
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Tag.getTopAlbums method.
        /// </summary>
        [Fact]
        public void TagGetTopAlbums()
        {
            var list = Api.Tag.GetTopAlbums("pop");
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Tag.getTopTracks method.
        /// </summary>
        [Fact]
        public void TagGetTopTracks()
        {
            var list = Api.Tag.GetTopTracks("pop");
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Tag.getTopTags method.
        /// </summary>
        [Fact]
        public void TagGetTopTags()
        {
            var list = Api.Tag.GetTopTags();
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Tag.getSimilar method.
        /// </summary>
        [Fact]
        public void TagGetSimilar()
        {
            var list = Api.Tag.GetSimilar("pop");
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Tag.getInfo method.
        /// </summary>
        [Fact]
        public void TagGetInfo()
        {
            var list = Api.Tag.GetInfo("pop");
            Assert.NotNull(list);
            Assert.NotNull(list.Wiki);
            Assert.NotNull(list.Name);
            Assert.NotNull(list.Url);  
        }
    }
}
