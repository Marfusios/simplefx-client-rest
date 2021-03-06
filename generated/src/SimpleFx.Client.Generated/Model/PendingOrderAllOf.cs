/* 
 * SimpleFX
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = SimpleFx.Client.Generated.Client.OpenAPIDateConverter;

namespace SimpleFx.Client.Generated.Model
{
    /// <summary>
    /// PendingOrderAllOf
    /// </summary>
    [DataContract]
    public partial class PendingOrderAllOf :  IEquatable<PendingOrderAllOf>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public Direction Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingOrderAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PendingOrderAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingOrderAllOf" /> class.
        /// </summary>
        /// <param name="activationPrice">price at which this order executes at market (required).</param>
        /// <param name="direction">direction (required).</param>
        /// <param name="createTime">Unix time in miliseconds. (required).</param>
        /// <param name="expiryTime">Miliseconds since eopch, when this order ewill be automaticly removed..</param>
        public PendingOrderAllOf(decimal activationPrice = default(decimal), Direction direction = default(Direction), decimal createTime = default(decimal), decimal expiryTime = default(decimal))
        {
            // to ensure "activationPrice" is required (not null)
            if (activationPrice == null)
            {
                throw new InvalidDataException("activationPrice is a required property for PendingOrderAllOf and cannot be null");
            }
            else
            {
                this.ActivationPrice = activationPrice;
            }

            this.Direction = direction;
            // to ensure "createTime" is required (not null)
            if (createTime == null)
            {
                throw new InvalidDataException("createTime is a required property for PendingOrderAllOf and cannot be null");
            }
            else
            {
                this.CreateTime = createTime;
            }

            this.ExpiryTime = expiryTime;
        }
        
        /// <summary>
        /// price at which this order executes at market
        /// </summary>
        /// <value>price at which this order executes at market</value>
        [DataMember(Name="activationPrice", EmitDefaultValue=false)]
        public decimal ActivationPrice { get; set; }

        /// <summary>
        /// Unix time in miliseconds.
        /// </summary>
        /// <value>Unix time in miliseconds.</value>
        [DataMember(Name="createTime", EmitDefaultValue=false)]
        public decimal CreateTime { get; set; }

        /// <summary>
        /// Miliseconds since eopch, when this order ewill be automaticly removed.
        /// </summary>
        /// <value>Miliseconds since eopch, when this order ewill be automaticly removed.</value>
        [DataMember(Name="expiryTime", EmitDefaultValue=false)]
        public decimal ExpiryTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PendingOrderAllOf {\n");
            sb.Append("  ActivationPrice: ").Append(ActivationPrice).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ExpiryTime: ").Append(ExpiryTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as PendingOrderAllOf);
        }

        /// <summary>
        /// Returns true if PendingOrderAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PendingOrderAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PendingOrderAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationPrice == input.ActivationPrice ||
                    (this.ActivationPrice != null &&
                    this.ActivationPrice.Equals(input.ActivationPrice))
                ) && 
                (
                    this.Direction == input.Direction ||
                    this.Direction.Equals(input.Direction)
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    this.CreateTime.Equals(input.CreateTime)
                ) && 
                (
                    this.ExpiryTime == input.ExpiryTime ||
                    this.ExpiryTime.Equals(input.ExpiryTime)
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
                if (this.ActivationPrice != null)
                    hashCode = hashCode * 59 + this.ActivationPrice.GetHashCode();
                hashCode = hashCode * 59 + this.Direction.GetHashCode();
                hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiryTime.GetHashCode();
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
