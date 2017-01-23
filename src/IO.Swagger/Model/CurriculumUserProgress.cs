/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.22196
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
    /// The CurriculumUserProgress class
    /// </summary>
    [DataContract]
    public partial class CurriculumUserProgress :  IEquatable<CurriculumUserProgress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurriculumUserProgress" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UserId">User Id.</param>
        /// <param name="CurriculumItemId">Curriculum Item Id.</param>
        /// <param name="CurriculumId">Curriculum Id.</param>
        /// <param name="CompletedDate">When the final email is scheduled to be sent.</param>
        public CurriculumUserProgress(string Id = null, string UserId = null, string CurriculumItemId = null, string CurriculumId = null, DateTime? CompletedDate = null)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.CurriculumItemId = CurriculumItemId;
            this.CurriculumId = CurriculumId;
            this.CompletedDate = CompletedDate;
        }
        
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// User Id
        /// </summary>
        /// <value>User Id</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Curriculum Item Id
        /// </summary>
        /// <value>Curriculum Item Id</value>
        [DataMember(Name="curriculumItemId", EmitDefaultValue=false)]
        public string CurriculumItemId { get; set; }
        /// <summary>
        /// Curriculum Id
        /// </summary>
        /// <value>Curriculum Id</value>
        [DataMember(Name="curriculumId", EmitDefaultValue=false)]
        public string CurriculumId { get; set; }
        /// <summary>
        /// When the final email is scheduled to be sent
        /// </summary>
        /// <value>When the final email is scheduled to be sent</value>
        [DataMember(Name="completedDate", EmitDefaultValue=false)]
        public DateTime? CompletedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurriculumUserProgress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CurriculumItemId: ").Append(CurriculumItemId).Append("\n");
            sb.Append("  CurriculumId: ").Append(CurriculumId).Append("\n");
            sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
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
            return this.Equals(obj as CurriculumUserProgress);
        }

        /// <summary>
        /// Returns true if CurriculumUserProgress instances are equal
        /// </summary>
        /// <param name="other">Instance of CurriculumUserProgress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurriculumUserProgress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.CurriculumItemId == other.CurriculumItemId ||
                    this.CurriculumItemId != null &&
                    this.CurriculumItemId.Equals(other.CurriculumItemId)
                ) && 
                (
                    this.CurriculumId == other.CurriculumId ||
                    this.CurriculumId != null &&
                    this.CurriculumId.Equals(other.CurriculumId)
                ) && 
                (
                    this.CompletedDate == other.CompletedDate ||
                    this.CompletedDate != null &&
                    this.CompletedDate.Equals(other.CompletedDate)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.CurriculumItemId != null)
                    hash = hash * 59 + this.CurriculumItemId.GetHashCode();
                if (this.CurriculumId != null)
                    hash = hash * 59 + this.CurriculumId.GetHashCode();
                if (this.CompletedDate != null)
                    hash = hash * 59 + this.CompletedDate.GetHashCode();
                return hash;
            }
        }
    }

}
