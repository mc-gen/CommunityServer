// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading;

using Microsoft.Graph;

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.OneDrive.Sdk
{
    /// <summary>
    /// The type ItemCreateLinkRequest.
    /// </summary>
    public partial class ItemCreateLinkRequest : BaseRequest, IItemCreateLinkRequest
    {
        /// <summary>
        /// Constructs a new ItemCreateLinkRequest.
        /// </summary>
        public ItemCreateLinkRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.Method = "POST";
            this.ContentType = "application/json";
            this.RequestBody = new ItemCreateLinkRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public ItemCreateLinkRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        public System.Threading.Tasks.Task<Permission> PostAsync()
        {
            return this.PostAsync(CancellationToken.None);
        }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name=""cancellationToken"">The <see cref=""CancellationToken""/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public System.Threading.Tasks.Task<Permission> PostAsync(
            CancellationToken cancellationToken)
        {
            return this.SendAsync<Permission>(this.RequestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IItemCreateLinkRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IItemCreateLinkRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }
    }
}
