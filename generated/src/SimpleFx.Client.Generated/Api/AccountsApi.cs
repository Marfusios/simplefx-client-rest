/* 
 * SimpleFX
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace SimpleFx.Client.Generated.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get status of an account
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 V3AccountsGetAccount (Reality reality, int account);

        /// <summary>
        /// Get status of an account
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> V3AccountsGetAccountWithHttpInfo (Reality reality, int account);
        /// <summary>
        /// List your trading and demo accounts
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 V3AccountsGetAccounts ();

        /// <summary>
        /// List your trading and demo accounts
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> V3AccountsGetAccountsWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get status of an account
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> V3AccountsGetAccountAsync (Reality reality, int account);

        /// <summary>
        /// Get status of an account
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> V3AccountsGetAccountAsyncWithHttpInfo (Reality reality, int account);
        /// <summary>
        /// List your trading and demo accounts
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> V3AccountsGetAccountsAsync ();

        /// <summary>
        /// List your trading and demo accounts
        /// </summary>
        /// <remarks>
        /// This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </remarks>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> V3AccountsGetAccountsAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccountsApi : IAccountsApiSync, IAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountsApi : IAccountsApi
    {
        private SimpleFx.Client.Generated.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountsApi(String basePath)
        {
            this.Configuration = SimpleFx.Client.Generated.Client.Configuration.MergeConfigurations(
                SimpleFx.Client.Generated.Client.GlobalConfiguration.Instance,
                new SimpleFx.Client.Generated.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SimpleFx.Client.Generated.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SimpleFx.Client.Generated.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SimpleFx.Client.Generated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountsApi(SimpleFx.Client.Generated.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SimpleFx.Client.Generated.Client.Configuration.MergeConfigurations(
                SimpleFx.Client.Generated.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SimpleFx.Client.Generated.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SimpleFx.Client.Generated.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SimpleFx.Client.Generated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccountsApi(SimpleFx.Client.Generated.Client.ISynchronousClient client,SimpleFx.Client.Generated.Client.IAsynchronousClient asyncClient, SimpleFx.Client.Generated.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SimpleFx.Client.Generated.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SimpleFx.Client.Generated.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SimpleFx.Client.Generated.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SimpleFx.Client.Generated.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SimpleFx.Client.Generated.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get status of an account This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 V3AccountsGetAccount (Reality reality, int account)
        {
             SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2003> localVarResponse = V3AccountsGetAccountWithHttpInfo(reality, account);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get status of an account This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public SimpleFx.Client.Generated.Client.ApiResponse< InlineResponse2003 > V3AccountsGetAccountWithHttpInfo (Reality reality, int account)
        {
            // verify the required parameter 'reality' is set
            if (reality == null)
                throw new SimpleFx.Client.Generated.Client.ApiException(400, "Missing required parameter 'reality' when calling AccountsApi->V3AccountsGetAccount");

            // verify the required parameter 'account' is set
            if (account == null)
                throw new SimpleFx.Client.Generated.Client.ApiException(400, "Missing required parameter 'account' when calling AccountsApi->V3AccountsGetAccount");

            SimpleFx.Client.Generated.Client.RequestOptions localVarRequestOptions = new SimpleFx.Client.Generated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = SimpleFx.Client.Generated.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SimpleFx.Client.Generated.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (reality != null)
                localVarRequestOptions.PathParameters.Add("reality", SimpleFx.Client.Generated.Client.ClientUtils.ParameterToString(reality)); // path parameter
            if (account != null)
                localVarRequestOptions.PathParameters.Add("account", SimpleFx.Client.Generated.Client.ClientUtils.ParameterToString(account)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + SimpleFx.Client.Generated.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< InlineResponse2003 >("/api/v3/accounts/{reality}/{account}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V3AccountsGetAccount", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get status of an account This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> V3AccountsGetAccountAsync (Reality reality, int account)
        {
             SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2003> localVarResponse = await V3AccountsGetAccountAsyncWithHttpInfo(reality, account);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get status of an account This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reality"></param>
        /// <param name="account"></param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2003>> V3AccountsGetAccountAsyncWithHttpInfo (Reality reality, int account)
        {
            // verify the required parameter 'reality' is set
            if (reality == null)
                throw new SimpleFx.Client.Generated.Client.ApiException(400, "Missing required parameter 'reality' when calling AccountsApi->V3AccountsGetAccount");

            // verify the required parameter 'account' is set
            if (account == null)
                throw new SimpleFx.Client.Generated.Client.ApiException(400, "Missing required parameter 'account' when calling AccountsApi->V3AccountsGetAccount");


            SimpleFx.Client.Generated.Client.RequestOptions localVarRequestOptions = new SimpleFx.Client.Generated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (reality != null)
                localVarRequestOptions.PathParameters.Add("reality", SimpleFx.Client.Generated.Client.ClientUtils.ParameterToString(reality)); // path parameter
            if (account != null)
                localVarRequestOptions.PathParameters.Add("account", SimpleFx.Client.Generated.Client.ClientUtils.ParameterToString(account)); // path parameter

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + SimpleFx.Client.Generated.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<InlineResponse2003>("/api/v3/accounts/{reality}/{account}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V3AccountsGetAccount", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List your trading and demo accounts This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 V3AccountsGetAccounts ()
        {
             SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2002> localVarResponse = V3AccountsGetAccountsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// List your trading and demo accounts This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public SimpleFx.Client.Generated.Client.ApiResponse< InlineResponse2002 > V3AccountsGetAccountsWithHttpInfo ()
        {
            SimpleFx.Client.Generated.Client.RequestOptions localVarRequestOptions = new SimpleFx.Client.Generated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = SimpleFx.Client.Generated.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SimpleFx.Client.Generated.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + SimpleFx.Client.Generated.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get< InlineResponse2002 >("/api/v3/accounts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V3AccountsGetAccounts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List your trading and demo accounts This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> V3AccountsGetAccountsAsync ()
        {
             SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2002> localVarResponse = await V3AccountsGetAccountsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// List your trading and demo accounts This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.
        /// </summary>
        /// <exception cref="SimpleFx.Client.Generated.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<SimpleFx.Client.Generated.Client.ApiResponse<InlineResponse2002>> V3AccountsGetAccountsAsyncWithHttpInfo ()
        {

            SimpleFx.Client.Generated.Client.RequestOptions localVarRequestOptions = new SimpleFx.Client.Generated.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (bearerAuth) required
            // http basic authentication required
            if (!String.IsNullOrEmpty(this.Configuration.Username) || !String.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + SimpleFx.Client.Generated.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<InlineResponse2002>("/api/v3/accounts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V3AccountsGetAccounts", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
