# SimpleFx.Client.Generated.Model.InlineResponse2001
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Symbol** | **string** | Instrument symbol (ticker) | [optional] 
**PriceCurrency** | **string** | Currency in which this instrument is quoted. | [optional] 
**MarginCurrency** | **string** | Currency in which this instrument is valued. | [optional] 
**Quote** | [**UtilsInstrumentsJsonQuote**](UtilsInstrumentsJsonQuote.md) |  | [optional] 
**MarginPercentage** | **double** | Margin requirments for this instrument.   Required margin for transaciton is PRICE*marginPercentage/100*volume*contractSize/account.leverage | [optional] 
**ContractSize** | **double** | Size of transaciton with volume of 1 aka Multiplier. | [optional] 
**Step** | **double** | Allowed volume trading precision and minimum transaciton size for this instrument. | [optional] 
**MaxSize** | **double** | Maximum trading volume for single request. | [optional] 
**LongOnly** | **bool** | If only long positions (BUY) are allowed for this symbol. | [optional] 
**Sessions** | [**List&lt;UtilsInstrumentsJsonSessions&gt;**](UtilsInstrumentsJsonSessions.md) | Trade sessions describes time when this instrument is tradable | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

