# Square.Connect.Model.Error

### Description

Represents an error encountered during a request to the Connect API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Category** | **CategoryEnum** | The error&#39;s high-level category. See [ErrorCategory](#type-errorcategory) for possible values | 
**Code** | **CodeEnum** | The error&#39;s specific code. See [ErrorCode](#type-errorcode) for possible values | 
**Detail** | **string** | A human-readable description of the error for debugging purposes. | [optional] 
**Field** | **string** | The name of the field provided in the original request that the error pertains to, if any. | [optional] 


## CategoryEnum

Name | Value
------------ | -------------
**APIERROR** | "API_ERROR"
**AUTHENTICATIONERROR** | "AUTHENTICATION_ERROR"
**INVALIDREQUESTERROR** | "INVALID_REQUEST_ERROR"
**RATELIMITERROR** | "RATE_LIMIT_ERROR"
**PAYMENTMETHODERROR** | "PAYMENT_METHOD_ERROR"
**REFUNDERROR** | "REFUND_ERROR"


## CodeEnum

Name | Value
------------ | -------------
**INTERNALSERVERERROR** | "INTERNAL_SERVER_ERROR"
**UNAUTHORIZED** | "UNAUTHORIZED"
**ACCESSTOKENEXPIRED** | "ACCESS_TOKEN_EXPIRED"
**ACCESSTOKENREVOKED** | "ACCESS_TOKEN_REVOKED"
**FORBIDDEN** | "FORBIDDEN"
**INSUFFICIENTSCOPES** | "INSUFFICIENT_SCOPES"
**APPLICATIONDISABLED** | "APPLICATION_DISABLED"
**V1APPLICATION** | "V1_APPLICATION"
**V1ACCESSTOKEN** | "V1_ACCESS_TOKEN"
**CARDPROCESSINGNOTENABLED** | "CARD_PROCESSING_NOT_ENABLED"
**BADREQUEST** | "BAD_REQUEST"
**MISSINGREQUIREDPARAMETER** | "MISSING_REQUIRED_PARAMETER"
**INCORRECTTYPE** | "INCORRECT_TYPE"
**INVALIDTIME** | "INVALID_TIME"
**INVALIDTIMERANGE** | "INVALID_TIME_RANGE"
**INVALIDVALUE** | "INVALID_VALUE"
**INVALIDCURSOR** | "INVALID_CURSOR"
**UNKNOWNQUERYPARAMETER** | "UNKNOWN_QUERY_PARAMETER"
**CONFLICTINGPARAMETERS** | "CONFLICTING_PARAMETERS"
**EXPECTEDJSONBODY** | "EXPECTED_JSON_BODY"
**INVALIDSORTORDER** | "INVALID_SORT_ORDER"
**VALUEREGEXMISMATCH** | "VALUE_REGEX_MISMATCH"
**VALUETOOSHORT** | "VALUE_TOO_SHORT"
**VALUETOOLONG** | "VALUE_TOO_LONG"
**VALUETOOLOW** | "VALUE_TOO_LOW"
**VALUETOOHIGH** | "VALUE_TOO_HIGH"
**VALUEEMPTY** | "VALUE_EMPTY"
**ARRAYLENGTHTOOLONG** | "ARRAY_LENGTH_TOO_LONG"
**ARRAYLENGTHTOOSHORT** | "ARRAY_LENGTH_TOO_SHORT"
**ARRAYEMPTY** | "ARRAY_EMPTY"
**EXPECTEDBOOLEAN** | "EXPECTED_BOOLEAN"
**EXPECTEDINTEGER** | "EXPECTED_INTEGER"
**EXPECTEDFLOAT** | "EXPECTED_FLOAT"
**EXPECTEDSTRING** | "EXPECTED_STRING"
**EXPECTEDOBJECT** | "EXPECTED_OBJECT"
**EXPECTEDARRAY** | "EXPECTED_ARRAY"
**EXPECTEDMAP** | "EXPECTED_MAP"
**EXPECTEDBASE64ENCODEDBYTEARRAY** | "EXPECTED_BASE64_ENCODED_BYTE_ARRAY"
**INVALIDARRAYVALUE** | "INVALID_ARRAY_VALUE"
**INVALIDENUMVALUE** | "INVALID_ENUM_VALUE"
**INVALIDCONTENTTYPE** | "INVALID_CONTENT_TYPE"
**INVALIDFORMVALUE** | "INVALID_FORM_VALUE"
**ONEINSTRUMENTEXPECTED** | "ONE_INSTRUMENT_EXPECTED"
**NOFIELDSSET** | "NO_FIELDS_SET"
**DEPRECATEDFIELDSET** | "DEPRECATED_FIELD_SET"
**CARDEXPIRED** | "CARD_EXPIRED"
**INVALIDEXPIRATION** | "INVALID_EXPIRATION"
**INVALIDEXPIRATIONYEAR** | "INVALID_EXPIRATION_YEAR"
**INVALIDEXPIRATIONDATE** | "INVALID_EXPIRATION_DATE"
**UNSUPPORTEDCARDBRAND** | "UNSUPPORTED_CARD_BRAND"
**UNSUPPORTEDENTRYMETHOD** | "UNSUPPORTED_ENTRY_METHOD"
**INVALIDENCRYPTEDCARD** | "INVALID_ENCRYPTED_CARD"
**INVALIDCARD** | "INVALID_CARD"
**DELAYEDTRANSACTIONEXPIRED** | "DELAYED_TRANSACTION_EXPIRED"
**DELAYEDTRANSACTIONCANCELED** | "DELAYED_TRANSACTION_CANCELED"
**DELAYEDTRANSACTIONCAPTURED** | "DELAYED_TRANSACTION_CAPTURED"
**DELAYEDTRANSACTIONFAILED** | "DELAYED_TRANSACTION_FAILED"
**CARDTOKENEXPIRED** | "CARD_TOKEN_EXPIRED"
**CARDTOKENUSED** | "CARD_TOKEN_USED"
**AMOUNTTOOHIGH** | "AMOUNT_TOO_HIGH"
**UNSUPPORTEDINSTRUMENTTYPE** | "UNSUPPORTED_INSTRUMENT_TYPE"
**REFUNDAMOUNTINVALID** | "REFUND_AMOUNT_INVALID"
**REFUNDALREADYPENDING** | "REFUND_ALREADY_PENDING"
**PAYMENTNOTREFUNDABLE** | "PAYMENT_NOT_REFUNDABLE"
**INVALIDCARDDATA** | "INVALID_CARD_DATA"
**LOCATIONMISMATCH** | "LOCATION_MISMATCH"
**IDEMPOTENCYKEYREUSED** | "IDEMPOTENCY_KEY_REUSED"
**UNEXPECTEDVALUE** | "UNEXPECTED_VALUE"
**SANDBOXNOTSUPPORTED** | "SANDBOX_NOT_SUPPORTED"
**INVALIDEMAILADDRESS** | "INVALID_EMAIL_ADDRESS"
**INVALIDPHONENUMBER** | "INVALID_PHONE_NUMBER"
**CHECKOUTEXPIRED** | "CHECKOUT_EXPIRED"
**BADCERTIFICATE** | "BAD_CERTIFICATE"
**CARDDECLINED** | "CARD_DECLINED"
**VERIFYCVVFAILURE** | "VERIFY_CVV_FAILURE"
**VERIFYAVSFAILURE** | "VERIFY_AVS_FAILURE"
**CARDDECLINEDCALLISSUER** | "CARD_DECLINED_CALL_ISSUER"
**NOTFOUND** | "NOT_FOUND"
**APPLEPAYMENTPROCESSINGCERTIFICATEHASHNOTFOUND** | "APPLE_PAYMENT_PROCESSING_CERTIFICATE_HASH_NOT_FOUND"
**METHODNOTALLOWED** | "METHOD_NOT_ALLOWED"
**NOTACCEPTABLE** | "NOT_ACCEPTABLE"
**REQUESTTIMEOUT** | "REQUEST_TIMEOUT"
**CONFLICT** | "CONFLICT"
**REQUESTENTITYTOOLARGE** | "REQUEST_ENTITY_TOO_LARGE"
**UNSUPPORTEDMEDIATYPE** | "UNSUPPORTED_MEDIA_TYPE"
**RATELIMITED** | "RATE_LIMITED"
**NOTIMPLEMENTED** | "NOT_IMPLEMENTED"
**SERVICEUNAVAILABLE** | "SERVICE_UNAVAILABLE"
**GATEWAYTIMEOUT** | "GATEWAY_TIMEOUT"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

