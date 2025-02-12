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
    /// Defines the query parameters that can be included in a request to the ListAdditionalRecipientReceivables endpoint.
    /// </summary>
    [DataContract]
    public partial class ListAdditionalRecipientReceivablesRequest :  IEquatable<ListAdditionalRecipientReceivablesRequest>, IValidatableObject
    {
        /// <summary>
        /// The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` See [SortOrder](#type-sortorder) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortOrderEnum
        {
            
            /// <summary>
            /// Enum DESC for "DESC"
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC,
            
            /// <summary>
            /// Enum ASC for "ASC"
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC
        }

        /// <summary>
        /// The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` See [SortOrder](#type-sortorder) for possible values
        /// </summary>
        /// <value>The order in which results are listed in the response (`ASC` for oldest first, `DESC` for newest first).  Default value: `DESC` See [SortOrder](#type-sortorder) for possible values</value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListAdditionalRecipientReceivablesRequest" /> class.
        /// </summary>
        /// <param name="BeginTime">The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year..</param>
        /// <param name="EndTime">The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time..</param>
        /// <param name="SortOrder">The order in which results are listed in the response (&#x60;ASC&#x60; for oldest first, &#x60;DESC&#x60; for newest first).  Default value: &#x60;DESC&#x60; See [SortOrder](#type-sortorder) for possible values.</param>
        /// <param name="Cursor">A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Pagination](/basics/api101/pagination) for more information..</param>
        public ListAdditionalRecipientReceivablesRequest(string BeginTime = default(string), string EndTime = default(string), SortOrderEnum? SortOrder = default(SortOrderEnum?), string Cursor = default(string))
        {
            this.BeginTime = BeginTime;
            this.EndTime = EndTime;
            this.SortOrder = SortOrder;
            this.Cursor = Cursor;
        }
        
        /// <summary>
        /// The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year.
        /// </summary>
        /// <value>The beginning of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time minus one year.</value>
        [DataMember(Name="begin_time", EmitDefaultValue=false)]
        public string BeginTime { get; set; }
        /// <summary>
        /// The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time.
        /// </summary>
        /// <value>The end of the requested reporting period, in RFC 3339 format.  See [Date ranges](#dateranges) for details on date inclusivity/exclusivity.  Default value: The current time.</value>
        [DataMember(Name="end_time", EmitDefaultValue=false)]
        public string EndTime { get; set; }
        /// <summary>
        /// A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Pagination](/basics/api101/pagination) for more information.
        /// </summary>
        /// <value>A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for your original query.  See [Pagination](/basics/api101/pagination) for more information.</value>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public string Cursor { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAdditionalRecipientReceivablesRequest {\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
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
            return this.Equals(obj as ListAdditionalRecipientReceivablesRequest);
        }

        /// <summary>
        /// Returns true if ListAdditionalRecipientReceivablesRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ListAdditionalRecipientReceivablesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListAdditionalRecipientReceivablesRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BeginTime == other.BeginTime ||
                    this.BeginTime != null &&
                    this.BeginTime.Equals(other.BeginTime)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.SortOrder == other.SortOrder ||
                    this.SortOrder != null &&
                    this.SortOrder.Equals(other.SortOrder)
                ) && 
                (
                    this.Cursor == other.Cursor ||
                    this.Cursor != null &&
                    this.Cursor.Equals(other.Cursor)
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
                if (this.BeginTime != null)
                    hash = hash * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.SortOrder != null)
                    hash = hash * 59 + this.SortOrder.GetHashCode();
                if (this.Cursor != null)
                    hash = hash * 59 + this.Cursor.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
