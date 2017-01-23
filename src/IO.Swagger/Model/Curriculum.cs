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
    /// The Curriculum class
    /// </summary>
    [DataContract]
    public partial class Curriculum :  IEquatable<Curriculum>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Curriculum" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="HtmlIntro">HTML formatted intro.</param>
        /// <param name="ImgUrl">URI of header image.</param>
        /// <param name="ItemCount">Number of curriculum items.</param>
        /// <param name="RenderAs">Render method for curriculum.</param>
        /// <param name="VisibleToAllUsers">Globally visible.</param>
        /// <param name="Progress">Collection of User Progress for Curriculum.</param>
        public Curriculum(string Id = null, string Name = null, string HtmlIntro = null, string ImgUrl = null, int? ItemCount = null, string RenderAs = null, bool? VisibleToAllUsers = null, List<CurriculumUserProgress> Progress = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.HtmlIntro = HtmlIntro;
            this.ImgUrl = ImgUrl;
            this.ItemCount = ItemCount;
            this.RenderAs = RenderAs;
            this.VisibleToAllUsers = VisibleToAllUsers;
            this.Progress = Progress;
        }
        
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// HTML formatted intro
        /// </summary>
        /// <value>HTML formatted intro</value>
        [DataMember(Name="htmlIntro", EmitDefaultValue=false)]
        public string HtmlIntro { get; set; }
        /// <summary>
        /// URI of header image
        /// </summary>
        /// <value>URI of header image</value>
        [DataMember(Name="imgUrl", EmitDefaultValue=false)]
        public string ImgUrl { get; set; }
        /// <summary>
        /// Number of curriculum items
        /// </summary>
        /// <value>Number of curriculum items</value>
        [DataMember(Name="itemCount", EmitDefaultValue=false)]
        public int? ItemCount { get; set; }
        /// <summary>
        /// Render method for curriculum
        /// </summary>
        /// <value>Render method for curriculum</value>
        [DataMember(Name="renderAs", EmitDefaultValue=false)]
        public string RenderAs { get; set; }
        /// <summary>
        /// Globally visible
        /// </summary>
        /// <value>Globally visible</value>
        [DataMember(Name="visibleToAllUsers", EmitDefaultValue=false)]
        public bool? VisibleToAllUsers { get; set; }
        /// <summary>
        /// Collection of User Progress for Curriculum
        /// </summary>
        /// <value>Collection of User Progress for Curriculum</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public List<CurriculumUserProgress> Progress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Curriculum {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  HtmlIntro: ").Append(HtmlIntro).Append("\n");
            sb.Append("  ImgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
            sb.Append("  RenderAs: ").Append(RenderAs).Append("\n");
            sb.Append("  VisibleToAllUsers: ").Append(VisibleToAllUsers).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(obj as Curriculum);
        }

        /// <summary>
        /// Returns true if Curriculum instances are equal
        /// </summary>
        /// <param name="other">Instance of Curriculum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Curriculum other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.HtmlIntro == other.HtmlIntro ||
                    this.HtmlIntro != null &&
                    this.HtmlIntro.Equals(other.HtmlIntro)
                ) && 
                (
                    this.ImgUrl == other.ImgUrl ||
                    this.ImgUrl != null &&
                    this.ImgUrl.Equals(other.ImgUrl)
                ) && 
                (
                    this.ItemCount == other.ItemCount ||
                    this.ItemCount != null &&
                    this.ItemCount.Equals(other.ItemCount)
                ) && 
                (
                    this.RenderAs == other.RenderAs ||
                    this.RenderAs != null &&
                    this.RenderAs.Equals(other.RenderAs)
                ) && 
                (
                    this.VisibleToAllUsers == other.VisibleToAllUsers ||
                    this.VisibleToAllUsers != null &&
                    this.VisibleToAllUsers.Equals(other.VisibleToAllUsers)
                ) && 
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.SequenceEqual(other.Progress)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.HtmlIntro != null)
                    hash = hash * 59 + this.HtmlIntro.GetHashCode();
                if (this.ImgUrl != null)
                    hash = hash * 59 + this.ImgUrl.GetHashCode();
                if (this.ItemCount != null)
                    hash = hash * 59 + this.ItemCount.GetHashCode();
                if (this.RenderAs != null)
                    hash = hash * 59 + this.RenderAs.GetHashCode();
                if (this.VisibleToAllUsers != null)
                    hash = hash * 59 + this.VisibleToAllUsers.GetHashCode();
                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();
                return hash;
            }
        }
    }

}
