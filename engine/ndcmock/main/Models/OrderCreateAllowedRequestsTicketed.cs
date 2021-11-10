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
    public partial class OrderCreateAllowedRequestsTicketed : IEquatable<OrderCreateAllowedRequestsTicketed>
    { 
        /// <summary>
        /// Gets or Sets OrderCancel
        /// </summary>

        [DataMember(Name="OrderCancel")]
        public bool? OrderCancel { get; set; }

        /// <summary>
        /// Gets or Sets OrderReshop
        /// </summary>

        [DataMember(Name="OrderReshop")]
        public bool? OrderReshop { get; set; }

        /// <summary>
        /// Gets or Sets OrderReshopRefund
        /// </summary>

        [DataMember(Name="OrderReshopRefund")]
        public bool? OrderReshopRefund { get; set; }

        /// <summary>
        /// Gets or Sets OrderReshopRouteChange
        /// </summary>

        [DataMember(Name="OrderReshopRouteChange")]
        public bool? OrderReshopRouteChange { get; set; }

        /// <summary>
        /// Gets or Sets OrderSplit
        /// </summary>

        [DataMember(Name="OrderSplit")]
        public bool? OrderSplit { get; set; }

        /// <summary>
        /// Gets or Sets OrderVoid
        /// </summary>

        [DataMember(Name="OrderVoid")]
        public bool? OrderVoid { get; set; }

        /// <summary>
        /// Gets or Sets SeatAvailability
        /// </summary>

        [DataMember(Name="SeatAvailability")]
        public bool? SeatAvailability { get; set; }

        /// <summary>
        /// Gets or Sets ServiceList
        /// </summary>

        [DataMember(Name="ServiceList")]
        public bool? ServiceList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCreateAllowedRequestsTicketed {\n");
            sb.Append("  OrderCancel: ").Append(OrderCancel).Append("\n");
            sb.Append("  OrderReshop: ").Append(OrderReshop).Append("\n");
            sb.Append("  OrderReshopRefund: ").Append(OrderReshopRefund).Append("\n");
            sb.Append("  OrderReshopRouteChange: ").Append(OrderReshopRouteChange).Append("\n");
            sb.Append("  OrderSplit: ").Append(OrderSplit).Append("\n");
            sb.Append("  OrderVoid: ").Append(OrderVoid).Append("\n");
            sb.Append("  SeatAvailability: ").Append(SeatAvailability).Append("\n");
            sb.Append("  ServiceList: ").Append(ServiceList).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrderCreateAllowedRequestsTicketed)obj);
        }

        /// <summary>
        /// Returns true if OrderCreateAllowedRequestsTicketed instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderCreateAllowedRequestsTicketed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCreateAllowedRequestsTicketed other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OrderCancel == other.OrderCancel ||
                    OrderCancel != null &&
                    OrderCancel.Equals(other.OrderCancel)
                ) && 
                (
                    OrderReshop == other.OrderReshop ||
                    OrderReshop != null &&
                    OrderReshop.Equals(other.OrderReshop)
                ) && 
                (
                    OrderReshopRefund == other.OrderReshopRefund ||
                    OrderReshopRefund != null &&
                    OrderReshopRefund.Equals(other.OrderReshopRefund)
                ) && 
                (
                    OrderReshopRouteChange == other.OrderReshopRouteChange ||
                    OrderReshopRouteChange != null &&
                    OrderReshopRouteChange.Equals(other.OrderReshopRouteChange)
                ) && 
                (
                    OrderSplit == other.OrderSplit ||
                    OrderSplit != null &&
                    OrderSplit.Equals(other.OrderSplit)
                ) && 
                (
                    OrderVoid == other.OrderVoid ||
                    OrderVoid != null &&
                    OrderVoid.Equals(other.OrderVoid)
                ) && 
                (
                    SeatAvailability == other.SeatAvailability ||
                    SeatAvailability != null &&
                    SeatAvailability.Equals(other.SeatAvailability)
                ) && 
                (
                    ServiceList == other.ServiceList ||
                    ServiceList != null &&
                    ServiceList.Equals(other.ServiceList)
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
                    if (OrderCancel != null)
                    hashCode = hashCode * 59 + OrderCancel.GetHashCode();
                    if (OrderReshop != null)
                    hashCode = hashCode * 59 + OrderReshop.GetHashCode();
                    if (OrderReshopRefund != null)
                    hashCode = hashCode * 59 + OrderReshopRefund.GetHashCode();
                    if (OrderReshopRouteChange != null)
                    hashCode = hashCode * 59 + OrderReshopRouteChange.GetHashCode();
                    if (OrderSplit != null)
                    hashCode = hashCode * 59 + OrderSplit.GetHashCode();
                    if (OrderVoid != null)
                    hashCode = hashCode * 59 + OrderVoid.GetHashCode();
                    if (SeatAvailability != null)
                    hashCode = hashCode * 59 + SeatAvailability.GetHashCode();
                    if (ServiceList != null)
                    hashCode = hashCode * 59 + ServiceList.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OrderCreateAllowedRequestsTicketed left, OrderCreateAllowedRequestsTicketed right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OrderCreateAllowedRequestsTicketed left, OrderCreateAllowedRequestsTicketed right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
