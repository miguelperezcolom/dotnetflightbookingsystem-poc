/*
 * AirGateway NDC JSON API
 *
 * This API allows shopping and booking with IATA's New Distribution Capabilities (NDC) standard. It provides aggregated shopping capabilities (AirShopping), detailed offer description (OfferPrice), flight seat selection (SeatAvailability) and booking flight reservations (OrderCreate). Some fields in our API (when noticed) use the PADIS Standard v16.1. Find more information <a href=http://www.iata.org/whatwedo/workgroups/Pages/padis.aspx>here</a>
 *
 * OpenAPI spec version: 1.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// Indicates if there is an optional, a mandatory or a not allowed text from the customer´s side depending in the MandatoryText attribute value.
    /// </summary>
    [DataContract]
    public partial class BookingInstructions : IEquatable<BookingInstructions>
    { 
        /// <summary>
        /// This attribute indicates the optional, mandatory or not allowed need for the text
        /// </summary>
        /// <value>This attribute indicates the optional, mandatory or not allowed need for the text</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MandatoryTextEnum
        {
            
            /// <summary>
            /// Enum NotAllowedEnum for not_allowed
            /// </summary>
            [EnumMember(Value = "not_allowed")]
            NotAllowedEnum = 1,
            
            /// <summary>
            /// Enum MandatoryEnum for mandatory
            /// </summary>
            [EnumMember(Value = "mandatory")]
            MandatoryEnum = 2,
            
            /// <summary>
            /// Enum OptionalEnum for optional
            /// </summary>
            [EnumMember(Value = "optional")]
            OptionalEnum = 3
        }

        /// <summary>
        /// This attribute indicates the optional, mandatory or not allowed need for the text
        /// </summary>
        /// <value>This attribute indicates the optional, mandatory or not allowed need for the text</value>

        [DataMember(Name="mandatoryText")]
        public MandatoryTextEnum? MandatoryText { get; set; }

        /// <summary>
        /// The pattern that the text introduced by the customer should match to. This value can be empty
        /// </summary>
        /// <value>The pattern that the text introduced by the customer should match to. This value can be empty</value>

        [DataMember(Name="pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// The text in the input or the textarea which helps the customers knows what should write
        /// </summary>
        /// <value>The text in the input or the textarea which helps the customers knows what should write</value>

        [DataMember(Name="placeHolder")]
        public string PlaceHolder { get; set; }

        /// <summary>
        /// The type for the input used to be filled by the customer, it can be number or text
        /// </summary>
        /// <value>The type for the input used to be filled by the customer, it can be number or text</value>

        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BookingInstructions {\n");
            sb.Append("  MandatoryText: ").Append(MandatoryText).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  PlaceHolder: ").Append(PlaceHolder).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BookingInstructions)obj);
        }

        /// <summary>
        /// Returns true if BookingInstructions instances are equal
        /// </summary>
        /// <param name="other">Instance of BookingInstructions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookingInstructions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MandatoryText == other.MandatoryText ||
                    MandatoryText != null &&
                    MandatoryText.Equals(other.MandatoryText)
                ) && 
                (
                    Pattern == other.Pattern ||
                    Pattern != null &&
                    Pattern.Equals(other.Pattern)
                ) && 
                (
                    PlaceHolder == other.PlaceHolder ||
                    PlaceHolder != null &&
                    PlaceHolder.Equals(other.PlaceHolder)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (MandatoryText != null)
                    hashCode = hashCode * 59 + MandatoryText.GetHashCode();
                    if (Pattern != null)
                    hashCode = hashCode * 59 + Pattern.GetHashCode();
                    if (PlaceHolder != null)
                    hashCode = hashCode * 59 + PlaceHolder.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BookingInstructions left, BookingInstructions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BookingInstructions left, BookingInstructions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}