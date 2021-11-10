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
    /// 
    /// </summary>
    [DataContract]
    public partial class FlightDetailFare : IEquatable<FlightDetailFare>
    { 
        /// <summary>
        /// Fare Basis Code
        /// </summary>
        /// <value>Fare Basis Code</value>

        [DataMember(Name="basisCode")]
        public string BasisCode { get; set; }

        /// <summary>
        /// Gets or Sets Cabin
        /// </summary>

        [DataMember(Name="cabin")]
        public string Cabin { get; set; }

        /// <summary>
        /// Fare information for this flight segment
        /// </summary>
        /// <value>Fare information for this flight segment</value>

        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Marketing name
        /// </summary>
        /// <value>Marketing name</value>

        [DataMember(Name="marketingName")]
        public string MarketingName { get; set; }

        /// <summary>
        /// Price class name
        /// </summary>
        /// <value>Price class name</value>

        [DataMember(Name="priceClassName")]
        public string PriceClassName { get; set; }

        /// <summary>
        /// Gets or Sets StandardName
        /// </summary>

        [DataMember(Name="standardName")]
        public string StandardName { get; set; }

        /// <summary>
        /// Fare type
        /// </summary>
        /// <value>Fare type</value>

        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlightDetailFare {\n");
            sb.Append("  BasisCode: ").Append(BasisCode).Append("\n");
            sb.Append("  Cabin: ").Append(Cabin).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MarketingName: ").Append(MarketingName).Append("\n");
            sb.Append("  PriceClassName: ").Append(PriceClassName).Append("\n");
            sb.Append("  StandardName: ").Append(StandardName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((FlightDetailFare)obj);
        }

        /// <summary>
        /// Returns true if FlightDetailFare instances are equal
        /// </summary>
        /// <param name="other">Instance of FlightDetailFare to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlightDetailFare other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    BasisCode == other.BasisCode ||
                    BasisCode != null &&
                    BasisCode.Equals(other.BasisCode)
                ) && 
                (
                    Cabin == other.Cabin ||
                    Cabin != null &&
                    Cabin.Equals(other.Cabin)
                ) && 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    MarketingName == other.MarketingName ||
                    MarketingName != null &&
                    MarketingName.Equals(other.MarketingName)
                ) && 
                (
                    PriceClassName == other.PriceClassName ||
                    PriceClassName != null &&
                    PriceClassName.Equals(other.PriceClassName)
                ) && 
                (
                    StandardName == other.StandardName ||
                    StandardName != null &&
                    StandardName.Equals(other.StandardName)
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
                    if (BasisCode != null)
                    hashCode = hashCode * 59 + BasisCode.GetHashCode();
                    if (Cabin != null)
                    hashCode = hashCode * 59 + Cabin.GetHashCode();
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (MarketingName != null)
                    hashCode = hashCode * 59 + MarketingName.GetHashCode();
                    if (PriceClassName != null)
                    hashCode = hashCode * 59 + PriceClassName.GetHashCode();
                    if (StandardName != null)
                    hashCode = hashCode * 59 + StandardName.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FlightDetailFare left, FlightDetailFare right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FlightDetailFare left, FlightDetailFare right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
