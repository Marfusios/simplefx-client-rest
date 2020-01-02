# SimpleFx.Client.Generated.Model.PendingOrder
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
**ActivationPrice** | [**ModelDecimal**](ModelDecimal.md) | price at which this order executes at market | 
**Direction** | **Direction** |  | 
**CreateTime** | **decimal** | Unix time in miliseconds. | 
**ExpiryTime** | **decimal** | Miliseconds since eopch, when this order ewill be automaticly removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

