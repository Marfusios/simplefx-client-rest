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
    /// Defines Side
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Side
    {
        /// <summary>
        /// Enum BUY for value: BUY
        /// </summary>
        [EnumMember(Value = "BUY")]
        BUY = 1,

        /// <summary>
        /// Enum SELL for value: SELL
        /// </summary>
        [EnumMember(Value = "SELL")]
        SELL = 2

    }

}
