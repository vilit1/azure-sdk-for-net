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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of LongTermRetentionBackup and their operations over its parent. </summary>
    public partial class SubscriptionLongTermRetentionBackupCollection : ArmCollection, IEnumerable<SubscriptionLongTermRetentionBackup>, IAsyncEnumerable<SubscriptionLongTermRetentionBackup>
    {
        private readonly ClientDiagnostics _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics;
        private readonly LongTermRetentionBackupsRestOperations _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient;
        private readonly string _locationName;
        private readonly string _longTermRetentionServerName;
        private readonly string _longTermRetentionDatabaseName;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackupCollection"/> class for mocking. </summary>
        protected SubscriptionLongTermRetentionBackupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionLongTermRetentionBackupCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        /// <param name="locationName"> The location of the database. </param>
        /// <param name="longTermRetentionServerName"> The name of the server. </param>
        /// <param name="longTermRetentionDatabaseName"> The name of the database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/>, <paramref name="longTermRetentionServerName"/>, or <paramref name="longTermRetentionDatabaseName"/> is null. </exception>
        internal SubscriptionLongTermRetentionBackupCollection(ArmResource parent, string locationName, string longTermRetentionServerName, string longTermRetentionDatabaseName) : base(parent)
        {
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", SubscriptionLongTermRetentionBackup.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SubscriptionLongTermRetentionBackup.ResourceType, out string subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient = new LongTermRetentionBackupsRestOperations(_subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subscriptionLongTermRetentionBackupLongTermRetentionBackupsApiVersion);
            _locationName = locationName;
            _longTermRetentionServerName = longTermRetentionServerName;
            _longTermRetentionDatabaseName = longTermRetentionDatabaseName;
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_Get
        /// <summary> Gets a long term retention backup. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionBackup> Get(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken);
                if (response.Value == null)
                    throw _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups/{backupName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_Get
        /// <summary> Gets a long term retention backup. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionBackup>> GetAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<SubscriptionLongTermRetentionBackup> GetIfExists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.Get(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionLongTermRetentionBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<SubscriptionLongTermRetentionBackup>> GetIfExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.GetAsync(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubscriptionLongTermRetentionBackup>(null, response.GetRawResponse());
                return Response.FromValue(new SubscriptionLongTermRetentionBackup(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public virtual Response<bool> Exists(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(backupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="backupName"> The backup name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="backupName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="backupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string backupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(backupName, nameof(backupName));

            using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(backupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionLongTermRetentionBackup> GetAll(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            Page<SubscriptionLongTermRetentionBackup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByDatabase(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubscriptionLongTermRetentionBackup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Sql/locations/{locationName}/longTermRetentionServers/{longTermRetentionServerName}/longTermRetentionDatabases/{longTermRetentionDatabaseName}/longTermRetentionBackups
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: LongTermRetentionBackups_ListByDatabase
        /// <summary> Lists all long term retention backups for a database. </summary>
        /// <param name="onlyLatestPerDatabase"> Whether or not to only get the latest backup for each database. </param>
        /// <param name="databaseState"> Whether to query against just live databases, just deleted databases, or all databases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionLongTermRetentionBackup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionLongTermRetentionBackup> GetAllAsync(bool? onlyLatestPerDatabase = null, DatabaseState? databaseState = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubscriptionLongTermRetentionBackup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByDatabaseAsync(Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubscriptionLongTermRetentionBackup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subscriptionLongTermRetentionBackupLongTermRetentionBackupsClientDiagnostics.CreateScope("SubscriptionLongTermRetentionBackupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionLongTermRetentionBackupLongTermRetentionBackupsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, _locationName, _longTermRetentionServerName, _longTermRetentionDatabaseName, onlyLatestPerDatabase, databaseState, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubscriptionLongTermRetentionBackup(ArmClient, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SubscriptionLongTermRetentionBackup> IEnumerable<SubscriptionLongTermRetentionBackup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionLongTermRetentionBackup> IAsyncEnumerable<SubscriptionLongTermRetentionBackup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
