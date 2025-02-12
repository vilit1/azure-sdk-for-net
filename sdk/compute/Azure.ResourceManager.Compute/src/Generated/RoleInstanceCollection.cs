// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of RoleInstance and their operations over its parent. </summary>
    public partial class RoleInstanceCollection : ArmCollection, IEnumerable<RoleInstance>, IAsyncEnumerable<RoleInstance>
    {
        private readonly ClientDiagnostics _roleInstanceCloudServiceRoleInstancesClientDiagnostics;
        private readonly CloudServiceRoleInstancesRestOperations _roleInstanceCloudServiceRoleInstancesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleInstanceCollection"/> class for mocking. </summary>
        protected RoleInstanceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleInstanceCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RoleInstanceCollection(ArmResource parent) : base(parent)
        {
            _roleInstanceCloudServiceRoleInstancesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Compute", RoleInstance.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(RoleInstance.ResourceType, out string roleInstanceCloudServiceRoleInstancesApiVersion);
            _roleInstanceCloudServiceRoleInstancesRestClient = new CloudServiceRoleInstancesRestOperations(_roleInstanceCloudServiceRoleInstancesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, roleInstanceCloudServiceRoleInstancesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudService.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudService.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Gets a role instance from a cloud service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual Response<RoleInstance> Get(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = _roleInstanceCloudServiceRoleInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken);
                if (response.Value == null)
                    throw _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleInstance(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a role instance from a cloud service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public async virtual Task<Response<RoleInstance>> GetAsync(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleInstanceCloudServiceRoleInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new RoleInstance(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual Response<RoleInstance> GetIfExists(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleInstanceCloudServiceRoleInstancesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<RoleInstance>(null, response.GetRawResponse());
                return Response.FromValue(new RoleInstance(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public async virtual Task<Response<RoleInstance>> GetIfExistsAsync(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleInstanceCloudServiceRoleInstancesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, roleInstanceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<RoleInstance>(null, response.GetRawResponse());
                return Response.FromValue(new RoleInstance(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(roleInstanceName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="roleInstanceName"> Name of the role instance. </param>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleInstanceName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleInstanceName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string roleInstanceName, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleInstanceName, nameof(roleInstanceName));

            using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(roleInstanceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the list of all role instances in a cloud service. Use nextLink property in the response to get the next page of role instances. Do this till nextLink is null to fetch all the role instances. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleInstance> GetAll(InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            Page<RoleInstance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleInstanceCloudServiceRoleInstancesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleInstance(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RoleInstance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _roleInstanceCloudServiceRoleInstancesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleInstance(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the list of all role instances in a cloud service. Use nextLink property in the response to get the next page of role instances. Do this till nextLink is null to fetch all the role instances. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. &apos;UserData&apos; is not supported for cloud services. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleInstance" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleInstance> GetAllAsync(InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RoleInstance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleInstanceCloudServiceRoleInstancesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleInstance(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RoleInstance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _roleInstanceCloudServiceRoleInstancesClientDiagnostics.CreateScope("RoleInstanceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _roleInstanceCloudServiceRoleInstancesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RoleInstance(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<RoleInstance> IEnumerable<RoleInstance>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleInstance> IAsyncEnumerable<RoleInstance>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
