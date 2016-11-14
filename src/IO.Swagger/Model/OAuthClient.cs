/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.21432
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
    /// OAuthClient
    /// </summary>
    [DataContract]
    public partial class OAuthClient :  IEquatable<OAuthClient>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthClient" /> class.
        /// </summary>
        /// <param name="Name">The user-facing name of the client. Eg. MyCrm.</param>
        /// <param name="ClientSecret">The secret supplied to the OAuth Application.</param>
        /// <param name="GrantsAllowed">The grants allowed.</param>
        /// <param name="OwningUserId">The user who controls the OAuth App.</param>
        /// <param name="RedirectUri">Where OAuth authorization sessions are returned to.</param>
        public OAuthClient(string Name = null, string ClientSecret = null, string GrantsAllowed = null, string OwningUserId = null, string RedirectUri = null)
        {
            this.Name = Name;
            this.ClientSecret = ClientSecret;
            this.GrantsAllowed = GrantsAllowed;
            this.OwningUserId = OwningUserId;
            this.RedirectUri = RedirectUri;
        }
        
        /// <summary>
        /// The id of the OAuth Client
        /// </summary>
        /// <value>The id of the OAuth Client</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; private set; }
        /// <summary>
        /// The user-facing name of the client. Eg. MyCrm
        /// </summary>
        /// <value>The user-facing name of the client. Eg. MyCrm</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The secret supplied to the OAuth Application
        /// </summary>
        /// <value>The secret supplied to the OAuth Application</value>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }
        /// <summary>
        /// The grants allowed
        /// </summary>
        /// <value>The grants allowed</value>
        [DataMember(Name="grantsAllowed", EmitDefaultValue=false)]
        public string GrantsAllowed { get; set; }
        /// <summary>
        /// The user who controls the OAuth App
        /// </summary>
        /// <value>The user who controls the OAuth App</value>
        [DataMember(Name="owningUserId", EmitDefaultValue=false)]
        public string OwningUserId { get; set; }
        /// <summary>
        /// Where OAuth authorization sessions are returned to
        /// </summary>
        /// <value>Where OAuth authorization sessions are returned to</value>
        [DataMember(Name="redirectUri", EmitDefaultValue=false)]
        public string RedirectUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OAuthClient {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  GrantsAllowed: ").Append(GrantsAllowed).Append("\n");
            sb.Append("  OwningUserId: ").Append(OwningUserId).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
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
            return this.Equals(obj as OAuthClient);
        }

        /// <summary>
        /// Returns true if OAuthClient instances are equal
        /// </summary>
        /// <param name="other">Instance of OAuthClient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthClient other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Identifier == other.Identifier ||
                    this.Identifier != null &&
                    this.Identifier.Equals(other.Identifier)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    this.GrantsAllowed == other.GrantsAllowed ||
                    this.GrantsAllowed != null &&
                    this.GrantsAllowed.Equals(other.GrantsAllowed)
                ) && 
                (
                    this.OwningUserId == other.OwningUserId ||
                    this.OwningUserId != null &&
                    this.OwningUserId.Equals(other.OwningUserId)
                ) && 
                (
                    this.RedirectUri == other.RedirectUri ||
                    this.RedirectUri != null &&
                    this.RedirectUri.Equals(other.RedirectUri)
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
                if (this.Identifier != null)
                    hash = hash * 59 + this.Identifier.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                if (this.GrantsAllowed != null)
                    hash = hash * 59 + this.GrantsAllowed.GetHashCode();
                if (this.OwningUserId != null)
                    hash = hash * 59 + this.OwningUserId.GetHashCode();
                if (this.RedirectUri != null)
                    hash = hash * 59 + this.RedirectUri.GetHashCode();
                return hash;
            }
        }
    }

}
