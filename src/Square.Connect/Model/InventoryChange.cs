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
    /// Represents a single physical count, inventory, adjustment, or transfer that is part of the history of inventory changes for a particular [CatalogObject](#type-catalogobject).
    /// </summary>
    [DataContract]
    public partial class InventoryChange :  IEquatable<InventoryChange>, IValidatableObject
    {
        /// <summary>
        /// Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for possible values
        /// </summary>
        /// <value>Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum PHYSICALCOUNT for "PHYSICAL_COUNT"
            /// </summary>
            [EnumMember(Value = "PHYSICAL_COUNT")]
            PHYSICALCOUNT,
            
            /// <summary>
            /// Enum ADJUSTMENT for "ADJUSTMENT"
            /// </summary>
            [EnumMember(Value = "ADJUSTMENT")]
            ADJUSTMENT,
            
            /// <summary>
            /// Enum TRANSFER for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            TRANSFER
        }

        /// <summary>
        /// Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for possible values
        /// </summary>
        /// <value>Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for possible values</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryChange" /> class.
        /// </summary>
        /// <param name="Type">Indicates how the inventory change was applied. See [InventoryChangeType](#type-inventorychangetype) for possible values.</param>
        /// <param name="PhysicalCount">Contains details about the physical count when &#x60;type&#x60; is &#x60;PHYSICAL_COUNT&#x60; and unset for all other types..</param>
        /// <param name="Adjustment">Contains details about the inventory adjustment when &#x60;type&#x60; is &#x60;ADJUSTMENT&#x60; and unset for all other types..</param>
        /// <param name="Transfer">Contains details about the inventory transfer when &#x60;type&#x60; is &#x60;TRANSFER&#x60; and unset for all other types..</param>
        public InventoryChange(TypeEnum? Type = default(TypeEnum?), InventoryPhysicalCount PhysicalCount = default(InventoryPhysicalCount), InventoryAdjustment Adjustment = default(InventoryAdjustment), InventoryTransfer Transfer = default(InventoryTransfer))
        {
            this.Type = Type;
            this.PhysicalCount = PhysicalCount;
            this.Adjustment = Adjustment;
            this.Transfer = Transfer;
        }
        
        /// <summary>
        /// Contains details about the physical count when &#x60;type&#x60; is &#x60;PHYSICAL_COUNT&#x60; and unset for all other types.
        /// </summary>
        /// <value>Contains details about the physical count when &#x60;type&#x60; is &#x60;PHYSICAL_COUNT&#x60; and unset for all other types.</value>
        [DataMember(Name="physical_count", EmitDefaultValue=false)]
        public InventoryPhysicalCount PhysicalCount { get; set; }
        /// <summary>
        /// Contains details about the inventory adjustment when &#x60;type&#x60; is &#x60;ADJUSTMENT&#x60; and unset for all other types.
        /// </summary>
        /// <value>Contains details about the inventory adjustment when &#x60;type&#x60; is &#x60;ADJUSTMENT&#x60; and unset for all other types.</value>
        [DataMember(Name="adjustment", EmitDefaultValue=false)]
        public InventoryAdjustment Adjustment { get; set; }
        /// <summary>
        /// Contains details about the inventory transfer when &#x60;type&#x60; is &#x60;TRANSFER&#x60; and unset for all other types.
        /// </summary>
        /// <value>Contains details about the inventory transfer when &#x60;type&#x60; is &#x60;TRANSFER&#x60; and unset for all other types.</value>
        [DataMember(Name="transfer", EmitDefaultValue=false)]
        public InventoryTransfer Transfer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryChange {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PhysicalCount: ").Append(PhysicalCount).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
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
            return this.Equals(obj as InventoryChange);
        }

        /// <summary>
        /// Returns true if InventoryChange instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.PhysicalCount == other.PhysicalCount ||
                    this.PhysicalCount != null &&
                    this.PhysicalCount.Equals(other.PhysicalCount)
                ) && 
                (
                    this.Adjustment == other.Adjustment ||
                    this.Adjustment != null &&
                    this.Adjustment.Equals(other.Adjustment)
                ) && 
                (
                    this.Transfer == other.Transfer ||
                    this.Transfer != null &&
                    this.Transfer.Equals(other.Transfer)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.PhysicalCount != null)
                    hash = hash * 59 + this.PhysicalCount.GetHashCode();
                if (this.Adjustment != null)
                    hash = hash * 59 + this.Adjustment.GetHashCode();
                if (this.Transfer != null)
                    hash = hash * 59 + this.Transfer.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
