//-----------------------------------------------------------------------
// <copyright file="LastFmApiBase.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api
{
    using Rest;

    /// <summary>
    /// Base class for connecting to Last.fm API
    /// </summary>
    public abstract class LastFmApiBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LastFmApiBase"/> class.
        /// </summary>
        /// <param name="api">The session.</param>
        protected LastFmApiBase(ILastFmApi api)
        {
            Api = api;
            Rest = new RestWrapper(Api.Config);
        }

        /// <summary>
        /// Gets the API wrapper.
        /// </summary>
        protected ILastFmApi Api
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the rest provider.
        /// </summary>
        /// <value>
        /// The rest provider.
        /// </value>
        protected RestWrapper Rest
        {
            get;
            set;
        }
    }
}
