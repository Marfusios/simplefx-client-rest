# SimpleFx.Client.Generated.Api.AUTHENTICATIONApi

All URIs are relative to *https://rest.simplefx.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV3AuthKeyPost**](AUTHENTICATIONApi.md#apiv3authkeypost) | **POST** /api/v3/auth/key | Obtain auhtorization token for other requests


<a name="apiv3authkeypost"></a>
# **ApiV3AuthKeyPost**
> InlineResponse200 ApiV3AuthKeyPost (InlineObject inlineObject)

Obtain auhtorization token for other requests

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class ApiV3AuthKeyPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            var apiInstance = new AUTHENTICATIONApi(Configuration.Default);
            var inlineObject = new InlineObject(); // InlineObject | 

            try
            {
                // Obtain auhtorization token for other requests
                InlineResponse200 result = apiInstance.ApiV3AuthKeyPost(inlineObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AUTHENTICATIONApi.ApiV3AuthKeyPost: " + e.Message );
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
 **inlineObject** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

