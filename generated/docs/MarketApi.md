# SimpleFx.Client.Generated.Api.MarketApi

All URIs are relative to *https://rest.simplefx.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UtilsInstrumentsJsonGet**](MarketApi.md#utilsinstrumentsjsonget) | **GET** /utils/instruments.json | List tradable instruments


<a name="utilsinstrumentsjsonget"></a>
# **UtilsInstrumentsJsonGet**
> Dictionary&lt;string, InlineResponse2001&gt; UtilsInstrumentsJsonGet ()

List tradable instruments

List all tradable assets (instruments, equities, securities).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class UtilsInstrumentsJsonGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            var apiInstance = new MarketApi(Configuration.Default);

            try
            {
                // List tradable instruments
                Dictionary<string, InlineResponse2001> result = apiInstance.UtilsInstrumentsJsonGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MarketApi.UtilsInstrumentsJsonGet: " + e.Message );
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

[**Dictionary&lt;string, InlineResponse2001&gt;**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

