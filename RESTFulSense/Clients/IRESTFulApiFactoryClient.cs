﻿// ---------------------------------------------------------------
// Copyright (c) Hassan Habib
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RESTFulSense.Clients
{
    public interface IRESTFulApiFactoryClient
    {
        ValueTask<T> GetContentAsync<T>(string relativeUrl);
        ValueTask<T> GetContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
        ValueTask<string> GetContentStringAsync(string relativeUrl);

        public ValueTask PostContentWithNoResponseAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        public ValueTask PostContentWithNoResponseAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<HttpResponseMessage> PostContentAsync(
            string relativeUrl,
            HttpContent content,
            CancellationToken cancellationToken = default);

        ValueTask<TResult> PostContentAsync<TResult>(
            string relativeUrl,
            HttpContent content,
            CancellationToken cancellationToken = default);

        ValueTask<T> PostContentAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PostContentAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<Stream> PostContentWithStreamResponseAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PostContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<HttpResponseMessage> PutContentAsync(
            string relativeUrl,
            HttpContent content,
            CancellationToken cancellationToken = default);

        ValueTask<TResult> PutContentAsync<TResult>(
            string relativeUrl,
            HttpContent content,
            CancellationToken cancellationToken = default);

        ValueTask<T> PutContentAsync<T>(
            string relativeUrl,
            T content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PutContentAsync<T>(
            string relativeUrl,
            T content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PutContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<TResult> PutContentAsync<TContent, TResult>(
            string relativeUrl,
            TContent content,
            CancellationToken cancellationToken,
            string mediaType = "text/json",
            bool ignoreDefaultValues = false);

        ValueTask<T> PutContentAsync<T>(string relativeUrl);
        ValueTask<T> PutContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
        ValueTask DeleteContentAsync(string relativeUrl);
        ValueTask DeleteContentAsync(string relativeUrl, CancellationToken cancellationToken);
        ValueTask<T> DeleteContentAsync<T>(string relativeUrl);
        ValueTask<T> DeleteContentAsync<T>(string relativeUrl, CancellationToken cancellationToken);
    }
}
