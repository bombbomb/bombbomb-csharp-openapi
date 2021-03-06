/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.831
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The BBWebHook class
    /// </summary>
    [DataContract]
    public partial class BBWebHook :  IEquatable<BBWebHook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BBWebHook" /> class.
        /// </summary>
        /// <param name="UserId">The user to whom the webhook belongs.</param>
        /// <param name="HookId">The id of the hook.</param>
        /// <param name="Url">the url to send hook requests to.</param>
        /// <param name="IsHidden">Whether the hook is displayed to the user.</param>
        public BBWebHook(string UserId = default(string), int? HookId = default(int?), string Url = default(string), bool? IsHidden = default(bool?))
        {
            this.UserId = UserId;
            this.HookId = HookId;
            this.Url = Url;
            this.IsHidden = IsHidden;
        }
        
        /// <summary>
        /// The user to whom the webhook belongs
        /// </summary>
        /// <value>The user to whom the webhook belongs</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }

        /// <summary>
        /// The id of the hook
        /// </summary>
        /// <value>The id of the hook</value>
        [DataMember(Name="hookId", EmitDefaultValue=false)]
        public int? HookId { get; set; }

        /// <summary>
        /// the url to send hook requests to
        /// </summary>
        /// <value>the url to send hook requests to</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Whether the hook is displayed to the user
        /// </summary>
        /// <value>Whether the hook is displayed to the user</value>
        [DataMember(Name="isHidden", EmitDefaultValue=false)]
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BBWebHook {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  HookId: ").Append(HookId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
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
            return this.Equals(input as BBWebHook);
        }

        /// <summary>
        /// Returns true if BBWebHook instances are equal
        /// </summary>
        /// <param name="input">Instance of BBWebHook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BBWebHook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.HookId == input.HookId ||
                    (this.HookId != null &&
                    this.HookId.Equals(input.HookId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IsHidden == input.IsHidden ||
                    (this.IsHidden != null &&
                    this.IsHidden.Equals(input.IsHidden))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.HookId != null)
                    hashCode = hashCode * 59 + this.HookId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.IsHidden != null)
                    hashCode = hashCode * 59 + this.IsHidden.GetHashCode();
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
