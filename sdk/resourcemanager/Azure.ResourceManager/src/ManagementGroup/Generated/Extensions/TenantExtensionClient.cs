// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Management
{
    /// <summary> An internal class to add extension methods to. </summary>
    internal partial class TenantExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class for mocking. </summary>
        protected TenantExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TenantExtensionClient"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantExtensionClient(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            ArmClient.TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }
    }
}
