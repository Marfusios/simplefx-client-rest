# SimpleFx.Client.Generated.Model.AccountStatus
Static balance and floating equity.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Balance** | [**ModelDecimal**](ModelDecimal.md) | Current account balance. | [optional] 
**Equity** | [**ModelDecimal**](ModelDecimal.md) | Balance + profit of opened positions. Depends on current market price. | [optional] 
**Margin** | [**ModelDecimal**](ModelDecimal.md) | Amount blocked for opened positions. | [optional] 
**FreeMargin** | [**ModelDecimal**](ModelDecimal.md) | Equity - margin, amount free for opening new positions. | [optional] 
**MarginLevel** | **double** | Margin level in percentage. Margin level of 100 mean all positions are covered, but there is no free margin for new positions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

