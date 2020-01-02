# SimpleFx.Client.Generated.Model.OpenPendingOrderModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivationPrice** | **double** | Stop price - when this order is activated | 
**ExpiryTime** | **long** | Miliseconds from unix epoch. Order is canceled at this time if it has not been activated yet | [optional] 
**Symbol** | **string** |  | 
**Volume** | **double** |  | 
**TakeProfit** | **double** |  | [optional] 
**StopLoss** | **double** |  | [optional] 
**Side** | **Side** |  | 
**RequestId** | **string** | Client defined requestId. Server wiil populate this id in response and trade events. | [optional] 
**Login** | **int** | Corseponding Account | 
**Reality** | **string** | Account LIVE or DEMO | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

