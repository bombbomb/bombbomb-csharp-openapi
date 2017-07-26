/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.24005
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
    /// The Prompt\\Bot class
    /// </summary>
    [DataContract]
    public partial class PromptBot :  IEquatable<PromptBot>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBot" /> class.
        /// </summary>
        /// <param name="EmailId">The default email being sent to contacts in the prompt bot list..</param>
        /// <param name="ListId">The list to attach the Prompt Bot to..</param>
        /// <param name="Name">The name of the bot..</param>
        /// <param name="ContactFieldValueColumn">The custom contact field value column used for this bot..</param>
        /// <param name="StartDate">when the bot started.</param>
        /// <param name="EndDate">when the bot should finish.</param>
        /// <param name="BotTypeId">The type of bot..</param>
        /// <param name="TemplateId">The template id used to generate the default email..</param>
        /// <param name="VideoId">The video that was added to the prompt..</param>
        /// <param name="Content">The content to use in the email..</param>
        /// <param name="Subject">The subject of the default email..</param>
        /// <param name="GeneratedBy">Set when generated as a default by a bot..</param>
        public PromptBot(string EmailId = null, string ListId = null, string Name = null, string ContactFieldValueColumn = null, DateTime? StartDate = null, DateTime? EndDate = null, string BotTypeId = null, string TemplateId = null, string VideoId = null, string Content = null, string Subject = null, string GeneratedBy = null)
        {
            this.EmailId = EmailId;
            this.ListId = ListId;
            this.Name = Name;
            this.ContactFieldValueColumn = ContactFieldValueColumn;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.BotTypeId = BotTypeId;
            this.TemplateId = TemplateId;
            this.VideoId = VideoId;
            this.Content = Content;
            this.Subject = Subject;
            this.GeneratedBy = GeneratedBy;
        }
        
        /// <summary>
        /// The identifier of the prompt bot. Read Only.
        /// </summary>
        /// <value>The identifier of the prompt bot. Read Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The prompt bot&#39;s owner. Read Only.
        /// </summary>
        /// <value>The prompt bot&#39;s owner. Read Only.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; private set; }
        /// <summary>
        /// The default email being sent to contacts in the prompt bot list.
        /// </summary>
        /// <value>The default email being sent to contacts in the prompt bot list.</value>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; set; }
        /// <summary>
        /// The list to attach the Prompt Bot to.
        /// </summary>
        /// <value>The list to attach the Prompt Bot to.</value>
        [DataMember(Name="listId", EmitDefaultValue=false)]
        public string ListId { get; set; }
        /// <summary>
        /// The name of the bot.
        /// </summary>
        /// <value>The name of the bot.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The custom contact field value column used for this bot.
        /// </summary>
        /// <value>The custom contact field value column used for this bot.</value>
        [DataMember(Name="contactFieldValueColumn", EmitDefaultValue=false)]
        public string ContactFieldValueColumn { get; set; }
        /// <summary>
        /// The status of the prompt bot. Read Only.
        /// </summary>
        /// <value>The status of the prompt bot. Read Only.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; private set; }
        /// <summary>
        /// when the bot started
        /// </summary>
        /// <value>when the bot started</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// when the bot should finish
        /// </summary>
        /// <value>when the bot should finish</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// The type of bot.
        /// </summary>
        /// <value>The type of bot.</value>
        [DataMember(Name="botTypeId", EmitDefaultValue=false)]
        public string BotTypeId { get; set; }
        /// <summary>
        /// The template id used to generate the default email.
        /// </summary>
        /// <value>The template id used to generate the default email.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// The video that was added to the prompt.
        /// </summary>
        /// <value>The video that was added to the prompt.</value>
        [DataMember(Name="videoId", EmitDefaultValue=false)]
        public string VideoId { get; set; }
        /// <summary>
        /// The content to use in the email.
        /// </summary>
        /// <value>The content to use in the email.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// The subject of the default email.
        /// </summary>
        /// <value>The subject of the default email.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        /// <summary>
        /// Set when generated as a default by a bot.
        /// </summary>
        /// <value>Set when generated as a default by a bot.</value>
        [DataMember(Name="generatedBy", EmitDefaultValue=false)]
        public string GeneratedBy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromptBot {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactFieldValueColumn: ").Append(ContactFieldValueColumn).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  BotTypeId: ").Append(BotTypeId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  VideoId: ").Append(VideoId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  GeneratedBy: ").Append(GeneratedBy).Append("\n");
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
            return this.Equals(obj as PromptBot);
        }

        /// <summary>
        /// Returns true if PromptBot instances are equal
        /// </summary>
        /// <param name="other">Instance of PromptBot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptBot other)
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
                    this.EmailId == other.EmailId ||
                    this.EmailId != null &&
                    this.EmailId.Equals(other.EmailId)
                ) && 
                (
                    this.ListId == other.ListId ||
                    this.ListId != null &&
                    this.ListId.Equals(other.ListId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ContactFieldValueColumn == other.ContactFieldValueColumn ||
                    this.ContactFieldValueColumn != null &&
                    this.ContactFieldValueColumn.Equals(other.ContactFieldValueColumn)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StartDate == other.StartDate ||
                    this.StartDate != null &&
                    this.StartDate.Equals(other.StartDate)
                ) && 
                (
                    this.EndDate == other.EndDate ||
                    this.EndDate != null &&
                    this.EndDate.Equals(other.EndDate)
                ) && 
                (
                    this.BotTypeId == other.BotTypeId ||
                    this.BotTypeId != null &&
                    this.BotTypeId.Equals(other.BotTypeId)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.VideoId == other.VideoId ||
                    this.VideoId != null &&
                    this.VideoId.Equals(other.VideoId)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.GeneratedBy == other.GeneratedBy ||
                    this.GeneratedBy != null &&
                    this.GeneratedBy.Equals(other.GeneratedBy)
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
                if (this.EmailId != null)
                    hash = hash * 59 + this.EmailId.GetHashCode();
                if (this.ListId != null)
                    hash = hash * 59 + this.ListId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ContactFieldValueColumn != null)
                    hash = hash * 59 + this.ContactFieldValueColumn.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StartDate != null)
                    hash = hash * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hash = hash * 59 + this.EndDate.GetHashCode();
                if (this.BotTypeId != null)
                    hash = hash * 59 + this.BotTypeId.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.VideoId != null)
                    hash = hash * 59 + this.VideoId.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.GeneratedBy != null)
                    hash = hash * 59 + this.GeneratedBy.GetHashCode();
                return hash;
            }
        }
    }

}
