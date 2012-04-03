//-----------------------------------------------------------------------
// <copyright file="TrackApiTest.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.IntegrationTests
{
    using System.Linq;

    using Xunit;

    /// <summary>
    /// Test for Last.fm's Track methods
    /// </summary>
    public class TrackApiTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackApiTest"/> class.
        /// </summary>
        public TrackApiTest()
        {
            Api = new LastFmApi(new TestLastFmConfig());
        }

        /// <summary>
        /// Gets or sets the API.
        /// </summary>
        /// <value>
        /// The API wrapper.
        /// </value>
        private LastFmApi Api
        {
            get;
            set;
        }

        /// <summary>
        /// Track.getTopTags method.
        /// </summary>
        [Fact]
        public void TrackGetTopTags()
        {
            var list = Api.Track.GetTopTags("Moby", "Porcelain");
            Assert.NotNull(list);
            Assert.True(list.Any());
        }

        /// <summary>
        /// Track.getInfo method.
        /// </summary>
        [Fact]
        public void TrackGetInfo()
        {
            const string artist = "Moby";
            const string title = "Porcelain";
            var track = Api.Track.GetInfo(artist, title);
            Assert.NotNull(track);
            Assert.Equal(title, track.Name);
            Assert.NotNull(track.Album);
            Assert.NotNull(track.Artist);
            Assert.Equal(artist, track.Artist.Name);
            Assert.NotNull(track.Tags);
            Assert.NotNull(track.Streamable);
        }

        /// <summary>
        /// Track.getSimilar method.
        /// </summary>
        [Fact]
        public void TrackSimilar()
        {
            const string artist = "Moby";
            const string title = "Porcelain";
            var list = Api.Track.GetSimilar(artist, title);
            Assert.NotNull(list);
            Assert.True(list.Any());
        }
    }
}
