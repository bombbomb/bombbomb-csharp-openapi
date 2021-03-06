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
    /// The Prompt\\Bot class
    /// </summary>
    [DataContract]
    public partial class PromptBot :  IEquatable<PromptBot>, IValidatableObject
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
        public PromptBot(string EmailId = default(string), string ListId = default(string), string Name = default(string), string ContactFieldValueColumn = default(string), DateTime? StartDate = default(DateTime?), DateTime? EndDate = default(DateTime?), string BotTypeId = default(string), string TemplateId = default(string), string VideoId = default(string), string Content = default(string), string Subject = default(string), string GeneratedBy = default(string))
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromptBot);
        }

        /// <summary>
        /// Returns true if PromptBot instances are equal
        /// </summary>
        /// <param name="input">Instance of PromptBot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptBot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.EmailId == input.EmailId ||
                    (this.EmailId != null &&
                    this.EmailId.Equals(input.EmailId))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactFieldValueColumn == input.ContactFieldValueColumn ||
                    (this.ContactFieldValueColumn != null &&
                    this.ContactFieldValueColumn.Equals(input.ContactFieldValueColumn))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.BotTypeId == input.BotTypeId ||
                    (this.BotTypeId != null &&
                    this.BotTypeId.Equals(input.BotTypeId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.VideoId == input.VideoId ||
                    (this.VideoId != null &&
                    this.VideoId.Equals(input.VideoId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.GeneratedBy == input.GeneratedBy ||
                    (this.GeneratedBy != null &&
                    this.GeneratedBy.Equals(input.GeneratedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.EmailId != null)
                    hashCode = hashCode * 59 + this.EmailId.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContactFieldValueColumn != null)
                    hashCode = hashCode * 59 + this.ContactFieldValueColumn.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.BotTypeId != null)
                    hashCode = hashCode * 59 + this.BotTypeId.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.VideoId != null)
                    hashCode = hashCode * 59 + this.VideoId.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.GeneratedBy != null)
                    hashCode = hashCode * 59 + this.GeneratedBy.GetHashCode();
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
