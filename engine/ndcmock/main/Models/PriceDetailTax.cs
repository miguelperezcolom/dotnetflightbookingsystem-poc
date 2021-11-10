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
    public partial class PriceDetailTax : IEquatable<PriceDetailTax>
    { 
        /// <summary>
        /// The value price, currency, code and description for each tax for each AirlineOffer
        /// </summary>
        /// <value>The value price, currency, code and description for each tax for each AirlineOffer</value>

        [DataMember(Name="breakdown")]
        public List<PriceDetailTaxBreakdown> Breakdown { get; set; }

        /// <summary>
        /// 120 or 120.62
        /// </summary>
        /// <value>120 or 120.62</value>

        [DataMember(Name="total")]
        public double? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceDetailTax {\n");
            sb.Append("  Breakdown: ").Append(Breakdown).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PriceDetailTax)obj);
        }

        /// <summary>
        /// Returns true if PriceDetailTax instances are equal
        /// </summary>
        /// <param name="other">Instance of PriceDetailTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceDetailTax other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Breakdown == other.Breakdown ||
                    Breakdown != null &&
                    Breakdown.SequenceEqual(other.Breakdown)
                ) && 
                (
                    Total == other.Total ||
                    Total != null &&
                    Total.Equals(other.Total)
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
                    if (Breakdown != null)
                    hashCode = hashCode * 59 + Breakdown.GetHashCode();
                    if (Total != null)
                    hashCode = hashCode * 59 + Total.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PriceDetailTax left, PriceDetailTax right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PriceDetailTax left, PriceDetailTax right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}