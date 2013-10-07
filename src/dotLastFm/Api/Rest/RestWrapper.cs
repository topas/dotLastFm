//-----------------------------------------------------------------------
// <copyright file="RestWrapper.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api.Rest
{
    using System;
    using System.Net;
    using Models;
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
        private readonly Lazy<RestClient> lazyClient;

        /// <summary>
        /// deserializer
        /// </summary>
        private readonly IDeserializer deserializer;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestWrapper"/> class.
        /// </summary>
        /// <param name="config">The config.</param>
        public RestWrapper(ILastFmConfig config)
        {
            this.config = config;
            this.deserializer = new Deserializer();
            lazyClient = new Lazy<RestClient>(CreateRestClient);
        }

        private RestClient CreateRestClient()
        {
            var client = new RestClient(config.BaseUrl);
            client.ClearHandlers();
            client.AddHandler("*", deserializer);
            client.AddDefaultParameter("api_key", config.ApiKey, ParameterType.GetOrPost);
            return client;
        }

        /// <summary>
        /// Gets the client.
        /// </summary>
        protected virtual RestClient Client
        {
            get
            {                
                return lazyClient.Value;
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

            var response = Client.Execute<LastFmResponse<TModel>>(request);

            ValidateResponse(response);

            return response.Data.Value;
        }

        private void ValidateResponse<TModel>(IRestResponse<LastFmResponse<TModel>> response) where TModel : new()
        {
            if (response.Data != null && response.Data.Status != "ok")
            {
                throw new LastFmApiException(response.Data.Error, response.Data.Status);
            }

            if (response.Data == null && response.StatusCode != HttpStatusCode.OK && !String.IsNullOrEmpty(response.Content))
            {
                // deserialize response for non 200 response
                var errorData = deserializer.Deserialize<LastFmResponse<TModel>>(response);
                if (errorData != null)
                {
                    throw new LastFmApiException(errorData.Error, errorData.Status.Trim());
                }
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw new WebException(string.Format("Last.fm has returned {0} HTTP error.", (int) response.StatusCode));
            }

            if (response.Data == null)
            {
                throw new InvalidOperationException("Response cannot get data.");
            }
        }
    }
}
