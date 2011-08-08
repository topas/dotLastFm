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
        /// Tag.getTopArtists method.
        /// </summary>
        [Fact]
        public void TagGetTopArtists()
        {
            var list = this.Api.Tag.GetTopArtists("pop");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }

        /// <summary>
        /// Tag.getTopAlbums method.
        /// </summary>
        [Fact]
        public void TagGetTopAlbums()
        {
            var list = this.Api.Tag.GetTopAlbums("pop");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }

        /// <summary>
        /// Tag.getTopTracks method.
        /// </summary>
        [Fact]
        public void TagGetTopTracks()
        {
            var list = this.Api.Tag.GetTopTracks("pop");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }

        /// <summary>
        /// Tag.getTopTags method.
        /// </summary>
        [Fact]
        public void TagGetTopTags()
        {
            var list = this.Api.Tag.GetTopTags();
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }

        /// <summary>
        /// Tag.getSimilar method.
        /// </summary>
        [Fact]
        public void TagGetSimilar()
        {
            var list = this.Api.Tag.GetSimilar("pop");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }

        /// <summary>
        /// Tag.getInfo method.
        /// </summary>
        [Fact]
        public void TagGetInfo()
        {
            var list = this.Api.Tag.GetInfo("pop");
            Assert.NotNull(list);
            Assert.NotNull(list.Wiki);
            Assert.NotNull(list.Name);
            Assert.NotNull(list.Url);  
        }
    }
}
