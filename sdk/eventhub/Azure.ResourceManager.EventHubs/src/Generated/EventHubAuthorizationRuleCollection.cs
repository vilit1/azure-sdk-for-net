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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of AuthorizationRule and their operations over its parent. </summary>
    public partial class EventHubAuthorizationRuleCollection : ArmCollection, IEnumerable<EventHubAuthorizationRule>, IAsyncEnumerable<EventHubAuthorizationRule>
    {
        private readonly ClientDiagnostics _eventHubAuthorizationRuleEventHubsClientDiagnostics;
        private readonly EventHubsRestOperations _eventHubAuthorizationRuleEventHubsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventHubAuthorizationRuleCollection"/> class for mocking. </summary>
        protected EventHubAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventHubAuthorizationRuleCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal EventHubAuthorizationRuleCollection(ArmResource parent) : base(parent)
        {
            _eventHubAuthorizationRuleEventHubsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubAuthorizationRule.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(EventHubAuthorizationRule.ResourceType, out string eventHubAuthorizationRuleEventHubsApiVersion);
            _eventHubAuthorizationRuleEventHubsRestClient = new EventHubsRestOperations(_eventHubAuthorizationRuleEventHubsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, eventHubAuthorizationRuleEventHubsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != EventHub.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, EventHub.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Creates or updates an AuthorizationRule for the specified Event Hub. Creation/update of the AuthorizationRule will take a few seconds to take effect. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual EventHubAuthorizationRuleCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string authorizationRuleName, AuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.CreateOrUpdateAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, parameters, cancellationToken);
                var operation = new EventHubAuthorizationRuleCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an AuthorizationRule for the specified Event Hub. Creation/update of the AuthorizationRule will take a few seconds to take effect. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="parameters"> The shared access AuthorizationRule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<EventHubAuthorizationRuleCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string authorizationRuleName, AuthorizationRuleData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.CreateOrUpdateAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new EventHubAuthorizationRuleCreateOrUpdateOperation(ArmClient, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for an Event Hub by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<EventHubAuthorizationRule> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for an Event Hub by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<EventHubAuthorizationRule>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new EventHubAuthorizationRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<EventHubAuthorizationRule> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<EventHubAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<EventHubAuthorizationRule>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _eventHubAuthorizationRuleEventHubsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<EventHubAuthorizationRule>(null, response.GetRawResponse());
                return Response.FromValue(new EventHubAuthorizationRule(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the authorization rules for an Event Hub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubAuthorizationRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<EventHubAuthorizationRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubAuthorizationRuleEventHubsRestClient.ListAuthorizationRules(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubAuthorizationRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EventHubAuthorizationRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _eventHubAuthorizationRuleEventHubsRestClient.ListAuthorizationRulesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubAuthorizationRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the authorization rules for an Event Hub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubAuthorizationRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EventHubAuthorizationRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubAuthorizationRuleEventHubsRestClient.ListAuthorizationRulesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubAuthorizationRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EventHubAuthorizationRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _eventHubAuthorizationRuleEventHubsClientDiagnostics.CreateScope("EventHubAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _eventHubAuthorizationRuleEventHubsRestClient.ListAuthorizationRulesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new EventHubAuthorizationRule(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<EventHubAuthorizationRule> IEnumerable<EventHubAuthorizationRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventHubAuthorizationRule> IAsyncEnumerable<EventHubAuthorizationRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
