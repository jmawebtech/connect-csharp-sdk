# Square.Connect.Model.OrderFulfillment

### Description

Contains details on how to fulfill this order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TypeEnum** | The type of the fulfillment. See [OrderFulfillmentType](#type-orderfulfillmenttype) for possible values | [optional] 
**State** | **StateEnum** | The state of the fulfillment. See [OrderFulfillmentState](#type-orderfulfillmentstate) for possible values | [optional] 
**PickupDetails** | [**OrderFulfillmentPickupDetails**](OrderFulfillmentPickupDetails.md) | Contains pickup-specific details. Required when fulfillment type is &#x60;PICKUP&#x60;. | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**PICKUP** | "PICKUP"


## StateEnum

Name | Value
------------ | -------------
**PROPOSED** | "PROPOSED"
**RESERVED** | "RESERVED"
**PREPARED** | "PREPARED"
**COMPLETED** | "COMPLETED"
**CANCELED** | "CANCELED"
**FAILED** | "FAILED"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

