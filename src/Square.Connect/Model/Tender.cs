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
    /// Represents a tender (i.e., a method of payment) used in a Square transaction.
    /// </summary>
    [DataContract]
    public partial class Tender :  IEquatable<Tender>, IValidatableObject
    {
        /// <summary>
        /// The type of tender, such as `CARD` or `CASH`. See [TenderType](#type-tendertype) for possible values
        /// </summary>
        /// <value>The type of tender, such as `CARD` or `CASH`. See [TenderType](#type-tendertype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum CARD for "CARD"
            /// </summary>
            [EnumMember(Value = "CARD")]
            CARD,
            
            /// <summary>
            /// Enum CASH for "CASH"
            /// </summary>
            [EnumMember(Value = "CASH")]
            CASH,
            
            /// <summary>
            /// Enum THIRDPARTYCARD for "THIRD_PARTY_CARD"
            /// </summary>
            [EnumMember(Value = "THIRD_PARTY_CARD")]
            THIRDPARTYCARD,
            
            /// <summary>
            /// Enum SQUAREGIFTCARD for "SQUARE_GIFT_CARD"
            /// </summary>
            [EnumMember(Value = "SQUARE_GIFT_CARD")]
            SQUAREGIFTCARD,
            
            /// <summary>
            /// Enum NOSALE for "NO_SALE"
            /// </summary>
            [EnumMember(Value = "NO_SALE")]
            NOSALE,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// The type of tender, such as `CARD` or `CASH`. See [TenderType](#type-tendertype) for possible values
        /// </summary>
        /// <value>The type of tender, such as `CARD` or `CASH`. See [TenderType](#type-tendertype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tender" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Tender() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Tender" /> class.
        /// </summary>
        /// <param name="Id">The tender&#39;s unique ID..</param>
        /// <param name="LocationId">The ID of the transaction&#39;s associated location..</param>
        /// <param name="TransactionId">The ID of the tender&#39;s associated transaction..</param>
        /// <param name="CreatedAt">The time when the tender was created, in RFC 3339 format..</param>
        /// <param name="Note">An optional note associated with the tender at the time of payment..</param>
        /// <param name="AmountMoney">The amount of the tender..</param>
        /// <param name="TipMoney">The tip&#39;s amount of the tender..</param>
        /// <param name="ProcessingFeeMoney">The amount of any Square processing fees applied to the tender.  This field is not immediately populated when a new transaction is created. It is usually available after about ten seconds..</param>
        /// <param name="CustomerId">If the tender is associated with a customer or represents a customer&#39;s card on file, this is the ID of the associated customer..</param>
        /// <param name="Type">The type of tender, such as &#x60;CARD&#x60; or &#x60;CASH&#x60;. See [TenderType](#type-tendertype) for possible values (required).</param>
        /// <param name="CardDetails">The details of the card tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CARD&#x60;..</param>
        /// <param name="CashDetails">The details of the cash tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CASH&#x60;..</param>
        /// <param name="AdditionalRecipients">Additional recipients (other than the merchant) receiving a portion of this tender. For example, fees assessed on the purchase by a third party integration..</param>
        public Tender(string Id = default(string), string LocationId = default(string), string TransactionId = default(string), string CreatedAt = default(string), string Note = default(string), Money AmountMoney = default(Money), Money TipMoney = default(Money), Money ProcessingFeeMoney = default(Money), string CustomerId = default(string), TypeEnum? Type = default(TypeEnum?), TenderCardDetails CardDetails = default(TenderCardDetails), TenderCashDetails CashDetails = default(TenderCashDetails), List<AdditionalRecipient> AdditionalRecipients = default(List<AdditionalRecipient>))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Tender and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Id = Id;
            this.LocationId = LocationId;
            this.TransactionId = TransactionId;
            this.CreatedAt = CreatedAt;
            this.Note = Note;
            this.AmountMoney = AmountMoney;
            this.TipMoney = TipMoney;
            this.ProcessingFeeMoney = ProcessingFeeMoney;
            this.CustomerId = CustomerId;
            this.CardDetails = CardDetails;
            this.CashDetails = CashDetails;
            this.AdditionalRecipients = AdditionalRecipients;
        }
        
        /// <summary>
        /// The tender&#39;s unique ID.
        /// </summary>
        /// <value>The tender&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the transaction&#39;s associated location.
        /// </summary>
        /// <value>The ID of the transaction&#39;s associated location.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// The ID of the tender&#39;s associated transaction.
        /// </summary>
        /// <value>The ID of the tender&#39;s associated transaction.</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// The time when the tender was created, in RFC 3339 format.
        /// </summary>
        /// <value>The time when the tender was created, in RFC 3339 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// An optional note associated with the tender at the time of payment.
        /// </summary>
        /// <value>An optional note associated with the tender at the time of payment.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }
        /// <summary>
        /// The amount of the tender.
        /// </summary>
        /// <value>The amount of the tender.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// The tip&#39;s amount of the tender.
        /// </summary>
        /// <value>The tip&#39;s amount of the tender.</value>
        [DataMember(Name="tip_money", EmitDefaultValue=false)]
        public Money TipMoney { get; set; }
        /// <summary>
        /// The amount of any Square processing fees applied to the tender.  This field is not immediately populated when a new transaction is created. It is usually available after about ten seconds.
        /// </summary>
        /// <value>The amount of any Square processing fees applied to the tender.  This field is not immediately populated when a new transaction is created. It is usually available after about ten seconds.</value>
        [DataMember(Name="processing_fee_money", EmitDefaultValue=false)]
        public Money ProcessingFeeMoney { get; set; }
        /// <summary>
        /// If the tender is associated with a customer or represents a customer&#39;s card on file, this is the ID of the associated customer.
        /// </summary>
        /// <value>If the tender is associated with a customer or represents a customer&#39;s card on file, this is the ID of the associated customer.</value>
        [DataMember(Name="customer_id", EmitDefaultValue=false)]
        public string CustomerId { get; set; }
        /// <summary>
        /// The details of the card tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CARD&#x60;.
        /// </summary>
        /// <value>The details of the card tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CARD&#x60;.</value>
        [DataMember(Name="card_details", EmitDefaultValue=false)]
        public TenderCardDetails CardDetails { get; set; }
        /// <summary>
        /// The details of the cash tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CASH&#x60;.
        /// </summary>
        /// <value>The details of the cash tender.  This value is present only if the value of &#x60;type&#x60; is &#x60;CASH&#x60;.</value>
        [DataMember(Name="cash_details", EmitDefaultValue=false)]
        public TenderCashDetails CashDetails { get; set; }
        /// <summary>
        /// Additional recipients (other than the merchant) receiving a portion of this tender. For example, fees assessed on the purchase by a third party integration.
        /// </summary>
        /// <value>Additional recipients (other than the merchant) receiving a portion of this tender. For example, fees assessed on the purchase by a third party integration.</value>
        [DataMember(Name="additional_recipients", EmitDefaultValue=false)]
        public List<AdditionalRecipient> AdditionalRecipients { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tender {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
            sb.Append("  TipMoney: ").Append(TipMoney).Append("\n");
            sb.Append("  ProcessingFeeMoney: ").Append(ProcessingFeeMoney).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CardDetails: ").Append(CardDetails).Append("\n");
            sb.Append("  CashDetails: ").Append(CashDetails).Append("\n");
            sb.Append("  AdditionalRecipients: ").Append(AdditionalRecipients).Append("\n");
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
            return this.Equals(obj as Tender);
        }

        /// <summary>
        /// Returns true if Tender instances are equal
        /// </summary>
        /// <param name="other">Instance of Tender to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tender other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                ) && 
                (
                    this.TipMoney == other.TipMoney ||
                    this.TipMoney != null &&
                    this.TipMoney.Equals(other.TipMoney)
                ) && 
                (
                    this.ProcessingFeeMoney == other.ProcessingFeeMoney ||
                    this.ProcessingFeeMoney != null &&
                    this.ProcessingFeeMoney.Equals(other.ProcessingFeeMoney)
                ) && 
                (
                    this.CustomerId == other.CustomerId ||
                    this.CustomerId != null &&
                    this.CustomerId.Equals(other.CustomerId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CardDetails == other.CardDetails ||
                    this.CardDetails != null &&
                    this.CardDetails.Equals(other.CardDetails)
                ) && 
                (
                    this.CashDetails == other.CashDetails ||
                    this.CashDetails != null &&
                    this.CashDetails.Equals(other.CashDetails)
                ) && 
                (
                    this.AdditionalRecipients == other.AdditionalRecipients ||
                    this.AdditionalRecipients != null &&
                    this.AdditionalRecipients.SequenceEqual(other.AdditionalRecipients)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                if (this.TipMoney != null)
                    hash = hash * 59 + this.TipMoney.GetHashCode();
                if (this.ProcessingFeeMoney != null)
                    hash = hash * 59 + this.ProcessingFeeMoney.GetHashCode();
                if (this.CustomerId != null)
                    hash = hash * 59 + this.CustomerId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CardDetails != null)
                    hash = hash * 59 + this.CardDetails.GetHashCode();
                if (this.CashDetails != null)
                    hash = hash * 59 + this.CashDetails.GetHashCode();
                if (this.AdditionalRecipients != null)
                    hash = hash * 59 + this.AdditionalRecipients.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
