/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Defines the parameters that can be included in the body of a request to the [Charge](#endpoint-charge) endpoint.
    /// </summary>
    [DataContract]
    public partial class ChargeRequest :  IEquatable<ChargeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this transaction among transactions you&#39;ve created.  If you&#39;re unsure whether a particular transaction succeeded, you can reattempt it with the same idempotency key without worrying about double-charging the buyer.  See [Idempotency keys](#idempotencykeys) for more information. (required).</param>
        /// <param name="AmountMoney">The amount of money to charge.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  The value of &#x60;currency&#x60; must match the currency associated with the business that is charging the card. (required).</param>
        /// <param name="CardNonce">A nonce generated from the &#x60;SqPaymentForm&#x60; that represents the card to charge.  The application that provides a nonce to this endpoint must be the _same application_ that generated the nonce with the &#x60;SqPaymentForm&#x60;. Otherwise, the nonce is invalid.  Do not provide a value for this field if you provide a value for &#x60;customer_card_id&#x60;..</param>
        /// <param name="CustomerCardId">The ID of the customer card on file to charge. Do not provide a value for this field if you provide a value for &#x60;card_nonce&#x60;.  If you provide this value, you _must_ also provide a value for &#x60;customer_id&#x60;..</param>
        /// <param name="DelayCapture">If &#x60;true&#x60;, the request will only perform an Auth on the provided card. You can then later perform either a Capture (with the [CaptureTransaction](#endpoint-capturetransaction) endpoint) or a Void (with the [VoidTransaction](#endpoint-voidtransaction) endpoint).  Default value: &#x60;false&#x60;.</param>
        /// <param name="ReferenceId">An optional ID you can associate with the transaction for your own purposes (such as to associate the transaction with an entity ID in your own database).  This value cannot exceed 40 characters..</param>
        /// <param name="Note">An optional note to associate with the transaction.  This value cannot exceed 60 characters..</param>
        /// <param name="CustomerId">The ID of the customer to associate this transaction with. This field is required if you provide a value for &#x60;customer_card_id&#x60;, and optional otherwise..</param>
        /// <param name="BillingAddress">The buyer&#39;s billing address. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;shipping_address&#x60; is provided..</param>
        /// <param name="ShippingAddress">The buyer&#39;s shipping address, if available. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;billing_address&#x60; is provided..</param>
        /// <param name="BuyerEmailAddress">The buyer&#39;s email address, if available. This value is optional, but this transaction is ineligible for chargeback protection if it is not provided..</param>
        /// <param name="OrderId">The ID of the order to associate with this transaction.  If you provide this value, the &#x60;amount_money&#x60; value of your request must __exactly match__ the &#x60;total_money&#x60; value of the order&#39;s &#x60;order_amounts&#x60; field..</param>
        public ChargeRequest(string IdempotencyKey = default(string), Money AmountMoney = default(Money), string CardNonce = default(string), string CustomerCardId = default(string), bool? DelayCapture = default(bool?), string ReferenceId = default(string), string Note = default(string), string CustomerId = default(string), Address BillingAddress = default(Address), Address ShippingAddress = default(Address), string BuyerEmailAddress = default(string), string OrderId = default(string))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for ChargeRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "AmountMoney" is required (not null)
            if (AmountMoney == null)
            {
                throw new InvalidDataException("AmountMoney is a required property for ChargeRequest and cannot be null");
            }
            else
            {
                this.AmountMoney = AmountMoney;
            }
            this.CardNonce = CardNonce;
            this.CustomerCardId = CustomerCardId;
            this.DelayCapture = DelayCapture;
            this.ReferenceId = ReferenceId;
            this.Note = Note;
            this.CustomerId = CustomerId;
            this.BillingAddress = BillingAddress;
            this.ShippingAddress = ShippingAddress;
            this.BuyerEmailAddress = BuyerEmailAddress;
            this.OrderId = OrderId;
        }
        
        /// <summary>
        /// A value you specify that uniquely identifies this transaction among transactions you&#39;ve created.  If you&#39;re unsure whether a particular transaction succeeded, you can reattempt it with the same idempotency key without worrying about double-charging the buyer.  See [Idempotency keys](#idempotencykeys) for more information.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this transaction among transactions you&#39;ve created.  If you&#39;re unsure whether a particular transaction succeeded, you can reattempt it with the same idempotency key without worrying about double-charging the buyer.  See [Idempotency keys](#idempotencykeys) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// The amount of money to charge.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  The value of &#x60;currency&#x60; must match the currency associated with the business that is charging the card.
        /// </summary>
        /// <value>The amount of money to charge.  Note that you specify the amount in the __smallest denomination of the applicable currency__. For example, US dollar amounts are specified in cents. See [Working with monetary amounts](#workingwithmonetaryamounts) for details.  The value of &#x60;currency&#x60; must match the currency associated with the business that is charging the card.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// A nonce generated from the &#x60;SqPaymentForm&#x60; that represents the card to charge.  The application that provides a nonce to this endpoint must be the _same application_ that generated the nonce with the &#x60;SqPaymentForm&#x60;. Otherwise, the nonce is invalid.  Do not provide a value for this field if you provide a value for &#x60;customer_card_id&#x60;.
        /// </summary>
        /// <value>A nonce generated from the &#x60;SqPaymentForm&#x60; that represents the card to charge.  The application that provides a nonce to this endpoint must be the _same application_ that generated the nonce with the &#x60;SqPaymentForm&#x60;. Otherwise, the nonce is invalid.  Do not provide a value for this field if you provide a value for &#x60;customer_card_id&#x60;.</value>
        [DataMember(Name="card_nonce", EmitDefaultValue=false)]
        public string CardNonce { get; set; }
        /// <summary>
        /// The ID of the customer card on file to charge. Do not provide a value for this field if you provide a value for &#x60;card_nonce&#x60;.  If you provide this value, you _must_ also provide a value for &#x60;customer_id&#x60;.
        /// </summary>
        /// <value>The ID of the customer card on file to charge. Do not provide a value for this field if you provide a value for &#x60;card_nonce&#x60;.  If you provide this value, you _must_ also provide a value for &#x60;customer_id&#x60;.</value>
        [DataMember(Name="customer_card_id", EmitDefaultValue=false)]
        public string CustomerCardId { get; set; }
        /// <summary>
        /// If &#x60;true&#x60;, the request will only perform an Auth on the provided card. You can then later perform either a Capture (with the [CaptureTransaction](#endpoint-capturetransaction) endpoint) or a Void (with the [VoidTransaction](#endpoint-voidtransaction) endpoint).  Default value: &#x60;false&#x60;
        /// </summary>
        /// <value>If &#x60;true&#x60;, the request will only perform an Auth on the provided card. You can then later perform either a Capture (with the [CaptureTransaction](#endpoint-capturetransaction) endpoint) or a Void (with the [VoidTransaction](#endpoint-voidtransaction) endpoint).  Default value: &#x60;false&#x60;</value>
        [DataMember(Name="delay_capture", EmitDefaultValue=false)]
        public bool? DelayCapture { get; set; }
        /// <summary>
        /// An optional ID you can associate with the transaction for your own purposes (such as to associate the transaction with an entity ID in your own database).  This value cannot exceed 40 characters.
        /// </summary>
        /// <value>An optional ID you can associate with the transaction for your own purposes (such as to associate the transaction with an entity ID in your own database).  This value cannot exceed 40 characters.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// An optional note to associate with the transaction.  This value cannot exceed 60 characters.
        /// </summary>
        /// <value>An optional note to associate with the transaction.  This value cannot exceed 60 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// The ID of the customer to associate this transaction with. This field is required if you provide a value for &#x60;customer_card_id&#x60;, and optional otherwise.
        /// </summary>
        /// <value>The ID of the customer to associate this transaction with. This field is required if you provide a value for &#x60;customer_card_id&#x60;, and optional otherwise.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// The buyer&#39;s billing address. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;shipping_address&#x60; is provided.
        /// </summary>
        /// <value>The buyer&#39;s billing address. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;shipping_address&#x60; is provided.</value>
        [DataMember(Name="billing_address", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
        /// <summary>
        /// The buyer&#39;s shipping address, if available. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;billing_address&#x60; is provided.
        /// </summary>
        /// <value>The buyer&#39;s shipping address, if available. This value is optional, but this transaction is ineligible for chargeback protection if neither this parameter nor &#x60;billing_address&#x60; is provided.</value>
        [DataMember(Name="shipping_address", EmitDefaultValue=false)]
        public Address ShippingAddress { get; set; }
        /// <summary>
        /// The buyer&#39;s email address, if available. This value is optional, but this transaction is ineligible for chargeback protection if it is not provided.
        /// </summary>
        /// <value>The buyer&#39;s email address, if available. This value is optional, but this transaction is ineligible for chargeback protection if it is not provided.</value>
        [DataMember(Name="buyer_email_address", EmitDefaultValue=false)]
        public string BuyerEmailAddress { get; set; }
        /// <summary>
        /// The ID of the order to associate with this transaction.  If you provide this value, the &#x60;amount_money&#x60; value of your request must __exactly match__ the &#x60;total_money&#x60; value of the order&#39;s &#x60;order_amounts&#x60; field.
        /// </summary>
        /// <value>The ID of the order to associate with this transaction.  If you provide this value, the &#x60;amount_money&#x60; value of your request must __exactly match__ the &#x60;total_money&#x60; value of the order&#39;s &#x60;order_amounts&#x60; field.</value>
        [DataMember(Name="order_id", EmitDefaultValue=false)]
        public string OrderId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChargeRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  CardNonce: ").Append(CardNonce).Append("\n");
            sb.Append("  CustomerCardId: ").Append(CustomerCardId).Append("\n");
            sb.Append("  DelayCapture: ").Append(DelayCapture).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  BuyerEmailAddress: ").Append(BuyerEmailAddress).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ChargeRequest);
        }

        /// <summary>
        /// Returns true if ChargeRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.CardNonce == other.CardNonce ||
                    this.CardNonce != null &&
                    this.CardNonce.Equals(other.CardNonce)
                ) && 
                (
                    this.CustomerCardId == other.CustomerCardId ||
                    this.CustomerCardId != null &&
                    this.CustomerCardId.Equals(other.CustomerCardId)
                ) && 
                (
                    this.DelayCapture == other.DelayCapture ||
                    this.DelayCapture != null &&
                    this.DelayCapture.Equals(other.DelayCapture)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.ShippingAddress == other.ShippingAddress ||
                    this.ShippingAddress != null &&
                    this.ShippingAddress.Equals(other.ShippingAddress)
                ) && 
                (
                    this.BuyerEmailAddress == other.BuyerEmailAddress ||
                    this.BuyerEmailAddress != null &&
                    this.BuyerEmailAddress.Equals(other.BuyerEmailAddress)
                ) && 
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.CardNonce != null)
                    hash = hash * 59 + this.CardNonce.GetHashCode();
                if (this.CustomerCardId != null)
                    hash = hash * 59 + this.CustomerCardId.GetHashCode();
                if (this.DelayCapture != null)
                    hash = hash * 59 + this.DelayCapture.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                if (this.ShippingAddress != null)
                    hash = hash * 59 + this.ShippingAddress.GetHashCode();
                if (this.BuyerEmailAddress != null)
                    hash = hash * 59 + this.BuyerEmailAddress.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) maxLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length > 192)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be less than 192.", new [] { "IdempotencyKey" });
            }

            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            // CardNonce (string) maxLength
            if(this.CardNonce != null && this.CardNonce.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CardNonce, length must be less than 192.", new [] { "CardNonce" });
            }

            // CustomerCardId (string) maxLength
            if(this.CustomerCardId != null && this.CustomerCardId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CustomerCardId, length must be less than 192.", new [] { "CustomerCardId" });
            }

            // ReferenceId (string) maxLength
            if(this.ReferenceId != null && this.ReferenceId.Length > 40)
            {
                yield return new ValidationResult("Invalid value for ReferenceId, length must be less than 40.", new [] { "ReferenceId" });
            }

            // Note (string) maxLength
            if(this.Note != null && this.Note.Length > 60)
            {
                yield return new ValidationResult("Invalid value for Note, length must be less than 60.", new [] { "Note" });
            }

            // CustomerId (string) maxLength
            if(this.CustomerId != null && this.CustomerId.Length > 50)
            {
                yield return new ValidationResult("Invalid value for CustomerId, length must be less than 50.", new [] { "CustomerId" });
            }

            // OrderId (string) maxLength
            if(this.OrderId != null && this.OrderId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for OrderId, length must be less than 192.", new [] { "OrderId" });
            }

            yield break;
        }
    }

}
