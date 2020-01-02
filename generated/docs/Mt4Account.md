# SimpleFx.Client.Generated.Model.Mt4Account
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | [**ModelDecimal**](ModelDecimal.md) | Current account balance. | 
**Equity** | [**ModelDecimal**](ModelDecimal.md) | Balance + profit of opened positions. Depends on current market price. | 
**Margin** | [**ModelDecimal**](ModelDecimal.md) | Amount blocked for opened positions. | 
**FreeMargin** | [**ModelDecimal**](ModelDecimal.md) | Equity - margin, amount free for opening new positions. | 
**MarginLevel** | **double** | Margin level in percentage. Margin level of 100 mean all positions are covered, but there is no free margin for new positions. | 
**Reality** | **Reality** |  | 
**Login** | **int** | Corseponding Account | 
**Currency** | **string** |  | [optional] 
**Leverage** | **int** | Leverage multiplier | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

