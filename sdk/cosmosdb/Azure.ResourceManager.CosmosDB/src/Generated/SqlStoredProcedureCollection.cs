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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing collection of SqlStoredProcedure and their operations over its parent. </summary>
    public partial class SqlStoredProcedureCollection : ArmCollection, IEnumerable<SqlStoredProcedure>, IAsyncEnumerable<SqlStoredProcedure>
    {
        private readonly ClientDiagnostics _sqlStoredProcedureSqlResourcesClientDiagnostics;
        private readonly SqlResourcesRestOperations _sqlStoredProcedureSqlResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlStoredProcedureCollection"/> class for mocking. </summary>
        protected SqlStoredProcedureCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SqlStoredProcedureCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlStoredProcedureCollection(ArmResource parent) : base(parent)
        {
            _sqlStoredProcedureSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", SqlStoredProcedure.ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(SqlStoredProcedure.ResourceType, out string sqlStoredProcedureSqlResourcesApiVersion);
            _sqlStoredProcedureSqlResourcesRestClient = new SqlResourcesRestOperations(_sqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sqlStoredProcedureSqlResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SqlContainer.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SqlContainer.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// <summary> Create or update an Azure Cosmos DB SQL storedProcedure. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="createUpdateSqlStoredProcedureParameters"> The parameters to provide for the current SQL storedProcedure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> or <paramref name="createUpdateSqlStoredProcedureParameters"/> is null. </exception>
        public virtual SqlStoredProcedureCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string storedProcedureName, SqlStoredProcedureCreateUpdateOptions createUpdateSqlStoredProcedureParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));
            if (createUpdateSqlStoredProcedureParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlStoredProcedureParameters));
            }

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlStoredProcedureSqlResourcesRestClient.CreateUpdateSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, createUpdateSqlStoredProcedureParameters, cancellationToken);
                var operation = new SqlStoredProcedureCreateOrUpdateOperation(ArmClient, _sqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, _sqlStoredProcedureSqlResourcesRestClient.CreateCreateUpdateSqlStoredProcedureRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, createUpdateSqlStoredProcedureParameters).Request, response);
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

        /// <summary> Create or update an Azure Cosmos DB SQL storedProcedure. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="createUpdateSqlStoredProcedureParameters"> The parameters to provide for the current SQL storedProcedure. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> or <paramref name="createUpdateSqlStoredProcedureParameters"/> is null. </exception>
        public async virtual Task<SqlStoredProcedureCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string storedProcedureName, SqlStoredProcedureCreateUpdateOptions createUpdateSqlStoredProcedureParameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));
            if (createUpdateSqlStoredProcedureParameters == null)
            {
                throw new ArgumentNullException(nameof(createUpdateSqlStoredProcedureParameters));
            }

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlStoredProcedureSqlResourcesRestClient.CreateUpdateSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, createUpdateSqlStoredProcedureParameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlStoredProcedureCreateOrUpdateOperation(ArmClient, _sqlStoredProcedureSqlResourcesClientDiagnostics, Pipeline, _sqlStoredProcedureSqlResourcesRestClient.CreateCreateUpdateSqlStoredProcedureRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, createUpdateSqlStoredProcedureParameters).Request, response);
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

        /// <summary> Gets the SQL storedProcedure under an existing Azure Cosmos DB database account. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual Response<SqlStoredProcedure> Get(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken);
                if (response.Value == null)
                    throw _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlStoredProcedure(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the SQL storedProcedure under an existing Azure Cosmos DB database account. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public async virtual Task<Response<SqlStoredProcedure>> GetAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlStoredProcedure(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual Response<SqlStoredProcedure> GetIfExists(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedure(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SqlStoredProcedure>(null, response.GetRawResponse());
                return Response.FromValue(new SqlStoredProcedure(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public async virtual Task<Response<SqlStoredProcedure>> GetIfExistsAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sqlStoredProcedureSqlResourcesRestClient.GetSqlStoredProcedureAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, storedProcedureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SqlStoredProcedure>(null, response.GetRawResponse());
                return Response.FromValue(new SqlStoredProcedure(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public virtual Response<bool> Exists(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(storedProcedureName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="storedProcedureName"> Cosmos DB storedProcedure name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storedProcedureName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storedProcedureName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string storedProcedureName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(storedProcedureName, nameof(storedProcedureName));

            using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(storedProcedureName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists the SQL storedProcedure under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SqlStoredProcedure" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SqlStoredProcedure> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SqlStoredProcedure> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sqlStoredProcedureSqlResourcesRestClient.ListSqlStoredProcedures(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlStoredProcedure(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> Lists the SQL storedProcedure under an existing Azure Cosmos DB database account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SqlStoredProcedure" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SqlStoredProcedure> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SqlStoredProcedure>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sqlStoredProcedureSqlResourcesClientDiagnostics.CreateScope("SqlStoredProcedureCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sqlStoredProcedureSqlResourcesRestClient.ListSqlStoredProceduresAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SqlStoredProcedure(ArmClient, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<SqlStoredProcedure> IEnumerable<SqlStoredProcedure>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SqlStoredProcedure> IAsyncEnumerable<SqlStoredProcedure>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
