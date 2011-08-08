//-----------------------------------------------------------------------
// <copyright file="ArtistApiTest.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.IntegrationTests
{
    using System.Linq;

    using Xunit;

    /// <summary>
    /// Test for Last.fm's Artist methods
    /// </summary>
    public class ArtistApiTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistApiTest"/> class.
        /// </summary>
        public ArtistApiTest()
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
        /// Artist.getInfo method.
        /// </summary>
        [Fact]
        public void ArtistGetInfo()
        {
            const string artistName = "Moby";
            var artist = this.Api.Artist.GetInfo(artistName);
            Assert.NotNull(artist);
            Assert.Equal(artistName, artist.Name);
            Assert.NotNull(artist.Tags);
            Assert.NotNull(artist.Stats);
            Assert.NotNull(artist.SimilarArtists);
            Assert.True(artist.SimilarArtists.Count > 0);
            Assert.NotNull(artist.Streamable);
        }

        /// <summary>
        /// Artist.getTopTags method.
        /// </summary>
        [Fact]
        public void ArtistGetTopTags()
        {
            var list = this.Api.Artist.GetTopTags("Moby");
            Assert.NotNull(list);
            Assert.True(list.Count() > 0);
        }
    }
}
