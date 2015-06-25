namespace Fixtures.Azure.SwaggerBatLro
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Azure;
    using Models;

    public static partial class DONOTCALLsOperationsExtensions
    {
            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetProvisioning202Accepted200Succeeded(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetProvisioning202Accepted200SucceededAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetProvisioning202Accepted200SucceededAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetProvisioning202Accepted200SucceededWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Failed’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetProvisioning202Deleting200Failed(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetProvisioning202Deleting200FailedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Failed’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetProvisioning202Deleting200FailedAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetProvisioning202Deleting200FailedWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Canceled’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetProvisioning202Deleting200canceled(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetProvisioning202Deleting200canceledAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with
            /// ProvisioningState=’Canceled’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetProvisioning202Deleting200canceledAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetProvisioning202Deleting200canceledWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with no location
            /// header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void GetDelete202Retry200(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetDelete202Retry200Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with no location
            /// header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetDelete202Retry200Async( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetDelete202Retry200WithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with no location
            /// header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void Get202NoRetry204(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).Get202NoRetry204Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a ‘200’ with no location
            /// header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Get202NoRetry204Async( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Get202NoRetry204WithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request poller, service returns a ‘200’ with a Product.
            /// Client should return with successf rom long-running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product Post202Retry200Polling(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).Post202Retry200PollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request poller, service returns a ‘200’ with a Product.
            /// Client should return with successf rom long-running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> Post202Retry200PollingAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.Post202Retry200PollingWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running post request poller, service returns a ‘204' with no enetity
            /// body.  Client should return with success from long-running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void Post202NoRetry204Polling(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).Post202NoRetry204PollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request poller, service returns a ‘204' with no enetity
            /// body.  Client should return with success from long-running operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task Post202NoRetry204PollingAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Post202NoRetry204PollingWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running put request poller, service returns a 500, then a  ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product GetRetryProvisioning202Accepted200Succeeded(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetRetryProvisioning202Accepted200SucceededAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a 500, then a  ‘200’ with
            /// ProvisioningState=’Succeeded’
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> GetRetryProvisioning202Accepted200SucceededAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.GetRetryProvisioning202Accepted200SucceededWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running put request poller, service returns a 500, then a  ‘200’ with
            /// no location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void GetRetry202Retry200(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetRetry202Retry200Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a 500, then a  ‘200’ with
            /// no location header
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetRetry202Retry200Async( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetRetry202Retry200WithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request poller, service returns a 500, then a  ‘200’
            /// with a Product.  Client should return with successf rom long-running
            /// operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product PostRetry202Retry200Polling(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).PostRetry202Retry200PollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request poller, service returns a 500, then a  ‘200’
            /// with a Product.  Client should return with successf rom long-running
            /// operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PostRetry202Retry200PollingAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PostRetry202Retry200PollingWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void GetNonRetry400(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetNonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// DO NOT CALL THIS METHOD. For completion only
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetNonRetry400Async( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetNonRetry400WithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running put request poller, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static void GetRetry202NonRetry400(this IDONOTCALLsOperations operations)
            {
                Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).GetRetry202NonRetry400Async(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running put request poller, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task GetRetry202NonRetry400Async( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetRetry202NonRetry400WithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Long running post request poller, service returns a 500, then a  ‘200’
            /// with a Product.  Client should return with successf rom long-running
            /// operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product PostRetry202Retry400Polling(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).PostRetry202Retry400PollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request poller, service returns a 500, then a  ‘200’
            /// with a Product.  Client should return with successf rom long-running
            /// operation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PostRetry202Retry400PollingAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PostRetry202Retry400PollingWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Long running post request poller, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            public static Product PostRetry202NonRetry400Polling(this IDONOTCALLsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDONOTCALLsOperations)s).PostRetry202NonRetry400PollingAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Long running post request poller, service returns a 400 with an error body
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<Product> PostRetry202NonRetry400PollingAsync( this IDONOTCALLsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<Product> result = await operations.PostRetry202NonRetry400PollingWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}