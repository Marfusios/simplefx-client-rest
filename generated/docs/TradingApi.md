# SimpleFx.Client.Generated.Api.TradingApi

All URIs are relative to *https://rest.simplefx.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V3TradingCloseAllBySymbol**](TradingApi.md#v3tradingcloseallbysymbol) | **DELETE** /api/v3/trading/orders/market/bysymbol | Clear position on symbol.
[**V3TradingCloseMany**](TradingApi.md#v3tradingclosemany) | **DELETE** /api/v3/trading/orders/market/closemany | Close multiple positions.
[**V3TradingCloseMarketOrder**](TradingApi.md#v3tradingclosemarketorder) | **DELETE** /api/v3/trading/orders/market | Close single position.
[**V3TradingDeletePendingOrder**](TradingApi.md#v3tradingdeletependingorder) | **DELETE** /api/v3/trading/orders/pending | Cancel pending order.
[**V3TradingGetActiveOrders**](TradingApi.md#v3tradinggetactiveorders) | **POST** /api/v3/trading/orders/active | Get positions and pending orders.
[**V3TradingGetHistoryOrders**](TradingApi.md#v3tradinggethistoryorders) | **POST** /api/v3/trading/orders/history | Get closed/inactive orders and positions.
[**V3TradingOpenMarketOrder**](TradingApi.md#v3tradingopenmarketorder) | **POST** /api/v3/trading/orders/market | BUY or SELL by market price
[**V3TradingOpenPendingOrder**](TradingApi.md#v3tradingopenpendingorder) | **POST** /api/v3/trading/orders/pending | Place pending order
[**V3TradingUpdateMarketOrder**](TradingApi.md#v3tradingupdatemarketorder) | **PUT** /api/v3/trading/orders/market | Change takeprofit or stoploss of position
[**V3TradingUpdateOrder**](TradingApi.md#v3tradingupdateorder) | **PUT** /api/v3/trading/orders/pending | Modify pending order.


<a name="v3tradingcloseallbysymbol"></a>
# **V3TradingCloseAllBySymbol**
> void V3TradingCloseAllBySymbol (CloseAllBySymbolModel closeAllBySymbolModel)

Clear position on symbol.

Closes all positions opened on specified symbol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingCloseAllBySymbolExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var closeAllBySymbolModel = new CloseAllBySymbolModel(); // CloseAllBySymbolModel | 

            try
            {
                // Clear position on symbol.
                apiInstance.V3TradingCloseAllBySymbol(closeAllBySymbolModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingCloseAllBySymbol: " + e.Message );
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
 **closeAllBySymbolModel** | [**CloseAllBySymbolModel**](CloseAllBySymbolModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingclosemany"></a>
# **V3TradingCloseMany**
> void V3TradingCloseMany (CloseManyModel closeManyModel)

Close multiple positions.

Close selected positions on single symbol.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingCloseManyExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var closeManyModel = new CloseManyModel(); // CloseManyModel | 

            try
            {
                // Close multiple positions.
                apiInstance.V3TradingCloseMany(closeManyModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingCloseMany: " + e.Message );
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
 **closeManyModel** | [**CloseManyModel**](CloseManyModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingclosemarketorder"></a>
# **V3TradingCloseMarketOrder**
> void V3TradingCloseMarketOrder (CloseMarketOrderModel closeMarketOrderModel)

Close single position.

Close selected position. Or patialy close this position by specified volume.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingCloseMarketOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var closeMarketOrderModel = new CloseMarketOrderModel(); // CloseMarketOrderModel | 

            try
            {
                // Close single position.
                apiInstance.V3TradingCloseMarketOrder(closeMarketOrderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingCloseMarketOrder: " + e.Message );
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
 **closeMarketOrderModel** | [**CloseMarketOrderModel**](CloseMarketOrderModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingdeletependingorder"></a>
# **V3TradingDeletePendingOrder**
> void V3TradingDeletePendingOrder (DeletePendingOrderModel deletePendingOrderModel)

Cancel pending order.

Cancel pending order that has not been activated yet.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingDeletePendingOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var deletePendingOrderModel = new DeletePendingOrderModel(); // DeletePendingOrderModel | 

            try
            {
                // Cancel pending order.
                apiInstance.V3TradingDeletePendingOrder(deletePendingOrderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingDeletePendingOrder: " + e.Message );
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
 **deletePendingOrderModel** | [**DeletePendingOrderModel**](DeletePendingOrderModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradinggetactiveorders"></a>
# **V3TradingGetActiveOrders**
> void V3TradingGetActiveOrders (InlineObject2 inlineObject2)

Get positions and pending orders.

Lists all active opened positions and active pending orders.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingGetActiveOrdersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var inlineObject2 = new InlineObject2(); // InlineObject2 | 

            try
            {
                // Get positions and pending orders.
                apiInstance.V3TradingGetActiveOrders(inlineObject2);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingGetActiveOrders: " + e.Message );
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
 **inlineObject2** | [**InlineObject2**](InlineObject2.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradinggethistoryorders"></a>
# **V3TradingGetHistoryOrders**
> void V3TradingGetHistoryOrders (InlineObject3 inlineObject3)

Get closed/inactive orders and positions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingGetHistoryOrdersExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var inlineObject3 = new InlineObject3(); // InlineObject3 | 

            try
            {
                // Get closed/inactive orders and positions.
                apiInstance.V3TradingGetHistoryOrders(inlineObject3);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingGetHistoryOrders: " + e.Message );
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
 **inlineObject3** | [**InlineObject3**](InlineObject3.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingopenmarketorder"></a>
# **V3TradingOpenMarketOrder**
> void V3TradingOpenMarketOrder (OpenMarketOrderModel openMarketOrderModel)

BUY or SELL by market price

Buy or sell assests now.   Depending on IsFIFO property, closes open positions with FIFO rule or opens a new - possibly hedged - position.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingOpenMarketOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var openMarketOrderModel = new OpenMarketOrderModel(); // OpenMarketOrderModel | 

            try
            {
                // BUY or SELL by market price
                apiInstance.V3TradingOpenMarketOrder(openMarketOrderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingOpenMarketOrder: " + e.Message );
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
 **openMarketOrderModel** | [**OpenMarketOrderModel**](OpenMarketOrderModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingopenpendingorder"></a>
# **V3TradingOpenPendingOrder**
> void V3TradingOpenPendingOrder (OpenPendingOrderModel openPendingOrderModel)

Place pending order

Place an order activated when price reaches @ActivationPrice.   <br />When @Instrument price reaches @ActivationPrice the order is imiedietly executed on market price.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingOpenPendingOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var openPendingOrderModel = new OpenPendingOrderModel(); // OpenPendingOrderModel | 

            try
            {
                // Place pending order
                apiInstance.V3TradingOpenPendingOrder(openPendingOrderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingOpenPendingOrder: " + e.Message );
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
 **openPendingOrderModel** | [**OpenPendingOrderModel**](OpenPendingOrderModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingupdatemarketorder"></a>
# **V3TradingUpdateMarketOrder**
> InlineResponse2004 V3TradingUpdateMarketOrder (InlineObject1 inlineObject1)

Change takeprofit or stoploss of position

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingUpdateMarketOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var inlineObject1 = new InlineObject1(); // InlineObject1 | 

            try
            {
                // Change takeprofit or stoploss of position
                InlineResponse2004 result = apiInstance.V3TradingUpdateMarketOrder(inlineObject1);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingUpdateMarketOrder: " + e.Message );
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
 **inlineObject1** | [**InlineObject1**](InlineObject1.md)|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v3tradingupdateorder"></a>
# **V3TradingUpdateOrder**
> void V3TradingUpdateOrder (UpdateOrderModel updateOrderModel)

Modify pending order.

Change parameters of this order

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleFx.Client.Generated.Api;
using SimpleFx.Client.Generated.Client;
using SimpleFx.Client.Generated.Model;

namespace Example
{
    public class V3TradingUpdateOrderExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://rest.simplefx.com";
            // Configure HTTP basic authorization: bearerAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new TradingApi(Configuration.Default);
            var updateOrderModel = new UpdateOrderModel(); // UpdateOrderModel | 

            try
            {
                // Modify pending order.
                apiInstance.V3TradingUpdateOrder(updateOrderModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingApi.V3TradingUpdateOrder: " + e.Message );
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
 **updateOrderModel** | [**UpdateOrderModel**](UpdateOrderModel.md)|  | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

