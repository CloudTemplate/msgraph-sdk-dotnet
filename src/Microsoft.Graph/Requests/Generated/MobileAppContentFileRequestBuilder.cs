// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type MobileAppContentFileRequestBuilder.
    /// </summary>
    public partial class MobileAppContentFileRequestBuilder : EntityRequestBuilder, IMobileAppContentFileRequestBuilder
    {

        /// <summary>
        /// Constructs a new MobileAppContentFileRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MobileAppContentFileRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMobileAppContentFileRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMobileAppContentFileRequest Request(IEnumerable<Option> options)
        {
            return new MobileAppContentFileRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for MobileAppContentFileCommit.
        /// </summary>
        /// <returns>The <see cref="IMobileAppContentFileCommitRequestBuilder"/>.</returns>
        public IMobileAppContentFileCommitRequestBuilder Commit(
            FileEncryptionInfo fileEncryptionInfo = null)
        {
            return new MobileAppContentFileCommitRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.commit"),
                this.Client,
                fileEncryptionInfo);
        }

        /// <summary>
        /// Gets the request builder for MobileAppContentFileRenewUpload.
        /// </summary>
        /// <returns>The <see cref="IMobileAppContentFileRenewUploadRequestBuilder"/>.</returns>
        public IMobileAppContentFileRenewUploadRequestBuilder RenewUpload()
        {
            return new MobileAppContentFileRenewUploadRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.renewUpload"),
                this.Client);
        }
    
    }
}
