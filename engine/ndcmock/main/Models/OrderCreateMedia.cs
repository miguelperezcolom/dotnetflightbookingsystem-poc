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
    /// OrderCreateMedia media type (default view)
    /// </summary>
    [DataContract]
    public partial class OrderCreateMedia : IEquatable<OrderCreateMedia>
    { 
        /// <summary>
        /// Agency name
        /// </summary>
        /// <value>Agency name</value>

        [DataMember(Name="agency")]
        public string Agency { get; set; }

        /// <summary>
        /// Gets or Sets AgencyData
        /// </summary>

        [DataMember(Name="agencyData")]
        public AgencyData AgencyData { get; set; }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethods
        /// </summary>

        [DataMember(Name="allowedPaymentMethods")]
        public AllowedPaymentMethods AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets AllowedRequests
        /// </summary>

        [DataMember(Name="allowedRequests")]
        public OrderCreateAllowedRequests AllowedRequests { get; set; }

        /// <summary>
        /// Approval status
        /// </summary>
        /// <value>Approval status</value>

        [DataMember(Name="approvalStatus")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// Approved status
        /// </summary>
        /// <value>Approved status</value>

        [DataMember(Name="approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// Gets or Sets BookingDate
        /// </summary>

        [RegularExpression("/(\\d\\d\\d\\d)-(\\d\\d)-(\\d\\d)/")]
        [DataMember(Name="bookingDate")]
        public string BookingDate { get; set; }

        /// <summary>
        /// Gets or Sets BookingReference
        /// </summary>

        [DataMember(Name="bookingReference")]
        public BookingReferenceResponse BookingReference { get; set; }

        /// <summary>
        /// Gets or Sets BookingType
        /// </summary>

        [DataMember(Name="bookingType")]
        public string BookingType { get; set; }

        /// <summary>
        /// Order flights carbon offset
        /// </summary>
        /// <value>Order flights carbon offset</value>

        [DataMember(Name="carbonOffset")]
        public List<CarbonOffset> CarbonOffset { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>

        [DataMember(Name="comments")]
        public string Comments { get; set; }

        /// <summary>
        /// CorporateID for corporate orders
        /// </summary>
        /// <value>CorporateID for corporate orders</value>

        [DataMember(Name="corporateID")]
        public string CorporateID { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>

        [RegularExpression("/(\\d\\d\\d\\d)-(\\d\\d)-(\\d\\d) (\\d\\d):(\\d\\d)/")]
        [DataMember(Name="createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Disclosures
        /// </summary>

        [DataMember(Name="disclosures")]
        public List<Disclosure> Disclosures { get; set; }

        /// <summary>
        /// Disruption notification message
        /// </summary>
        /// <value>Disruption notification message</value>

        [DataMember(Name="disruptionMessage")]
        public string DisruptionMessage { get; set; }

        /// <summary>
        /// Disruption status (FlightTimeChange/FlightNumberChange/FlightCancellation)
        /// </summary>
        /// <value>Disruption status (FlightTimeChange/FlightNumberChange/FlightCancellation)</value>

        [DataMember(Name="disruptionStatus")]
        public string DisruptionStatus { get; set; }

        /// <summary>
        /// External order ID
        /// </summary>
        /// <value>External order ID</value>

        [DataMember(Name="externalOrderID")]
        public string ExternalOrderID { get; set; }

        /// <summary>
        /// Files information
        /// </summary>
        /// <value>Files information</value>

        [DataMember(Name="files")]
        public List<OrderFile> Files { get; set; }

        /// <summary>
        /// Flight Segment information. Including departure, arrival and airline information.
        /// </summary>
        /// <value>Flight Segment information. Including departure, arrival and airline information.</value>

        [DataMember(Name="flights")]
        public List<Flight> Flights { get; set; }

        /// <summary>
        /// Gets or Sets FormOfPayment
        /// </summary>

        [DataMember(Name="formOfPayment")]
        public string FormOfPayment { get; set; }

        /// <summary>
        /// Gets or Sets History
        /// </summary>

        [DataMember(Name="history")]
        public List<OrderHistoryItem> History { get; set; }

        /// <summary>
        /// AirGateway order ID
        /// </summary>
        /// <value>AirGateway order ID</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>

        [DataMember(Name="logs")]
        public List<OrderLog> Logs { get; set; }

        /// <summary>
        /// Order metadata
        /// </summary>
        /// <value>Order metadata</value>

        [DataMember(Name="metas")]
        public Object Metas { get; set; }

        /// <summary>
        /// External order ID (deprecated)
        /// </summary>
        /// <value>External order ID (deprecated)</value>

        [DataMember(Name="orderID")]
        public string OrderID { get; set; }

        /// <summary>
        /// Gets or Sets Passengers
        /// </summary>

        [DataMember(Name="passengers")]
        public List<Passenger> Passengers { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>

        [DataMember(Name="payment")]
        public OrderCreatePayment Payment { get; set; }

        /// <summary>
        /// Payment time limit
        /// </summary>
        /// <value>Payment time limit</value>

        [DataMember(Name="paymentTimeLimit")]
        public string PaymentTimeLimit { get; set; }

        /// <summary>
        /// Type and the application (with the value for each application) for every penalties.
        /// </summary>
        /// <value>Type and the application (with the value for each application) for every penalties.</value>

        [DataMember(Name="penalties")]
        public List<Penalty> Penalties { get; set; }

        /// <summary>
        /// The unique identifier of the order used on the old system and respected by some providers to maintain compatibility.
        /// </summary>
        /// <value>The unique identifier of the order used on the old system and respected by some providers to maintain compatibility.</value>

        [DataMember(Name="pnr")]
        public string Pnr { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>

        [DataMember(Name="price")]
        public Price Price { get; set; }

        /// <summary>
        /// Ready To Ticket Issue flag
        /// </summary>
        /// <value>Ready To Ticket Issue flag</value>

        [DataMember(Name="readyToTicketIssue")]
        public bool? ReadyToTicketIssue { get; set; }

        /// <summary>
        /// Gets or Sets RefundedAmount
        /// </summary>

        [DataMember(Name="refundedAmount")]
        public Price RefundedAmount { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>

        [DataMember(Name="remarks")]
        public OrderRemarks Remarks { get; set; }

        /// <summary>
        /// List of seats
        /// </summary>
        /// <value>List of seats</value>

        [DataMember(Name="seats")]
        public List<Seat> Seats { get; set; }

        /// <summary>
        /// Send for approval allowed
        /// </summary>
        /// <value>Send for approval allowed</value>

        [DataMember(Name="sendForApprovalAllowed")]
        public bool? SendForApprovalAllowed { get; set; }

        /// <summary>
        /// List of services
        /// </summary>
        /// <value>List of services</value>

        [DataMember(Name="services")]
        public List<Service> Services { get; set; }

        /// <summary>
        /// Order status (Pending/Ticketed/Cancelled/Completed/Started/Expired)
        /// </summary>
        /// <value>Order status (Pending/Ticketed/Cancelled/Completed/Started/Expired)</value>

        [DataMember(Name="status")]
        public string Status { get; set; }

        /// <summary>
        /// Ticket Issue object
        /// </summary>
        /// <value>Ticket Issue object</value>

        [DataMember(Name="ticketIssue")]
        public Object TicketIssue { get; set; }

        /// <summary>
        /// Tickets information
        /// </summary>
        /// <value>Tickets information</value>

        [DataMember(Name="tickets")]
        public List<TicketInfo> Tickets { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>

        [RegularExpression("/(\\d\\d\\d\\d)-(\\d\\d)-(\\d\\d) (\\d\\d):(\\d\\d)/")]
        [DataMember(Name="updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// View mode for order
        /// </summary>
        /// <value>View mode for order</value>

        [DataMember(Name="viewMode")]
        public string ViewMode { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>

        [DataMember(Name="warnings")]
        public List<OrderLog> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderCreateMedia {\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("  AgencyData: ").Append(AgencyData).Append("\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  AllowedRequests: ").Append(AllowedRequests).Append("\n");
            sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
            sb.Append("  BookingReference: ").Append(BookingReference).Append("\n");
            sb.Append("  BookingType: ").Append(BookingType).Append("\n");
            sb.Append("  CarbonOffset: ").Append(CarbonOffset).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CorporateID: ").Append(CorporateID).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Disclosures: ").Append(Disclosures).Append("\n");
            sb.Append("  DisruptionMessage: ").Append(DisruptionMessage).Append("\n");
            sb.Append("  DisruptionStatus: ").Append(DisruptionStatus).Append("\n");
            sb.Append("  ExternalOrderID: ").Append(ExternalOrderID).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Flights: ").Append(Flights).Append("\n");
            sb.Append("  FormOfPayment: ").Append(FormOfPayment).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  Metas: ").Append(Metas).Append("\n");
            sb.Append("  OrderID: ").Append(OrderID).Append("\n");
            sb.Append("  Passengers: ").Append(Passengers).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  PaymentTimeLimit: ").Append(PaymentTimeLimit).Append("\n");
            sb.Append("  Penalties: ").Append(Penalties).Append("\n");
            sb.Append("  Pnr: ").Append(Pnr).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ReadyToTicketIssue: ").Append(ReadyToTicketIssue).Append("\n");
            sb.Append("  RefundedAmount: ").Append(RefundedAmount).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  Seats: ").Append(Seats).Append("\n");
            sb.Append("  SendForApprovalAllowed: ").Append(SendForApprovalAllowed).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TicketIssue: ").Append(TicketIssue).Append("\n");
            sb.Append("  Tickets: ").Append(Tickets).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  ViewMode: ").Append(ViewMode).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return obj.GetType() == GetType() && Equals((OrderCreateMedia)obj);
        }

        /// <summary>
        /// Returns true if OrderCreateMedia instances are equal
        /// </summary>
        /// <param name="other">Instance of OrderCreateMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCreateMedia other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Agency == other.Agency ||
                    Agency != null &&
                    Agency.Equals(other.Agency)
                ) && 
                (
                    AgencyData == other.AgencyData ||
                    AgencyData != null &&
                    AgencyData.Equals(other.AgencyData)
                ) && 
                (
                    AllowedPaymentMethods == other.AllowedPaymentMethods ||
                    AllowedPaymentMethods != null &&
                    AllowedPaymentMethods.Equals(other.AllowedPaymentMethods)
                ) && 
                (
                    AllowedRequests == other.AllowedRequests ||
                    AllowedRequests != null &&
                    AllowedRequests.Equals(other.AllowedRequests)
                ) && 
                (
                    ApprovalStatus == other.ApprovalStatus ||
                    ApprovalStatus != null &&
                    ApprovalStatus.Equals(other.ApprovalStatus)
                ) && 
                (
                    Approved == other.Approved ||
                    Approved != null &&
                    Approved.Equals(other.Approved)
                ) && 
                (
                    BookingDate == other.BookingDate ||
                    BookingDate != null &&
                    BookingDate.Equals(other.BookingDate)
                ) && 
                (
                    BookingReference == other.BookingReference ||
                    BookingReference != null &&
                    BookingReference.Equals(other.BookingReference)
                ) && 
                (
                    BookingType == other.BookingType ||
                    BookingType != null &&
                    BookingType.Equals(other.BookingType)
                ) && 
                (
                    CarbonOffset == other.CarbonOffset ||
                    CarbonOffset != null &&
                    CarbonOffset.SequenceEqual(other.CarbonOffset)
                ) && 
                (
                    Comments == other.Comments ||
                    Comments != null &&
                    Comments.Equals(other.Comments)
                ) && 
                (
                    CorporateID == other.CorporateID ||
                    CorporateID != null &&
                    CorporateID.Equals(other.CorporateID)
                ) && 
                (
                    CreatedAt == other.CreatedAt ||
                    CreatedAt != null &&
                    CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    Disclosures == other.Disclosures ||
                    Disclosures != null &&
                    Disclosures.SequenceEqual(other.Disclosures)
                ) && 
                (
                    DisruptionMessage == other.DisruptionMessage ||
                    DisruptionMessage != null &&
                    DisruptionMessage.Equals(other.DisruptionMessage)
                ) && 
                (
                    DisruptionStatus == other.DisruptionStatus ||
                    DisruptionStatus != null &&
                    DisruptionStatus.Equals(other.DisruptionStatus)
                ) && 
                (
                    ExternalOrderID == other.ExternalOrderID ||
                    ExternalOrderID != null &&
                    ExternalOrderID.Equals(other.ExternalOrderID)
                ) && 
                (
                    Files == other.Files ||
                    Files != null &&
                    Files.SequenceEqual(other.Files)
                ) && 
                (
                    Flights == other.Flights ||
                    Flights != null &&
                    Flights.SequenceEqual(other.Flights)
                ) && 
                (
                    FormOfPayment == other.FormOfPayment ||
                    FormOfPayment != null &&
                    FormOfPayment.Equals(other.FormOfPayment)
                ) && 
                (
                    History == other.History ||
                    History != null &&
                    History.SequenceEqual(other.History)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Logs == other.Logs ||
                    Logs != null &&
                    Logs.SequenceEqual(other.Logs)
                ) && 
                (
                    Metas == other.Metas ||
                    Metas != null &&
                    Metas.Equals(other.Metas)
                ) && 
                (
                    OrderID == other.OrderID ||
                    OrderID != null &&
                    OrderID.Equals(other.OrderID)
                ) && 
                (
                    Passengers == other.Passengers ||
                    Passengers != null &&
                    Passengers.SequenceEqual(other.Passengers)
                ) && 
                (
                    Payment == other.Payment ||
                    Payment != null &&
                    Payment.Equals(other.Payment)
                ) && 
                (
                    PaymentTimeLimit == other.PaymentTimeLimit ||
                    PaymentTimeLimit != null &&
                    PaymentTimeLimit.Equals(other.PaymentTimeLimit)
                ) && 
                (
                    Penalties == other.Penalties ||
                    Penalties != null &&
                    Penalties.SequenceEqual(other.Penalties)
                ) && 
                (
                    Pnr == other.Pnr ||
                    Pnr != null &&
                    Pnr.Equals(other.Pnr)
                ) && 
                (
                    Price == other.Price ||
                    Price != null &&
                    Price.Equals(other.Price)
                ) && 
                (
                    ReadyToTicketIssue == other.ReadyToTicketIssue ||
                    ReadyToTicketIssue != null &&
                    ReadyToTicketIssue.Equals(other.ReadyToTicketIssue)
                ) && 
                (
                    RefundedAmount == other.RefundedAmount ||
                    RefundedAmount != null &&
                    RefundedAmount.Equals(other.RefundedAmount)
                ) && 
                (
                    Remarks == other.Remarks ||
                    Remarks != null &&
                    Remarks.Equals(other.Remarks)
                ) && 
                (
                    Seats == other.Seats ||
                    Seats != null &&
                    Seats.SequenceEqual(other.Seats)
                ) && 
                (
                    SendForApprovalAllowed == other.SendForApprovalAllowed ||
                    SendForApprovalAllowed != null &&
                    SendForApprovalAllowed.Equals(other.SendForApprovalAllowed)
                ) && 
                (
                    Services == other.Services ||
                    Services != null &&
                    Services.SequenceEqual(other.Services)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    TicketIssue == other.TicketIssue ||
                    TicketIssue != null &&
                    TicketIssue.Equals(other.TicketIssue)
                ) && 
                (
                    Tickets == other.Tickets ||
                    Tickets != null &&
                    Tickets.SequenceEqual(other.Tickets)
                ) && 
                (
                    UpdatedAt == other.UpdatedAt ||
                    UpdatedAt != null &&
                    UpdatedAt.Equals(other.UpdatedAt)
                ) && 
                (
                    ViewMode == other.ViewMode ||
                    ViewMode != null &&
                    ViewMode.Equals(other.ViewMode)
                ) && 
                (
                    Warnings == other.Warnings ||
                    Warnings != null &&
                    Warnings.SequenceEqual(other.Warnings)
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
                    if (Agency != null)
                    hashCode = hashCode * 59 + Agency.GetHashCode();
                    if (AgencyData != null)
                    hashCode = hashCode * 59 + AgencyData.GetHashCode();
                    if (AllowedPaymentMethods != null)
                    hashCode = hashCode * 59 + AllowedPaymentMethods.GetHashCode();
                    if (AllowedRequests != null)
                    hashCode = hashCode * 59 + AllowedRequests.GetHashCode();
                    if (ApprovalStatus != null)
                    hashCode = hashCode * 59 + ApprovalStatus.GetHashCode();
                    if (Approved != null)
                    hashCode = hashCode * 59 + Approved.GetHashCode();
                    if (BookingDate != null)
                    hashCode = hashCode * 59 + BookingDate.GetHashCode();
                    if (BookingReference != null)
                    hashCode = hashCode * 59 + BookingReference.GetHashCode();
                    if (BookingType != null)
                    hashCode = hashCode * 59 + BookingType.GetHashCode();
                    if (CarbonOffset != null)
                    hashCode = hashCode * 59 + CarbonOffset.GetHashCode();
                    if (Comments != null)
                    hashCode = hashCode * 59 + Comments.GetHashCode();
                    if (CorporateID != null)
                    hashCode = hashCode * 59 + CorporateID.GetHashCode();
                    if (CreatedAt != null)
                    hashCode = hashCode * 59 + CreatedAt.GetHashCode();
                    if (Disclosures != null)
                    hashCode = hashCode * 59 + Disclosures.GetHashCode();
                    if (DisruptionMessage != null)
                    hashCode = hashCode * 59 + DisruptionMessage.GetHashCode();
                    if (DisruptionStatus != null)
                    hashCode = hashCode * 59 + DisruptionStatus.GetHashCode();
                    if (ExternalOrderID != null)
                    hashCode = hashCode * 59 + ExternalOrderID.GetHashCode();
                    if (Files != null)
                    hashCode = hashCode * 59 + Files.GetHashCode();
                    if (Flights != null)
                    hashCode = hashCode * 59 + Flights.GetHashCode();
                    if (FormOfPayment != null)
                    hashCode = hashCode * 59 + FormOfPayment.GetHashCode();
                    if (History != null)
                    hashCode = hashCode * 59 + History.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Logs != null)
                    hashCode = hashCode * 59 + Logs.GetHashCode();
                    if (Metas != null)
                    hashCode = hashCode * 59 + Metas.GetHashCode();
                    if (OrderID != null)
                    hashCode = hashCode * 59 + OrderID.GetHashCode();
                    if (Passengers != null)
                    hashCode = hashCode * 59 + Passengers.GetHashCode();
                    if (Payment != null)
                    hashCode = hashCode * 59 + Payment.GetHashCode();
                    if (PaymentTimeLimit != null)
                    hashCode = hashCode * 59 + PaymentTimeLimit.GetHashCode();
                    if (Penalties != null)
                    hashCode = hashCode * 59 + Penalties.GetHashCode();
                    if (Pnr != null)
                    hashCode = hashCode * 59 + Pnr.GetHashCode();
                    if (Price != null)
                    hashCode = hashCode * 59 + Price.GetHashCode();
                    if (ReadyToTicketIssue != null)
                    hashCode = hashCode * 59 + ReadyToTicketIssue.GetHashCode();
                    if (RefundedAmount != null)
                    hashCode = hashCode * 59 + RefundedAmount.GetHashCode();
                    if (Remarks != null)
                    hashCode = hashCode * 59 + Remarks.GetHashCode();
                    if (Seats != null)
                    hashCode = hashCode * 59 + Seats.GetHashCode();
                    if (SendForApprovalAllowed != null)
                    hashCode = hashCode * 59 + SendForApprovalAllowed.GetHashCode();
                    if (Services != null)
                    hashCode = hashCode * 59 + Services.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (TicketIssue != null)
                    hashCode = hashCode * 59 + TicketIssue.GetHashCode();
                    if (Tickets != null)
                    hashCode = hashCode * 59 + Tickets.GetHashCode();
                    if (UpdatedAt != null)
                    hashCode = hashCode * 59 + UpdatedAt.GetHashCode();
                    if (ViewMode != null)
                    hashCode = hashCode * 59 + ViewMode.GetHashCode();
                    if (Warnings != null)
                    hashCode = hashCode * 59 + Warnings.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(OrderCreateMedia left, OrderCreateMedia right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(OrderCreateMedia left, OrderCreateMedia right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
