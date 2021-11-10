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
    /// OrderMetasPayload is the type for OrderMetas endpoint request body
    /// </summary>
    [DataContract]
    public partial class OrderMetasPayload : IEquatable<OrderMetasPayload>
    { 
        /// <summary>
        /// AirGateway order ID
        /// </summary>
        /// <value>AirGateway order ID</value>
        [Required]
        
        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Metas object
        /// </summary>
        /// <value>Metas object</value>

        [DataMember(Name="metas")]
        public Object Metas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderMetasPayload {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Metas: ").Append(Metas).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrderMetasPayload)obj);
        }

        /// <summary>
        /// Returns true if OrderMetasPayload instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderMetasPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMetasPayload other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Metas == other.Metas ||
                    Metas != null &&
                    Metas.Equals(other.Metas)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Metas != null)
                    hashCode = hashCode * 59 + Metas.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OrderMetasPayload left, OrderMetasPayload right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OrderMetasPayload left, OrderMetasPayload right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
