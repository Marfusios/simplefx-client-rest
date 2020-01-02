# SimpleFx.Client.Generated.Api.AccountsApi

All URIs are relative to *https://rest.simplefx.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V3AccountsGetAccount**](AccountsApi.md#v3accountsgetaccount) | **GET** /api/v3/accounts/{reality}/{account} | Get status of an account
[**V3AccountsGetAccounts**](AccountsApi.md#v3accountsgetaccounts) | **GET** /api/v3/accounts | List your trading and demo accounts


<a name="v3accountsgetaccount"></a>
# **V3AccountsGetAccount**
> InlineResponse2003 V3AccountsGetAccount (Reality reality, int account)

Get status of an account

This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3AccountsGetAccountExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi(Configuration.Default);
            var reality = new Reality(); // Reality | 
            var account = 56;  // int | 

            try
            {
                // Get status of an account
                InlineResponse2003 result = apiInstance.V3AccountsGetAccount(reality, account);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.V3AccountsGetAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reality** | [**Reality**](Reality.md)|  | 
 **account** | **int**|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3accountsgetaccounts"></a>
# **V3AccountsGetAccounts**
> InlineResponse2002 V3AccountsGetAccounts ()

List your trading and demo accounts

This Request is limmited.  It can not be called more than once per 5 minutes.  Client shall store and track account status returned with trade execution report.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3AccountsGetAccountsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountsApi(Configuration.Default);

            try
            {
                // List your trading and demo accounts
                InlineResponse2002 result = apiInstance.V3AccountsGetAccounts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.V3AccountsGetAccounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

