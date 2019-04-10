# Square.Connect.Model.RetrieveEmployeeResponse

### Description

Defines the fields that are included in the response body of a request to the RetrieveEmployee endpoint.  One of `errors` or `employee` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Employee** | [**Employee**](Employee.md) | The response object. | [optional] 
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

