/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace FikaAmazonAPI.AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// A shipping service offer made by a carrier.
    /// </summary>
    [DataContract]
    public partial class ShippingService : IEquatable<ShippingService>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingService" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingService() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingService" /> class.
        /// </summary>
        /// <param name="ShippingServiceName">A plain text representation of a carrier&#39;s shipping service. For example, \&quot;UPS Ground\&quot; or \&quot;FedEx Standard Overnight\&quot;.  (required).</param>
        /// <param name="CarrierName">The name of the carrier. (required).</param>
        /// <param name="ShippingServiceId">ShippingServiceId (required).</param>
        /// <param name="ShippingServiceOfferId">An Amazon-defined shipping service offer identifier. (required).</param>
        /// <param name="ShipDate">The date that the carrier will ship the package. (required).</param>
        /// <param name="EarliestEstimatedDeliveryDate">The earliest date by which the shipment will be delivered..</param>
        /// <param name="LatestEstimatedDeliveryDate">The latest date by which the shipment will be delivered..</param>
        /// <param name="Rate">The amount that the carrier will charge for the shipment. (required).</param>
        /// <param name="ShippingServiceOptions">Extra services offered by the carrier. (required).</param>
        /// <param name="AvailableShippingServiceOptions">AvailableShippingServiceOptions.</param>
        /// <param name="AvailableLabelFormats">AvailableLabelFormats.</param>
        /// <param name="AvailableFormatOptionsForLabel">AvailableFormatOptionsForLabel.</param>
        /// <param name="RequiresAdditionalSellerInputs">When true, additional seller inputs are required. (required).</param>
        public ShippingService(string ShippingServiceName = default(string), string CarrierName = default(string), ShippingServiceIdentifier ShippingServiceId = default(ShippingServiceIdentifier), string ShippingServiceOfferId = default(string), Timestamp ShipDate = default(Timestamp), Timestamp EarliestEstimatedDeliveryDate = default(Timestamp), Timestamp LatestEstimatedDeliveryDate = default(Timestamp), CurrencyAmount Rate = default(CurrencyAmount), ShippingServiceOptions ShippingServiceOptions = default(ShippingServiceOptions), AvailableShippingServiceOptions AvailableShippingServiceOptions = default(AvailableShippingServiceOptions), LabelFormatList AvailableLabelFormats = default(LabelFormatList), AvailableFormatOptionsForLabelList AvailableFormatOptionsForLabel = default(AvailableFormatOptionsForLabelList), bool? RequiresAdditionalSellerInputs = default(bool?))
        {
            // to ensure "ShippingServiceName" is required (not null)
            if (ShippingServiceName == null)
            {
                throw new InvalidDataException("ShippingServiceName is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceName = ShippingServiceName;
            }
            // to ensure "CarrierName" is required (not null)
            if (CarrierName == null)
            {
                throw new InvalidDataException("CarrierName is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.CarrierName = CarrierName;
            }
            // to ensure "ShippingServiceId" is required (not null)
            if (ShippingServiceId == null)
            {
                throw new InvalidDataException("ShippingServiceId is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceId = ShippingServiceId;
            }
            // to ensure "ShippingServiceOfferId" is required (not null)
            if (ShippingServiceOfferId == null)
            {
                throw new InvalidDataException("ShippingServiceOfferId is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceOfferId = ShippingServiceOfferId;
            }
            // to ensure "ShipDate" is required (not null)
            if (ShipDate == null)
            {
                throw new InvalidDataException("ShipDate is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.ShipDate = ShipDate;
            }
            // to ensure "Rate" is required (not null)
            if (Rate == null)
            {
                throw new InvalidDataException("Rate is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.Rate = Rate;
            }
            // to ensure "ShippingServiceOptions" is required (not null)
            if (ShippingServiceOptions == null)
            {
                throw new InvalidDataException("ShippingServiceOptions is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.ShippingServiceOptions = ShippingServiceOptions;
            }
            // to ensure "RequiresAdditionalSellerInputs" is required (not null)
            if (RequiresAdditionalSellerInputs == null)
            {
                throw new InvalidDataException("RequiresAdditionalSellerInputs is a required property for ShippingService and cannot be null");
            }
            else
            {
                this.RequiresAdditionalSellerInputs = RequiresAdditionalSellerInputs;
            }
            this.EarliestEstimatedDeliveryDate = EarliestEstimatedDeliveryDate;
            this.LatestEstimatedDeliveryDate = LatestEstimatedDeliveryDate;
            this.AvailableShippingServiceOptions = AvailableShippingServiceOptions;
            this.AvailableLabelFormats = AvailableLabelFormats;
            this.AvailableFormatOptionsForLabel = AvailableFormatOptionsForLabel;
        }

        /// <summary>
        /// A plain text representation of a carrier&#39;s shipping service. For example, \&quot;UPS Ground\&quot; or \&quot;FedEx Standard Overnight\&quot;. 
        /// </summary>
        /// <value>A plain text representation of a carrier&#39;s shipping service. For example, \&quot;UPS Ground\&quot; or \&quot;FedEx Standard Overnight\&quot;. </value>
        [DataMember(Name = "ShippingServiceName", EmitDefaultValue = false)]
        public string ShippingServiceName { get; set; }

        /// <summary>
        /// The name of the carrier.
        /// </summary>
        /// <value>The name of the carrier.</value>
        [DataMember(Name = "CarrierName", EmitDefaultValue = false)]
        public string CarrierName { get; set; }

        /// <summary>
        /// Gets or Sets ShippingServiceId
        /// </summary>
        [DataMember(Name = "ShippingServiceId", EmitDefaultValue = false)]
        public ShippingServiceIdentifier ShippingServiceId { get; set; }

        /// <summary>
        /// An Amazon-defined shipping service offer identifier.
        /// </summary>
        /// <value>An Amazon-defined shipping service offer identifier.</value>
        [DataMember(Name = "ShippingServiceOfferId", EmitDefaultValue = false)]
        public string ShippingServiceOfferId { get; set; }

        /// <summary>
        /// The date that the carrier will ship the package.
        /// </summary>
        /// <value>The date that the carrier will ship the package.</value>
        [DataMember(Name = "ShipDate", EmitDefaultValue = false)]
        public Timestamp ShipDate { get; set; }

        /// <summary>
        /// The earliest date by which the shipment will be delivered.
        /// </summary>
        /// <value>The earliest date by which the shipment will be delivered.</value>
        [DataMember(Name = "EarliestEstimatedDeliveryDate", EmitDefaultValue = false)]
        public Timestamp EarliestEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The latest date by which the shipment will be delivered.
        /// </summary>
        /// <value>The latest date by which the shipment will be delivered.</value>
        [DataMember(Name = "LatestEstimatedDeliveryDate", EmitDefaultValue = false)]
        public Timestamp LatestEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// The amount that the carrier will charge for the shipment.
        /// </summary>
        /// <value>The amount that the carrier will charge for the shipment.</value>
        [DataMember(Name = "Rate", EmitDefaultValue = false)]
        public CurrencyAmount Rate { get; set; }

        /// <summary>
        /// Extra services offered by the carrier.
        /// </summary>
        /// <value>Extra services offered by the carrier.</value>
        [DataMember(Name = "ShippingServiceOptions", EmitDefaultValue = false)]
        public ShippingServiceOptions ShippingServiceOptions { get; set; }

        /// <summary>
        /// Gets or Sets AvailableShippingServiceOptions
        /// </summary>
        [DataMember(Name = "AvailableShippingServiceOptions", EmitDefaultValue = false)]
        public AvailableShippingServiceOptions AvailableShippingServiceOptions { get; set; }

        /// <summary>
        /// Gets or Sets AvailableLabelFormats
        /// </summary>
        [DataMember(Name = "AvailableLabelFormats", EmitDefaultValue = false)]
        public LabelFormatList AvailableLabelFormats { get; set; }

        /// <summary>
        /// Gets or Sets AvailableFormatOptionsForLabel
        /// </summary>
        [DataMember(Name = "AvailableFormatOptionsForLabel", EmitDefaultValue = false)]
        public AvailableFormatOptionsForLabelList AvailableFormatOptionsForLabel { get; set; }

        /// <summary>
        /// When true, additional seller inputs are required.
        /// </summary>
        /// <value>When true, additional seller inputs are required.</value>
        [DataMember(Name = "RequiresAdditionalSellerInputs", EmitDefaultValue = false)]
        public bool? RequiresAdditionalSellerInputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingService {\n");
            sb.Append("  ShippingServiceName: ").Append(ShippingServiceName).Append("\n");
            sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
            sb.Append("  ShippingServiceId: ").Append(ShippingServiceId).Append("\n");
            sb.Append("  ShippingServiceOfferId: ").Append(ShippingServiceOfferId).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  EarliestEstimatedDeliveryDate: ").Append(EarliestEstimatedDeliveryDate).Append("\n");
            sb.Append("  LatestEstimatedDeliveryDate: ").Append(LatestEstimatedDeliveryDate).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ShippingServiceOptions: ").Append(ShippingServiceOptions).Append("\n");
            sb.Append("  AvailableShippingServiceOptions: ").Append(AvailableShippingServiceOptions).Append("\n");
            sb.Append("  AvailableLabelFormats: ").Append(AvailableLabelFormats).Append("\n");
            sb.Append("  AvailableFormatOptionsForLabel: ").Append(AvailableFormatOptionsForLabel).Append("\n");
            sb.Append("  RequiresAdditionalSellerInputs: ").Append(RequiresAdditionalSellerInputs).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShippingService);
        }

        /// <summary>
        /// Returns true if ShippingService instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingService to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingService input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ShippingServiceName == input.ShippingServiceName ||
                    (this.ShippingServiceName != null &&
                    this.ShippingServiceName.Equals(input.ShippingServiceName))
                ) &&
                (
                    this.CarrierName == input.CarrierName ||
                    (this.CarrierName != null &&
                    this.CarrierName.Equals(input.CarrierName))
                ) &&
                (
                    this.ShippingServiceId == input.ShippingServiceId ||
                    (this.ShippingServiceId != null &&
                    this.ShippingServiceId.Equals(input.ShippingServiceId))
                ) &&
                (
                    this.ShippingServiceOfferId == input.ShippingServiceOfferId ||
                    (this.ShippingServiceOfferId != null &&
                    this.ShippingServiceOfferId.Equals(input.ShippingServiceOfferId))
                ) &&
                (
                    this.ShipDate == input.ShipDate ||
                    (this.ShipDate != null &&
                    this.ShipDate.Equals(input.ShipDate))
                ) &&
                (
                    this.EarliestEstimatedDeliveryDate == input.EarliestEstimatedDeliveryDate ||
                    (this.EarliestEstimatedDeliveryDate != null &&
                    this.EarliestEstimatedDeliveryDate.Equals(input.EarliestEstimatedDeliveryDate))
                ) &&
                (
                    this.LatestEstimatedDeliveryDate == input.LatestEstimatedDeliveryDate ||
                    (this.LatestEstimatedDeliveryDate != null &&
                    this.LatestEstimatedDeliveryDate.Equals(input.LatestEstimatedDeliveryDate))
                ) &&
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) &&
                (
                    this.ShippingServiceOptions == input.ShippingServiceOptions ||
                    (this.ShippingServiceOptions != null &&
                    this.ShippingServiceOptions.Equals(input.ShippingServiceOptions))
                ) &&
                (
                    this.AvailableShippingServiceOptions == input.AvailableShippingServiceOptions ||
                    (this.AvailableShippingServiceOptions != null &&
                    this.AvailableShippingServiceOptions.Equals(input.AvailableShippingServiceOptions))
                ) &&
                (
                    this.AvailableLabelFormats == input.AvailableLabelFormats ||
                    (this.AvailableLabelFormats != null &&
                    this.AvailableLabelFormats.Equals(input.AvailableLabelFormats))
                ) &&
                (
                    this.AvailableFormatOptionsForLabel == input.AvailableFormatOptionsForLabel ||
                    (this.AvailableFormatOptionsForLabel != null &&
                    this.AvailableFormatOptionsForLabel.Equals(input.AvailableFormatOptionsForLabel))
                ) &&
                (
                    this.RequiresAdditionalSellerInputs == input.RequiresAdditionalSellerInputs ||
                    (this.RequiresAdditionalSellerInputs != null &&
                    this.RequiresAdditionalSellerInputs.Equals(input.RequiresAdditionalSellerInputs))
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
                int hashCode = 41;
                if (this.ShippingServiceName != null)
                    hashCode = hashCode * 59 + this.ShippingServiceName.GetHashCode();
                if (this.CarrierName != null)
                    hashCode = hashCode * 59 + this.CarrierName.GetHashCode();
                if (this.ShippingServiceId != null)
                    hashCode = hashCode * 59 + this.ShippingServiceId.GetHashCode();
                if (this.ShippingServiceOfferId != null)
                    hashCode = hashCode * 59 + this.ShippingServiceOfferId.GetHashCode();
                if (this.ShipDate != null)
                    hashCode = hashCode * 59 + this.ShipDate.GetHashCode();
                if (this.EarliestEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.EarliestEstimatedDeliveryDate.GetHashCode();
                if (this.LatestEstimatedDeliveryDate != null)
                    hashCode = hashCode * 59 + this.LatestEstimatedDeliveryDate.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.ShippingServiceOptions != null)
                    hashCode = hashCode * 59 + this.ShippingServiceOptions.GetHashCode();
                if (this.AvailableShippingServiceOptions != null)
                    hashCode = hashCode * 59 + this.AvailableShippingServiceOptions.GetHashCode();
                if (this.AvailableLabelFormats != null)
                    hashCode = hashCode * 59 + this.AvailableLabelFormats.GetHashCode();
                if (this.AvailableFormatOptionsForLabel != null)
                    hashCode = hashCode * 59 + this.AvailableFormatOptionsForLabel.GetHashCode();
                if (this.RequiresAdditionalSellerInputs != null)
                    hashCode = hashCode * 59 + this.RequiresAdditionalSellerInputs.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}