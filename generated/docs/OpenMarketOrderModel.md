# SimpleFx.Client.Generated.Model.OpenMarketOrderModel
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reality** | **Reality** |  | 
**Login** | **int** | Corseponding Account | 
**Symbol** | **string** |  | 
**Side** | **Side** |  | 
**Volume** | **double** |  | 
**IsFIFO** | **bool** | FIFO requests closes opposite positions before opening new one. NonFIFO order will open new position regardles if client owns opposite position. | 
**TakeProfit** | **double** |  | [optional] 
**StopLoss** | **double** |  | [optional] 
**RequestId** | **string** | Client defined requestId. Server wiil populate this id in response and trade events. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

