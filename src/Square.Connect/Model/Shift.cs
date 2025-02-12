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
    /// A record of the hourly rate, start, and end times for a single work shift  for an employee. May include a record of the start and end times for breaks  taken during the shift.
    /// </summary>
    [DataContract]
    public partial class Shift :  IEquatable<Shift>, IValidatableObject
    {
        /// <summary>
        /// Describes working state of the current `Shift`. See [ShiftStatus](#type-shiftstatus) for possible values
        /// </summary>
        /// <value>Describes working state of the current `Shift`. See [ShiftStatus](#type-shiftstatus) for possible values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum CLOSED for "CLOSED"
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED
        }

        /// <summary>
        /// Describes working state of the current `Shift`. See [ShiftStatus](#type-shiftstatus) for possible values
        /// </summary>
        /// <value>Describes working state of the current `Shift`. See [ShiftStatus](#type-shiftstatus) for possible values</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shift" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Shift() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Shift" /> class.
        /// </summary>
        /// <param name="Id">UUID for this object.</param>
        /// <param name="EmployeeId">The ID of the employee this shift belongs to. (required).</param>
        /// <param name="LocationId">The ID of the location this shift occurred at. Should be based on where the employee clocked in..</param>
        /// <param name="Timezone">Read-only convenience value that is calculated from the location based on &#x60;location_id&#x60;. Format: the IANA Timezone Database identifier for the location timezone..</param>
        /// <param name="StartAt">RFC 3339; shifted to location timezone + offset. Precision up to the minute is respected; seconds are truncated. (required).</param>
        /// <param name="EndAt">RFC 3339; shifted to timezone + offset. Precision up to the minute is respected; seconds are truncated. The &#x60;end_at&#x60; minute is not counted when the shift length is calculated. For example, a shift from &#x60;00:00&#x60; to &#x60;08:01&#x60; is considered an 8 hour shift (midnight to 8am)..</param>
        /// <param name="Wage">Job and pay related information..</param>
        /// <param name="Breaks">A list of any paid or unpaid breaks that were taken during this shift..</param>
        /// <param name="Status">Describes working state of the current &#x60;Shift&#x60;. See [ShiftStatus](#type-shiftstatus) for possible values.</param>
        /// <param name="Version">Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If not provided, Square executes a blind write; potentially overwriting data from another write..</param>
        /// <param name="CreatedAt">A read-only timestamp in RFC 3339 format; presented in UTC..</param>
        /// <param name="UpdatedAt">A read-only timestamp in RFC 3339 format; presented in UTC..</param>
        public Shift(string Id = default(string), string EmployeeId = default(string), string LocationId = default(string), string Timezone = default(string), string StartAt = default(string), string EndAt = default(string), ShiftWage Wage = default(ShiftWage), List<ModelBreak> Breaks = default(List<ModelBreak>), StatusEnum? Status = default(StatusEnum?), int? Version = default(int?), string CreatedAt = default(string), string UpdatedAt = default(string))
        {
            // to ensure "EmployeeId" is required (not null)
            if (EmployeeId == null)
            {
                throw new InvalidDataException("EmployeeId is a required property for Shift and cannot be null");
            }
            else
            {
                this.EmployeeId = EmployeeId;
            }
            // to ensure "StartAt" is required (not null)
            if (StartAt == null)
            {
                throw new InvalidDataException("StartAt is a required property for Shift and cannot be null");
            }
            else
            {
                this.StartAt = StartAt;
            }
            this.Id = Id;
            this.LocationId = LocationId;
            this.Timezone = Timezone;
            this.EndAt = EndAt;
            this.Wage = Wage;
            this.Breaks = Breaks;
            this.Status = Status;
            this.Version = Version;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }
        
        /// <summary>
        /// UUID for this object
        /// </summary>
        /// <value>UUID for this object</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the employee this shift belongs to.
        /// </summary>
        /// <value>The ID of the employee this shift belongs to.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// The ID of the location this shift occurred at. Should be based on where the employee clocked in.
        /// </summary>
        /// <value>The ID of the location this shift occurred at. Should be based on where the employee clocked in.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// Read-only convenience value that is calculated from the location based on &#x60;location_id&#x60;. Format: the IANA Timezone Database identifier for the location timezone.
        /// </summary>
        /// <value>Read-only convenience value that is calculated from the location based on &#x60;location_id&#x60;. Format: the IANA Timezone Database identifier for the location timezone.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        /// <summary>
        /// RFC 3339; shifted to location timezone + offset. Precision up to the minute is respected; seconds are truncated.
        /// </summary>
        /// <value>RFC 3339; shifted to location timezone + offset. Precision up to the minute is respected; seconds are truncated.</value>
        [DataMember(Name="start_at", EmitDefaultValue=false)]
        public string StartAt { get; set; }
        /// <summary>
        /// RFC 3339; shifted to timezone + offset. Precision up to the minute is respected; seconds are truncated. The &#x60;end_at&#x60; minute is not counted when the shift length is calculated. For example, a shift from &#x60;00:00&#x60; to &#x60;08:01&#x60; is considered an 8 hour shift (midnight to 8am).
        /// </summary>
        /// <value>RFC 3339; shifted to timezone + offset. Precision up to the minute is respected; seconds are truncated. The &#x60;end_at&#x60; minute is not counted when the shift length is calculated. For example, a shift from &#x60;00:00&#x60; to &#x60;08:01&#x60; is considered an 8 hour shift (midnight to 8am).</value>
        [DataMember(Name="end_at", EmitDefaultValue=false)]
        public string EndAt { get; set; }
        /// <summary>
        /// Job and pay related information.
        /// </summary>
        /// <value>Job and pay related information.</value>
        [DataMember(Name="wage", EmitDefaultValue=false)]
        public ShiftWage Wage { get; set; }
        /// <summary>
        /// A list of any paid or unpaid breaks that were taken during this shift.
        /// </summary>
        /// <value>A list of any paid or unpaid breaks that were taken during this shift.</value>
        [DataMember(Name="breaks", EmitDefaultValue=false)]
        public List<ModelBreak> Breaks { get; set; }
        /// <summary>
        /// Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If not provided, Square executes a blind write; potentially overwriting data from another write.
        /// </summary>
        /// <value>Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If not provided, Square executes a blind write; potentially overwriting data from another write.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// A read-only timestamp in RFC 3339 format; presented in UTC.
        /// </summary>
        /// <value>A read-only timestamp in RFC 3339 format; presented in UTC.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// A read-only timestamp in RFC 3339 format; presented in UTC.
        /// </summary>
        /// <value>A read-only timestamp in RFC 3339 format; presented in UTC.</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shift {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartAt: ").Append(StartAt).Append("\n");
            sb.Append("  EndAt: ").Append(EndAt).Append("\n");
            sb.Append("  Wage: ").Append(Wage).Append("\n");
            sb.Append("  Breaks: ").Append(Breaks).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as Shift);
        }

        /// <summary>
        /// Returns true if Shift instances are equal
        /// </summary>
        /// <param name="other">Instance of Shift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Shift other)
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
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartAt == other.StartAt ||
                    this.StartAt != null &&
                    this.StartAt.Equals(other.StartAt)
                ) && 
                (
                    this.EndAt == other.EndAt ||
                    this.EndAt != null &&
                    this.EndAt.Equals(other.EndAt)
                ) && 
                (
                    this.Wage == other.Wage ||
                    this.Wage != null &&
                    this.Wage.Equals(other.Wage)
                ) && 
                (
                    this.Breaks == other.Breaks ||
                    this.Breaks != null &&
                    this.Breaks.SequenceEqual(other.Breaks)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartAt != null)
                    hash = hash * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null)
                    hash = hash * 59 + this.EndAt.GetHashCode();
                if (this.Wage != null)
                    hash = hash * 59 + this.Wage.GetHashCode();
                if (this.Breaks != null)
                    hash = hash * 59 + this.Breaks.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Id (string) maxLength
            if(this.Id != null && this.Id.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Id, length must be less than 255.", new [] { "Id" });
            }

            // EmployeeId (string) minLength
            if(this.EmployeeId != null && this.EmployeeId.Length < 1)
            {
                yield return new ValidationResult("Invalid value for EmployeeId, length must be greater than 1.", new [] { "EmployeeId" });
            }

            // StartAt (string) minLength
            if(this.StartAt != null && this.StartAt.Length < 1)
            {
                yield return new ValidationResult("Invalid value for StartAt, length must be greater than 1.", new [] { "StartAt" });
            }

            yield break;
        }
    }

}
