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
    public partial class Discount : IEquatable<Discount>
    { 
        /// <summary>
        /// IB Large Family Discount Code
        /// </summary>
        /// <value>IB Large Family Discount Code</value>

        [DataMember(Name="largeFamily")]
        public string LargeFamily { get; set; }

        /// <summary>
        /// IB Resident Code
        /// </summary>
        /// <value>IB Resident Code</value>

        [DataMember(Name="residentCode")]
        public string ResidentCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Discount {\n");
            sb.Append("  LargeFamily: ").Append(LargeFamily).Append("\n");
            sb.Append("  ResidentCode: ").Append(ResidentCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Discount)obj);
        }

        /// <summary>
        /// Returns true if Discount instances are equal
        /// </summary>
        /// <param name="other">Instance of Discount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Discount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LargeFamily == other.LargeFamily ||
                    LargeFamily != null &&
                    LargeFamily.Equals(other.LargeFamily)
                ) && 
                (
                    ResidentCode == other.ResidentCode ||
                    ResidentCode != null &&
                    ResidentCode.Equals(other.ResidentCode)
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
                    if (LargeFamily != null)
                    hashCode = hashCode * 59 + LargeFamily.GetHashCode();
                    if (ResidentCode != null)
                    hashCode = hashCode * 59 + ResidentCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Discount left, Discount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Discount left, Discount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
