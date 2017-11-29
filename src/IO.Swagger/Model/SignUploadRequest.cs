/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.25797
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// The SignUploadRequest class
    /// </summary>
    [DataContract]
    public partial class SignUploadRequest :  IEquatable<SignUploadRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUploadRequest" /> class.
        /// </summary>
        /// <param name="Expiration">when the upload will expire..</param>
        /// <param name="Conditions">Key/Value object of request conditions..</param>
        public SignUploadRequest(DateTime? Expiration = null, Object Conditions = null)
        {
            this.Expiration = Expiration;
            this.Conditions = Conditions;
        }
        
        /// <summary>
        /// when the upload will expire.
        /// </summary>
        /// <value>when the upload will expire.</value>
        [DataMember(Name="expiration", EmitDefaultValue=false)]
        public DateTime? Expiration { get; set; }
        /// <summary>
        /// Key/Value object of request conditions.
        /// </summary>
        /// <value>Key/Value object of request conditions.</value>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public Object Conditions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignUploadRequest {\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as SignUploadRequest);
        }

        /// <summary>
        /// Returns true if SignUploadRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of SignUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignUploadRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Expiration == other.Expiration ||
                    this.Expiration != null &&
                    this.Expiration.Equals(other.Expiration)
                ) && 
                (
                    this.Conditions == other.Conditions ||
                    this.Conditions != null &&
                    this.Conditions.Equals(other.Conditions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Expiration != null)
                    hash = hash * 59 + this.Expiration.GetHashCode();
                if (this.Conditions != null)
                    hash = hash * 59 + this.Conditions.GetHashCode();
                return hash;
            }
        }
    }

}
