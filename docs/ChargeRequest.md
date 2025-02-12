# Square.Connect.Model.ChargeRequest

### Description

Defines the parameters that can be included in the body of a request to the Charge endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdempotencyKey** | **string** | A value you specify that uniquely identifies this transaction among transactions you&#39;ve created.  If you&#39;re unsure whether a particular transaction succeeded, you can reattempt it with the same idempotency key without worrying about double-charging the buyer.  See [Idempotency](/basics/api101/idempotency) for more information. | 
**AmountMoney** | [**Money**](Money.md) | The amount of money to charge.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  The value of &#x60;currency&#x60; must match the currency associated with the business that is charging the card. | 
**CardNonce** | **string** | A nonce generated from the &#x60;SqPaymentForm&#x60; that represents the card to charge.  The application that provides a nonce to this endpoint must be the _same application_ that generated the nonce with the &#x60;SqPaymentForm&#x60;. Otherwise, the nonce is invalid.  Do not provide a value for this field if you provide a value for &#x60;customer_card_id&#x60;. | [optional] 
**CustomerCardId** | **string** | The ID of the customer card on file to charge. Do not provide a value for this field if you provide a value for &#x60;card_nonce&#x60;.  If you provide this value, you _must_ also provide a value for &#x60;customer_id&#x60;. | [optional] 
**DelayCapture** | **bool?** | If &#x60;true&#x60;, the request will only perform an Auth on the provided card. You can then later perform either a Capture (with the [CaptureTransaction](#endpoint-capturetransaction) endpoint) or a Void (with the [VoidTransaction](#endpoint-voidtransaction) endpoint).  Default value: &#x60;false&#x60; | [optional] 
**ReferenceId** | **string** | An optional ID you can associate with the transaction for your own purposes (such as to associate the transaction with an entity ID in your own database).  This value cannot exceed 40 characters. | [optional] 
**Note** | **string** |  | [optional] 
**CustomerId** | **string** | The ID of the customer to associate this transaction with. This field is required if you provide a value for &#x60;customer_card_id&#x60;, and optional otherwise. | [optional] 
**BillingAddress** | [**Address**](Address.md) | The buyer&#39;s billing address. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;shipping_address&#x60; is provided. | [optional] 
**ShippingAddress** | [**Address**](Address.md) | The buyer&#39;s shipping address, if available. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;billing_address&#x60; is provided. | [optional] 
**BuyerEmailAddress** | **string** | The buyer&#39;s email address, if available. This value is optional, but this transaction is ineligible for chargeback protection if it is not provided. | [optional] 
**OrderId** | **string** | The ID of the order to associate with this transaction.  If you provide this value, the &#x60;amount_money&#x60; value of your request must __exactly match__ the value of the order&#39;s &#x60;total_money&#x60; field. | [optional] 
**AdditionalRecipients** | [**List&lt;AdditionalRecipient&gt;**](AdditionalRecipient.md) | The basic primitive of multi-party transaction. The value is optional. The transaction facilitated by you can be split from here.  If you provide this value, the &#x60;amount_money&#x60; value in your additional_recipients must not be more than 90% of the &#x60;amount_money&#x60; value in the charge request. The &#x60;location_id&#x60; must be the valid location of the app owner merchant.  This field requires the &#x60;PAYMENTS_WRITE_ADDITIONAL_RECIPIENTS&#x60; OAuth permission.  This field is currently not supported in sandbox. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

