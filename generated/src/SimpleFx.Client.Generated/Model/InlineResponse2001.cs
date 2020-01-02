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
    /// InlineResponse2001
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001 :  IEquatable<InlineResponse2001>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001" /> class.
        /// </summary>
        /// <param name="symbol">Instrument symbol (ticker).</param>
        /// <param name="priceCurrency">Currency in which this instrument is quoted..</param>
        /// <param name="marginCurrency">Currency in which this instrument is valued..</param>
        /// <param name="quote">quote.</param>
        /// <param name="marginPercentage">Margin requirments for this instrument.   Required margin for transaciton is PRICE*marginPercentage/100*volume*contractSize/account.leverage.</param>
        /// <param name="contractSize">Size of transaciton with volume of 1 aka Multiplier..</param>
        /// <param name="step">Allowed volume trading precision and minimum transaciton size for this instrument..</param>
        /// <param name="maxSize">Maximum trading volume for single request..</param>
        /// <param name="longOnly">If only long positions (BUY) are allowed for this symbol..</param>
        /// <param name="sessions">Trade sessions describes time when this instrument is tradable.</param>
        public InlineResponse2001(string symbol = default(string), string priceCurrency = default(string), string marginCurrency = default(string), UtilsInstrumentsJsonQuote quote = default(UtilsInstrumentsJsonQuote), double marginPercentage = default(double), double contractSize = default(double), double step = default(double), double maxSize = default(double), bool longOnly = default(bool), List<UtilsInstrumentsJsonSessions> sessions = default(List<UtilsInstrumentsJsonSessions>))
        {
            this.Symbol = symbol;
            this.PriceCurrency = priceCurrency;
            this.MarginCurrency = marginCurrency;
            this.Quote = quote;
            this.MarginPercentage = marginPercentage;
            this.ContractSize = contractSize;
            this.Step = step;
            this.MaxSize = maxSize;
            this.LongOnly = longOnly;
            this.Sessions = sessions;
        }
        
        /// <summary>
        /// Instrument symbol (ticker)
        /// </summary>
        /// <value>Instrument symbol (ticker)</value>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Currency in which this instrument is quoted.
        /// </summary>
        /// <value>Currency in which this instrument is quoted.</value>
        [DataMember(Name="priceCurrency", EmitDefaultValue=false)]
        public string PriceCurrency { get; set; }

        /// <summary>
        /// Currency in which this instrument is valued.
        /// </summary>
        /// <value>Currency in which this instrument is valued.</value>
        [DataMember(Name="marginCurrency", EmitDefaultValue=false)]
        public string MarginCurrency { get; set; }

        /// <summary>
        /// Gets or Sets Quote
        /// </summary>
        [DataMember(Name="quote", EmitDefaultValue=false)]
        public UtilsInstrumentsJsonQuote Quote { get; set; }

        /// <summary>
        /// Margin requirments for this instrument.   Required margin for transaciton is PRICE*marginPercentage/100*volume*contractSize/account.leverage
        /// </summary>
        /// <value>Margin requirments for this instrument.   Required margin for transaciton is PRICE*marginPercentage/100*volume*contractSize/account.leverage</value>
        [DataMember(Name="marginPercentage", EmitDefaultValue=false)]
        public double MarginPercentage { get; set; }

        /// <summary>
        /// Size of transaciton with volume of 1 aka Multiplier.
        /// </summary>
        /// <value>Size of transaciton with volume of 1 aka Multiplier.</value>
        [DataMember(Name="contractSize", EmitDefaultValue=false)]
        public double ContractSize { get; set; }

        /// <summary>
        /// Allowed volume trading precision and minimum transaciton size for this instrument.
        /// </summary>
        /// <value>Allowed volume trading precision and minimum transaciton size for this instrument.</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public double Step { get; set; }

        /// <summary>
        /// Maximum trading volume for single request.
        /// </summary>
        /// <value>Maximum trading volume for single request.</value>
        [DataMember(Name="maxSize", EmitDefaultValue=false)]
        public double MaxSize { get; set; }

        /// <summary>
        /// If only long positions (BUY) are allowed for this symbol.
        /// </summary>
        /// <value>If only long positions (BUY) are allowed for this symbol.</value>
        [DataMember(Name="longOnly", EmitDefaultValue=false)]
        public bool LongOnly { get; set; }

        /// <summary>
        /// Trade sessions describes time when this instrument is tradable
        /// </summary>
        /// <value>Trade sessions describes time when this instrument is tradable</value>
        [DataMember(Name="sessions", EmitDefaultValue=false)]
        public List<UtilsInstrumentsJsonSessions> Sessions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001 {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  PriceCurrency: ").Append(PriceCurrency).Append("\n");
            sb.Append("  MarginCurrency: ").Append(MarginCurrency).Append("\n");
            sb.Append("  Quote: ").Append(Quote).Append("\n");
            sb.Append("  MarginPercentage: ").Append(MarginPercentage).Append("\n");
            sb.Append("  ContractSize: ").Append(ContractSize).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  MaxSize: ").Append(MaxSize).Append("\n");
            sb.Append("  LongOnly: ").Append(LongOnly).Append("\n");
            sb.Append("  Sessions: ").Append(Sessions).Append("\n");
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
            return this.Equals(input as InlineResponse2001);
        }

        /// <summary>
        /// Returns true if InlineResponse2001 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2001 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.PriceCurrency == input.PriceCurrency ||
                    (this.PriceCurrency != null &&
                    this.PriceCurrency.Equals(input.PriceCurrency))
                ) && 
                (
                    this.MarginCurrency == input.MarginCurrency ||
                    (this.MarginCurrency != null &&
                    this.MarginCurrency.Equals(input.MarginCurrency))
                ) && 
                (
                    this.Quote == input.Quote ||
                    (this.Quote != null &&
                    this.Quote.Equals(input.Quote))
                ) && 
                (
                    this.MarginPercentage == input.MarginPercentage ||
                    this.MarginPercentage.Equals(input.MarginPercentage)
                ) && 
                (
                    this.ContractSize == input.ContractSize ||
                    this.ContractSize.Equals(input.ContractSize)
                ) && 
                (
                    this.Step == input.Step ||
                    this.Step.Equals(input.Step)
                ) && 
                (
                    this.MaxSize == input.MaxSize ||
                    this.MaxSize.Equals(input.MaxSize)
                ) && 
                (
                    this.LongOnly == input.LongOnly ||
                    this.LongOnly.Equals(input.LongOnly)
                ) && 
                (
                    this.Sessions == input.Sessions ||
                    this.Sessions != null &&
                    input.Sessions != null &&
                    this.Sessions.SequenceEqual(input.Sessions)
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
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.PriceCurrency != null)
                    hashCode = hashCode * 59 + this.PriceCurrency.GetHashCode();
                if (this.MarginCurrency != null)
                    hashCode = hashCode * 59 + this.MarginCurrency.GetHashCode();
                if (this.Quote != null)
                    hashCode = hashCode * 59 + this.Quote.GetHashCode();
                hashCode = hashCode * 59 + this.MarginPercentage.GetHashCode();
                hashCode = hashCode * 59 + this.ContractSize.GetHashCode();
                hashCode = hashCode * 59 + this.Step.GetHashCode();
                hashCode = hashCode * 59 + this.MaxSize.GetHashCode();
                hashCode = hashCode * 59 + this.LongOnly.GetHashCode();
                if (this.Sessions != null)
                    hashCode = hashCode * 59 + this.Sessions.GetHashCode();
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
