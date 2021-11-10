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
    /// Allowed payment methods
    /// </summary>
    [DataContract]
    public partial class AllowedPaymentMethods : IEquatable<AllowedPaymentMethods>
    { 
        /// <summary>
        /// Gets or Sets AgencyCard
        /// </summary>
        [Required]
        
        [DataMember(Name="agencyCard")]
        public bool? AgencyCard { get; set; }

        /// <summary>
        /// Gets or Sets AgencyCash
        /// </summary>
        [Required]
        
        [DataMember(Name="agencyCash")]
        public bool? AgencyCash { get; set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [Required]
        
        [DataMember(Name="card")]
        public bool? Card { get; set; }

        /// <summary>
        /// Gets or Sets None
        /// </summary>
        [Required]
        
        [DataMember(Name="none")]
        public bool? None { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllowedPaymentMethods {\n");
            sb.Append("  AgencyCard: ").Append(AgencyCard).Append("\n");
            sb.Append("  AgencyCash: ").Append(AgencyCash).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
            sb.Append("  None: ").Append(None).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AllowedPaymentMethods)obj);
        }

        /// <summary>
        /// Returns true if AllowedPaymentMethods instances are equal
        /// </summary>
        /// <param name="other">Instance of AllowedPaymentMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllowedPaymentMethods other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AgencyCard == other.AgencyCard ||
                    AgencyCard != null &&
                    AgencyCard.Equals(other.AgencyCard)
                ) && 
                (
                    AgencyCash == other.AgencyCash ||
                    AgencyCash != null &&
                    AgencyCash.Equals(other.AgencyCash)
                ) && 
                (
                    Card == other.Card ||
                    Card != null &&
                    Card.Equals(other.Card)
                ) && 
                (
                    None == other.None ||
                    None != null &&
                    None.Equals(other.None)
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
                    if (AgencyCard != null)
                    hashCode = hashCode * 59 + AgencyCard.GetHashCode();
                    if (AgencyCash != null)
                    hashCode = hashCode * 59 + AgencyCash.GetHashCode();
                    if (Card != null)
                    hashCode = hashCode * 59 + Card.GetHashCode();
                    if (None != null)
                    hashCode = hashCode * 59 + None.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AllowedPaymentMethods left, AllowedPaymentMethods right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AllowedPaymentMethods left, AllowedPaymentMethods right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
