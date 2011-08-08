//-----------------------------------------------------------------------
// <copyright file="RestWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api.Rest
{
    using System.Net;
    using DotLastFm.Models;
    using RestSharp;
    using RestSharp.Deserializers;

    /// <summary>
    /// Rest wrapper for simple calling
    /// </summary>
    public class RestWrapper
    {
        /// <summary>
        /// Last.fm configuration
        /// </summary>
        private readonly ILastFmConfig config;

        /// <summary>
        /// Rest client
        /// </summary>
        private RestClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestWrapper"/> class.
        /// </summary>
        /// <param name="config">The config.</param>
        public RestWrapper(ILastFmConfig config)
        {
            this.config = config;
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        protected virtual RestClient Client
        {
            get
            {
                if (this.client == null)
                {
                    this.client = new RestClient(this.config.BaseUrl);
                    this.client.ClearHandlers();
                    this.client.AddHandler("*", new XmlAttributeDeserializer());
                    this.client.AddDefaultParameter("api_key", this.config.ApiKey, ParameterType.GetOrPost); 
                }

                return this.client;
            }
        }

        /// <summary>
        /// Executes the specified method.
        /// </summary>
        /// <typeparam name="TModel">The type of the model.</typeparam>
        /// <param name="method">The method.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>Created model</returns>
        public TModel Execute<TModel>(string method, params Parameter[] parameters) where TModel : new()
        {            
            var request = new RestRequest(Method.GET);
            
            request.AddParameter("method", method, ParameterType.GetOrPost);
            foreach (var p in parameters)
            {
                request.AddParameter(p);
            }

            var response = this.Client.Execute<LastFmResponse<TModel>>(request);

            if (response.Data != null && response.Data.Status != "ok")
            {
                throw new LastFmApiException(response.Data.Error, response.Data.Status);
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new WebException(string.Format("Last.fm has returned {0} HTTP error.", (int)response.StatusCode));
            }

            return response.Data.Value;
        }
    }
}
