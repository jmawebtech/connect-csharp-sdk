# Square.Connect.Model.InventoryTransfer

### Description

Represents the transfer of a quantity of product inventory at a particular time from one location to another.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique ID generated by Square for the [InventoryTransfer](#type-inventorytransfer). | [optional] 
**ReferenceId** | **string** | An optional ID provided by the application to tie the [InventoryTransfer](#type-inventorytransfer) to an external system. | [optional] 
**State** | **StateEnum** | The [InventoryState](#type-inventorystate) for the quantity of items being transfered. See [InventoryState](#type-inventorystate) for possible values | [optional] 
**FromLocationId** | **string** | The Square ID of the [Location](#type-location) where the related quantity of items were tracked before the transfer. | [optional] 
**ToLocationId** | **string** | The Square ID of the [Location](#type-location) where the related quantity of items were tracked after the transfer. | [optional] 
**CatalogObjectId** | **string** | The Square generated ID of the [CatalogObject](#type-catalogobject) being tracked. | [optional] 
**CatalogObjectType** | **string** | The [CatalogObjectType](#type-catalogobjecttype) of the [CatalogObject](#type-catalogobject) being tracked.Tracking is only supported for the &#x60;ITEM_VARIATION&#x60; type. | [optional] 
**Quantity** | **string** | The number of items affected by the transfer as a decimal string. Fractional quantities are not supported. | [optional] 
**OccurredAt** | **string** | A client-generated timestamp in RFC 3339 format that indicates when the transfer took place. For write actions, the &#x60;occurred_at&#x60; timestamp cannot be older than 24 hours or in the future relative to the time of the request. | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format that indicates when Square received the transfer request. | [optional] 
**Source** | [**SourceApplication**](SourceApplication.md) | Read-only information about the application that initiated the inventory transfer. | [optional] 
**EmployeeId** | **string** | The Square ID of the [Employee](#type-employee) responsible for the inventory transfer. | [optional] 


## StateEnum

Name | Value
------------ | -------------
**CUSTOM** | "CUSTOM"
**INSTOCK** | "IN_STOCK"
**SOLD** | "SOLD"
**RETURNEDBYCUSTOMER** | "RETURNED_BY_CUSTOMER"
**RESERVEDFORSALE** | "RESERVED_FOR_SALE"
**SOLDONLINE** | "SOLD_ONLINE"
**ORDEREDFROMVENDOR** | "ORDERED_FROM_VENDOR"
**RECEIVEDFROMVENDOR** | "RECEIVED_FROM_VENDOR"
**INTRANSITTO** | "IN_TRANSIT_TO"
**NONE** | "NONE"
**WASTE** | "WASTE"
**UNLINKEDRETURN** | "UNLINKED_RETURN"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

