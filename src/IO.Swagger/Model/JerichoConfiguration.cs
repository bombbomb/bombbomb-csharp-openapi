/* 
 * BombBomb
 *
 * We make it easy to build relationships using simple videos.
 *
 * OpenAPI spec version: 2.0.20679
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
    /// JerichoConfiguration
    /// </summary>
    [DataContract]
    public partial class JerichoConfiguration :  IEquatable<JerichoConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JerichoConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JerichoConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JerichoConfiguration" /> class.
        /// </summary>
        /// <param name="SendDate">When the email should be sent..</param>
        /// <param name="IsPrompt">Determines whether this is a static or prompted send. (required).</param>
        /// <param name="EmailId">Static send: The Email to send on behalf of the group members..</param>
        /// <param name="PromptSubject">Video Prompt: The subject line prompting the user to record a video..</param>
        /// <param name="PromptBody">Video Prompt: The HTML body of the email prompting the user to record a video..</param>
        /// <param name="EmailSubject">Video Prompt: The subject line of the final sent email.</param>
        /// <param name="EmailBody">Video Prompt: The HTML body of the final sent email..</param>
        /// <param name="SendWithoutVideo">Video Prompt: Whether to send the final email if no video was recorded..</param>
        public JerichoConfiguration(DateTime? SendDate = null, bool? IsPrompt = null, string EmailId = null, string PromptSubject = null, string PromptBody = null, string EmailSubject = null, string EmailBody = null, bool? SendWithoutVideo = null)
        {
            // to ensure "IsPrompt" is required (not null)
            if (IsPrompt == null)
            {
                throw new InvalidDataException("IsPrompt is a required property for JerichoConfiguration and cannot be null");
            }
            else
            {
                this.IsPrompt = IsPrompt;
            }
            this.SendDate = SendDate;
            this.EmailId = EmailId;
            this.PromptSubject = PromptSubject;
            this.PromptBody = PromptBody;
            this.EmailSubject = EmailSubject;
            this.EmailBody = EmailBody;
            this.SendWithoutVideo = SendWithoutVideo;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets ClientGroupId
        /// </summary>
        [DataMember(Name="clientGroupId", EmitDefaultValue=false)]
        public string ClientGroupId { get; private set; }
        /// <summary>
        /// When the email should be sent.
        /// </summary>
        /// <value>When the email should be sent.</value>
        [DataMember(Name="sendDate", EmitDefaultValue=false)]
        public DateTime? SendDate { get; set; }
        /// <summary>
        /// Determines whether this is a static or prompted send.
        /// </summary>
        /// <value>Determines whether this is a static or prompted send.</value>
        [DataMember(Name="isPrompt", EmitDefaultValue=false)]
        public bool? IsPrompt { get; set; }
        /// <summary>
        /// Static send: The Email to send on behalf of the group members.
        /// </summary>
        /// <value>Static send: The Email to send on behalf of the group members.</value>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; set; }
        /// <summary>
        /// Video Prompt: The subject line prompting the user to record a video.
        /// </summary>
        /// <value>Video Prompt: The subject line prompting the user to record a video.</value>
        [DataMember(Name="promptSubject", EmitDefaultValue=false)]
        public string PromptSubject { get; set; }
        /// <summary>
        /// Video Prompt: The HTML body of the email prompting the user to record a video.
        /// </summary>
        /// <value>Video Prompt: The HTML body of the email prompting the user to record a video.</value>
        [DataMember(Name="promptBody", EmitDefaultValue=false)]
        public string PromptBody { get; set; }
        /// <summary>
        /// Video Prompt: The subject line of the final sent email
        /// </summary>
        /// <value>Video Prompt: The subject line of the final sent email</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=false)]
        public string EmailSubject { get; set; }
        /// <summary>
        /// Video Prompt: The HTML body of the final sent email.
        /// </summary>
        /// <value>Video Prompt: The HTML body of the final sent email.</value>
        [DataMember(Name="emailBody", EmitDefaultValue=false)]
        public string EmailBody { get; set; }
        /// <summary>
        /// Video Prompt: Whether to send the final email if no video was recorded.
        /// </summary>
        /// <value>Video Prompt: Whether to send the final email if no video was recorded.</value>
        [DataMember(Name="sendWithoutVideo", EmitDefaultValue=false)]
        public bool? SendWithoutVideo { get; set; }
        /// <summary>
        /// The state of the send.
        /// </summary>
        /// <value>The state of the send.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JerichoConfiguration {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClientGroupId: ").Append(ClientGroupId).Append("\n");
            sb.Append("  SendDate: ").Append(SendDate).Append("\n");
            sb.Append("  IsPrompt: ").Append(IsPrompt).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  PromptSubject: ").Append(PromptSubject).Append("\n");
            sb.Append("  PromptBody: ").Append(PromptBody).Append("\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  EmailBody: ").Append(EmailBody).Append("\n");
            sb.Append("  SendWithoutVideo: ").Append(SendWithoutVideo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as JerichoConfiguration);
        }

        /// <summary>
        /// Returns true if JerichoConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of JerichoConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JerichoConfiguration other)
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
                    this.ClientGroupId == other.ClientGroupId ||
                    this.ClientGroupId != null &&
                    this.ClientGroupId.Equals(other.ClientGroupId)
                ) && 
                (
                    this.SendDate == other.SendDate ||
                    this.SendDate != null &&
                    this.SendDate.Equals(other.SendDate)
                ) && 
                (
                    this.IsPrompt == other.IsPrompt ||
                    this.IsPrompt != null &&
                    this.IsPrompt.Equals(other.IsPrompt)
                ) && 
                (
                    this.EmailId == other.EmailId ||
                    this.EmailId != null &&
                    this.EmailId.Equals(other.EmailId)
                ) && 
                (
                    this.PromptSubject == other.PromptSubject ||
                    this.PromptSubject != null &&
                    this.PromptSubject.Equals(other.PromptSubject)
                ) && 
                (
                    this.PromptBody == other.PromptBody ||
                    this.PromptBody != null &&
                    this.PromptBody.Equals(other.PromptBody)
                ) && 
                (
                    this.EmailSubject == other.EmailSubject ||
                    this.EmailSubject != null &&
                    this.EmailSubject.Equals(other.EmailSubject)
                ) && 
                (
                    this.EmailBody == other.EmailBody ||
                    this.EmailBody != null &&
                    this.EmailBody.Equals(other.EmailBody)
                ) && 
                (
                    this.SendWithoutVideo == other.SendWithoutVideo ||
                    this.SendWithoutVideo != null &&
                    this.SendWithoutVideo.Equals(other.SendWithoutVideo)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.ClientGroupId != null)
                    hash = hash * 59 + this.ClientGroupId.GetHashCode();
                if (this.SendDate != null)
                    hash = hash * 59 + this.SendDate.GetHashCode();
                if (this.IsPrompt != null)
                    hash = hash * 59 + this.IsPrompt.GetHashCode();
                if (this.EmailId != null)
                    hash = hash * 59 + this.EmailId.GetHashCode();
                if (this.PromptSubject != null)
                    hash = hash * 59 + this.PromptSubject.GetHashCode();
                if (this.PromptBody != null)
                    hash = hash * 59 + this.PromptBody.GetHashCode();
                if (this.EmailSubject != null)
                    hash = hash * 59 + this.EmailSubject.GetHashCode();
                if (this.EmailBody != null)
                    hash = hash * 59 + this.EmailBody.GetHashCode();
                if (this.SendWithoutVideo != null)
                    hash = hash * 59 + this.SendWithoutVideo.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}
