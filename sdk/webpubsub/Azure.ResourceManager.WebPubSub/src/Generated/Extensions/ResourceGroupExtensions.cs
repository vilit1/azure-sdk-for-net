// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.WebPubSub
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region WebPubSub
        /// <summary> Gets an object representing a WebPubSubCollection along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="WebPubSubCollection" /> object. </returns>
        public static WebPubSubCollection GetWebPubSubs(this ResourceGroup resourceGroup)
        {
            return new WebPubSubCollection(resourceGroup);
        }
        #endregion

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((armClient) =>
            {
                return new ResourceGroupExtensionClient(armClient, resourceGroup.Id);
            }
            );
        }
    }
}
