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
    /// DeletePendingOrderModel
    /// </summary>
    [DataContract]
    public partial class DeletePendingOrderModel :  IEquatable<DeletePendingOrderModel>, IValidatableObject
    {
        /// <summary>
        /// Account LIVE or DEMO
        /// </summary>
        /// <value>Account LIVE or DEMO</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RealityEnum
        {
            /// <summary>
            /// Enum DEMO for value: DEMO
            /// </summary>
            [EnumMember(Value = "DEMO")]
            DEMO = 1,

            /// <summary>
            /// Enum LIVE for value: LIVE
            /// </summary>
            [EnumMember(Value = "LIVE")]
            LIVE = 2

        }

        /// <summary>
        /// Account LIVE or DEMO
        /// </summary>
        /// <value>Account LIVE or DEMO</value>
        [DataMember(Name="Reality", EmitDefaultValue=false)]
        public RealityEnum Reality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePendingOrderModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeletePendingOrderModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePendingOrderModel" /> class.
        /// </summary>
        /// <param name="id">Id of coresponding order (required).</param>
        /// <param name="requestId">requestId.</param>
        /// <param name="login">AccountNumber (required).</param>
        /// <param name="reality">Account LIVE or DEMO (required).</param>
        public DeletePendingOrderModel(long id = default(long), string requestId = default(string), long login = default(long), RealityEnum reality = default(RealityEnum))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DeletePendingOrderModel and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "login" is required (not null)
            if (login == null)
            {
                throw new InvalidDataException("login is a required property for DeletePendingOrderModel and cannot be null");
            }
            else
            {
                this.Login = login;
            }

            this.Reality = reality;
            this.RequestId = requestId;
        }
        
        /// <summary>
        /// Id of coresponding order
        /// </summary>
        /// <value>Id of coresponding order</value>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="RequestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// AccountNumber
        /// </summary>
        /// <value>AccountNumber</value>
        [DataMember(Name="Login", EmitDefaultValue=false)]
        public long Login { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletePendingOrderModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Reality: ").Append(Reality).Append("\n");
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
            return this.Equals(input as DeletePendingOrderModel);
        }

        /// <summary>
        /// Returns true if DeletePendingOrderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletePendingOrderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletePendingOrderModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.Login == input.Login ||
                    this.Login.Equals(input.Login)
                ) && 
                (
                    this.Reality == input.Reality ||
                    this.Reality.Equals(input.Reality)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                hashCode = hashCode * 59 + this.Login.GetHashCode();
                hashCode = hashCode * 59 + this.Reality.GetHashCode();
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
