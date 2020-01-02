# SimpleFx.Client.Generated.Model.MarketOrder
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ModelDecimal**](ModelDecimal.md) | Id of this position. | 
**Symbol** | **string** | Instrument symbol (ticker) | 
**Reality** | **Reality** |  | 
**Login** | **int** | Corseponding Account | 
**Side** | **Side** |  | 
**Volume** | **double** |  | 
**TakeProfit** | **double** |  | [optional] 
**StopLoss** | **double** |  | [optional] 
**Comment** | **string** |  | [optional] 
**CloseTime** | **decimal** | Epoch milisesonds. This field indicates that position is already closed. | [optional] 
**OpenTime** | [**ModelDecimal**](ModelDecimal.md) | unixtimestamp in miliseconds | 
**OpenPrice** | [**ModelDecimal**](ModelDecimal.md) |  | 
**Margin** | **double** | Balance blocked for this position. | 
**Profit** | **double** | current profit/loss from this position. | 
**Swaps** | **double** | Overnight maintence of this position. | 
**OpenConversionRate** | **double** | Convertion rate from position currency to account currency | 
**CloseConversionRate** | **double** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

