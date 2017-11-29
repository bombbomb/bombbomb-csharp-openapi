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
    /// Configures a single prompt which asks a user to record a video into an outgoing email.
    /// </summary>
    [DataContract]
    public partial class VideoEmailPrompt :  IEquatable<VideoEmailPrompt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEmailPrompt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoEmailPrompt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoEmailPrompt" /> class.
        /// </summary>
        /// <param name="TemplateId">Optional. The email template to be used in the sent email, if none supplied, the users&#39; default will be applied..</param>
        /// <param name="EmailSubjectLine">The subject line of the final email (required).</param>
        /// <param name="EmailContent">The HTML content of the final email (required).</param>
        /// <param name="ThumbnailUrl">The URL of a thumbnail image for this prompt.</param>
        /// <param name="ContactId">Contact Id to send the final email to.</param>
        /// <param name="ToLists">List Ids to send the final email to.</param>
        /// <param name="JerichoId">If sent in a jericho context, this will have the jericho id.</param>
        /// <param name="PromptSubject">The prompt&#39;s subject line (required).</param>
        /// <param name="PromptHtml">The suggested script of the prompt. (required).</param>
        /// <param name="PromptIntro">A paragraph intro statement about the purpose of the email you&#39;re recording a video for..</param>
        /// <param name="ExampleVideoId">An example or explanatory video to help the user understand what to say..</param>
        /// <param name="FollowupVideoId">An example or explanatory video to help the user understand what to say..</param>
        /// <param name="SendWithoutVideo">Whether to send the email if no video is recorded. If set to require a video, and none is added before the videoDueDate, the prompt is cancelled..</param>
        /// <param name="VideoDueDate">When the video must be recorded by.</param>
        /// <param name="ScheduledSendDate">When the final email is scheduled to be sent (required).</param>
        /// <param name="PromptBotId">The bot that created the prompt..</param>
        /// <param name="ClientGroupId">The client group campaign that created the prompt..</param>
        /// <param name="ApplyTemplate">Controls whether a user template is applied to the message as it is sent.</param>
        /// <param name="CreatedDate">When the email was first sent out.</param>
        /// <param name="LastNotified">When the user was last notified about a prompt email waiting for a video.</param>
        /// <param name="FacebookMessage">The facebook message to be passed off to social sender.</param>
        /// <param name="TwitterMessage">The twitter message to be passed off to social sender.</param>
        /// <param name="LinkedinMessage">The linkedin message to be passed off to social sender.</param>
        /// <param name="SendMechanism">The sendMechanism property.</param>
        /// <param name="HasSocial">this determines whether or not it has a social content..</param>
        /// <param name="SendTypes">The types of mechanisms this prompt can send..</param>
        public VideoEmailPrompt(string TemplateId = null, string EmailSubjectLine = null, string EmailContent = null, string ThumbnailUrl = null, string ContactId = null, List<string> ToLists = null, string JerichoId = null, string PromptSubject = null, string PromptHtml = null, string PromptIntro = null, string ExampleVideoId = null, string FollowupVideoId = null, bool? SendWithoutVideo = null, DateTime? VideoDueDate = null, DateTime? ScheduledSendDate = null, string PromptBotId = null, string ClientGroupId = null, bool? ApplyTemplate = null, DateTime? CreatedDate = null, DateTime? LastNotified = null, string FacebookMessage = null, string TwitterMessage = null, string LinkedinMessage = null, string SendMechanism = null, bool? HasSocial = null, List<string> SendTypes = null)
        {
            // to ensure "EmailSubjectLine" is required (not null)
            if (EmailSubjectLine == null)
            {
                throw new InvalidDataException("EmailSubjectLine is a required property for VideoEmailPrompt and cannot be null");
            }
            else
            {
                this.EmailSubjectLine = EmailSubjectLine;
            }
            // to ensure "EmailContent" is required (not null)
            if (EmailContent == null)
            {
                throw new InvalidDataException("EmailContent is a required property for VideoEmailPrompt and cannot be null");
            }
            else
            {
                this.EmailContent = EmailContent;
            }
            // to ensure "PromptSubject" is required (not null)
            if (PromptSubject == null)
            {
                throw new InvalidDataException("PromptSubject is a required property for VideoEmailPrompt and cannot be null");
            }
            else
            {
                this.PromptSubject = PromptSubject;
            }
            // to ensure "PromptHtml" is required (not null)
            if (PromptHtml == null)
            {
                throw new InvalidDataException("PromptHtml is a required property for VideoEmailPrompt and cannot be null");
            }
            else
            {
                this.PromptHtml = PromptHtml;
            }
            // to ensure "ScheduledSendDate" is required (not null)
            if (ScheduledSendDate == null)
            {
                throw new InvalidDataException("ScheduledSendDate is a required property for VideoEmailPrompt and cannot be null");
            }
            else
            {
                this.ScheduledSendDate = ScheduledSendDate;
            }
            this.TemplateId = TemplateId;
            this.ThumbnailUrl = ThumbnailUrl;
            this.ContactId = ContactId;
            this.ToLists = ToLists;
            this.JerichoId = JerichoId;
            this.PromptIntro = PromptIntro;
            this.ExampleVideoId = ExampleVideoId;
            this.FollowupVideoId = FollowupVideoId;
            this.SendWithoutVideo = SendWithoutVideo;
            this.VideoDueDate = VideoDueDate;
            this.PromptBotId = PromptBotId;
            this.ClientGroupId = ClientGroupId;
            this.ApplyTemplate = ApplyTemplate;
            this.CreatedDate = CreatedDate;
            this.LastNotified = LastNotified;
            this.FacebookMessage = FacebookMessage;
            this.TwitterMessage = TwitterMessage;
            this.LinkedinMessage = LinkedinMessage;
            this.SendMechanism = SendMechanism;
            this.HasSocial = HasSocial;
            this.SendTypes = SendTypes;
        }
        
        /// <summary>
        /// The identifier of the prompt. Read Only.
        /// </summary>
        /// <value>The identifier of the prompt. Read Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The prompt&#39;s owner. Read Only.
        /// </summary>
        /// <value>The prompt&#39;s owner. Read Only.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; private set; }
        /// <summary>
        /// Optional. The email template to be used in the sent email, if none supplied, the users&#39; default will be applied.
        /// </summary>
        /// <value>Optional. The email template to be used in the sent email, if none supplied, the users&#39; default will be applied.</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// The subject line of the final email
        /// </summary>
        /// <value>The subject line of the final email</value>
        [DataMember(Name="emailSubjectLine", EmitDefaultValue=false)]
        public string EmailSubjectLine { get; set; }
        /// <summary>
        /// The HTML content of the final email
        /// </summary>
        /// <value>The HTML content of the final email</value>
        [DataMember(Name="emailContent", EmitDefaultValue=false)]
        public string EmailContent { get; set; }
        /// <summary>
        /// The URL of a thumbnail image for this prompt
        /// </summary>
        /// <value>The URL of a thumbnail image for this prompt</value>
        [DataMember(Name="thumbnailUrl", EmitDefaultValue=false)]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Contact Id to send the final email to
        /// </summary>
        /// <value>Contact Id to send the final email to</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }
        /// <summary>
        /// List Ids to send the final email to
        /// </summary>
        /// <value>List Ids to send the final email to</value>
        [DataMember(Name="toLists", EmitDefaultValue=false)]
        public List<string> ToLists { get; set; }
        /// <summary>
        /// If sent in a jericho context, this will have the jericho id
        /// </summary>
        /// <value>If sent in a jericho context, this will have the jericho id</value>
        [DataMember(Name="jerichoId", EmitDefaultValue=false)]
        public string JerichoId { get; set; }
        /// <summary>
        /// The prompt&#39;s subject line
        /// </summary>
        /// <value>The prompt&#39;s subject line</value>
        [DataMember(Name="promptSubject", EmitDefaultValue=false)]
        public string PromptSubject { get; set; }
        /// <summary>
        /// The suggested script of the prompt.
        /// </summary>
        /// <value>The suggested script of the prompt.</value>
        [DataMember(Name="promptHtml", EmitDefaultValue=false)]
        public string PromptHtml { get; set; }
        /// <summary>
        /// A paragraph intro statement about the purpose of the email you&#39;re recording a video for.
        /// </summary>
        /// <value>A paragraph intro statement about the purpose of the email you&#39;re recording a video for.</value>
        [DataMember(Name="promptIntro", EmitDefaultValue=false)]
        public string PromptIntro { get; set; }
        /// <summary>
        /// An example or explanatory video to help the user understand what to say.
        /// </summary>
        /// <value>An example or explanatory video to help the user understand what to say.</value>
        [DataMember(Name="exampleVideoId", EmitDefaultValue=false)]
        public string ExampleVideoId { get; set; }
        /// <summary>
        /// An example or explanatory video to help the user understand what to say.
        /// </summary>
        /// <value>An example or explanatory video to help the user understand what to say.</value>
        [DataMember(Name="followupVideoId", EmitDefaultValue=false)]
        public string FollowupVideoId { get; set; }
        /// <summary>
        /// Whether to send the email if no video is recorded. If set to require a video, and none is added before the videoDueDate, the prompt is cancelled.
        /// </summary>
        /// <value>Whether to send the email if no video is recorded. If set to require a video, and none is added before the videoDueDate, the prompt is cancelled.</value>
        [DataMember(Name="sendWithoutVideo", EmitDefaultValue=false)]
        public bool? SendWithoutVideo { get; set; }
        /// <summary>
        /// When the video must be recorded by
        /// </summary>
        /// <value>When the video must be recorded by</value>
        [DataMember(Name="videoDueDate", EmitDefaultValue=false)]
        public DateTime? VideoDueDate { get; set; }
        /// <summary>
        /// When the final email is scheduled to be sent
        /// </summary>
        /// <value>When the final email is scheduled to be sent</value>
        [DataMember(Name="scheduledSendDate", EmitDefaultValue=false)]
        public DateTime? ScheduledSendDate { get; set; }
        /// <summary>
        /// The video that was added to the prompt. Read Only.
        /// </summary>
        /// <value>The video that was added to the prompt. Read Only.</value>
        [DataMember(Name="videoId", EmitDefaultValue=false)]
        public string VideoId { get; private set; }
        /// <summary>
        /// The email that was created by the prompt Read Only.
        /// </summary>
        /// <value>The email that was created by the prompt Read Only.</value>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; private set; }
        /// <summary>
        /// The job sent by the prompt Read Only.
        /// </summary>
        /// <value>The job sent by the prompt Read Only.</value>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; private set; }
        /// <summary>
        /// The bot that created the prompt.
        /// </summary>
        /// <value>The bot that created the prompt.</value>
        [DataMember(Name="promptBotId", EmitDefaultValue=false)]
        public string PromptBotId { get; set; }
        /// <summary>
        /// The client group campaign that created the prompt.
        /// </summary>
        /// <value>The client group campaign that created the prompt.</value>
        [DataMember(Name="clientGroupId", EmitDefaultValue=false)]
        public string ClientGroupId { get; set; }
        /// <summary>
        /// The status of the prompt: created &#x3D; 0, sent &#x3D; 10, recorded &#x3D; 20, job_created &#x3D; 30, timed_out &#x3D; 40, declined &#x3D; 50 Read Only
        /// </summary>
        /// <value>The status of the prompt: created &#x3D; 0, sent &#x3D; 10, recorded &#x3D; 20, job_created &#x3D; 30, timed_out &#x3D; 40, declined &#x3D; 50 Read Only</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; private set; }
        /// <summary>
        /// Controls whether a user template is applied to the message as it is sent
        /// </summary>
        /// <value>Controls whether a user template is applied to the message as it is sent</value>
        [DataMember(Name="applyTemplate", EmitDefaultValue=false)]
        public bool? ApplyTemplate { get; set; }
        /// <summary>
        /// When the email was first sent out
        /// </summary>
        /// <value>When the email was first sent out</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// When the user was last notified about a prompt email waiting for a video
        /// </summary>
        /// <value>When the user was last notified about a prompt email waiting for a video</value>
        [DataMember(Name="lastNotified", EmitDefaultValue=false)]
        public DateTime? LastNotified { get; set; }
        /// <summary>
        /// The facebook message to be passed off to social sender
        /// </summary>
        /// <value>The facebook message to be passed off to social sender</value>
        [DataMember(Name="facebookMessage", EmitDefaultValue=false)]
        public string FacebookMessage { get; set; }
        /// <summary>
        /// The twitter message to be passed off to social sender
        /// </summary>
        /// <value>The twitter message to be passed off to social sender</value>
        [DataMember(Name="twitterMessage", EmitDefaultValue=false)]
        public string TwitterMessage { get; set; }
        /// <summary>
        /// The linkedin message to be passed off to social sender
        /// </summary>
        /// <value>The linkedin message to be passed off to social sender</value>
        [DataMember(Name="linkedinMessage", EmitDefaultValue=false)]
        public string LinkedinMessage { get; set; }
        /// <summary>
        /// The sendMechanism property
        /// </summary>
        /// <value>The sendMechanism property</value>
        [DataMember(Name="sendMechanism", EmitDefaultValue=false)]
        public string SendMechanism { get; set; }
        /// <summary>
        /// this determines whether or not it has a social content.
        /// </summary>
        /// <value>this determines whether or not it has a social content.</value>
        [DataMember(Name="hasSocial", EmitDefaultValue=false)]
        public bool? HasSocial { get; set; }
        /// <summary>
        /// The types of mechanisms this prompt can send.
        /// </summary>
        /// <value>The types of mechanisms this prompt can send.</value>
        [DataMember(Name="sendTypes", EmitDefaultValue=false)]
        public List<string> SendTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoEmailPrompt {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  EmailSubjectLine: ").Append(EmailSubjectLine).Append("\n");
            sb.Append("  EmailContent: ").Append(EmailContent).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  ToLists: ").Append(ToLists).Append("\n");
            sb.Append("  JerichoId: ").Append(JerichoId).Append("\n");
            sb.Append("  PromptSubject: ").Append(PromptSubject).Append("\n");
            sb.Append("  PromptHtml: ").Append(PromptHtml).Append("\n");
            sb.Append("  PromptIntro: ").Append(PromptIntro).Append("\n");
            sb.Append("  ExampleVideoId: ").Append(ExampleVideoId).Append("\n");
            sb.Append("  FollowupVideoId: ").Append(FollowupVideoId).Append("\n");
            sb.Append("  SendWithoutVideo: ").Append(SendWithoutVideo).Append("\n");
            sb.Append("  VideoDueDate: ").Append(VideoDueDate).Append("\n");
            sb.Append("  ScheduledSendDate: ").Append(ScheduledSendDate).Append("\n");
            sb.Append("  VideoId: ").Append(VideoId).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  PromptBotId: ").Append(PromptBotId).Append("\n");
            sb.Append("  ClientGroupId: ").Append(ClientGroupId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ApplyTemplate: ").Append(ApplyTemplate).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  LastNotified: ").Append(LastNotified).Append("\n");
            sb.Append("  FacebookMessage: ").Append(FacebookMessage).Append("\n");
            sb.Append("  TwitterMessage: ").Append(TwitterMessage).Append("\n");
            sb.Append("  LinkedinMessage: ").Append(LinkedinMessage).Append("\n");
            sb.Append("  SendMechanism: ").Append(SendMechanism).Append("\n");
            sb.Append("  HasSocial: ").Append(HasSocial).Append("\n");
            sb.Append("  SendTypes: ").Append(SendTypes).Append("\n");
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
            return this.Equals(obj as VideoEmailPrompt);
        }

        /// <summary>
        /// Returns true if VideoEmailPrompt instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoEmailPrompt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoEmailPrompt other)
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
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.EmailSubjectLine == other.EmailSubjectLine ||
                    this.EmailSubjectLine != null &&
                    this.EmailSubjectLine.Equals(other.EmailSubjectLine)
                ) && 
                (
                    this.EmailContent == other.EmailContent ||
                    this.EmailContent != null &&
                    this.EmailContent.Equals(other.EmailContent)
                ) && 
                (
                    this.ThumbnailUrl == other.ThumbnailUrl ||
                    this.ThumbnailUrl != null &&
                    this.ThumbnailUrl.Equals(other.ThumbnailUrl)
                ) && 
                (
                    this.ContactId == other.ContactId ||
                    this.ContactId != null &&
                    this.ContactId.Equals(other.ContactId)
                ) && 
                (
                    this.ToLists == other.ToLists ||
                    this.ToLists != null &&
                    this.ToLists.SequenceEqual(other.ToLists)
                ) && 
                (
                    this.JerichoId == other.JerichoId ||
                    this.JerichoId != null &&
                    this.JerichoId.Equals(other.JerichoId)
                ) && 
                (
                    this.PromptSubject == other.PromptSubject ||
                    this.PromptSubject != null &&
                    this.PromptSubject.Equals(other.PromptSubject)
                ) && 
                (
                    this.PromptHtml == other.PromptHtml ||
                    this.PromptHtml != null &&
                    this.PromptHtml.Equals(other.PromptHtml)
                ) && 
                (
                    this.PromptIntro == other.PromptIntro ||
                    this.PromptIntro != null &&
                    this.PromptIntro.Equals(other.PromptIntro)
                ) && 
                (
                    this.ExampleVideoId == other.ExampleVideoId ||
                    this.ExampleVideoId != null &&
                    this.ExampleVideoId.Equals(other.ExampleVideoId)
                ) && 
                (
                    this.FollowupVideoId == other.FollowupVideoId ||
                    this.FollowupVideoId != null &&
                    this.FollowupVideoId.Equals(other.FollowupVideoId)
                ) && 
                (
                    this.SendWithoutVideo == other.SendWithoutVideo ||
                    this.SendWithoutVideo != null &&
                    this.SendWithoutVideo.Equals(other.SendWithoutVideo)
                ) && 
                (
                    this.VideoDueDate == other.VideoDueDate ||
                    this.VideoDueDate != null &&
                    this.VideoDueDate.Equals(other.VideoDueDate)
                ) && 
                (
                    this.ScheduledSendDate == other.ScheduledSendDate ||
                    this.ScheduledSendDate != null &&
                    this.ScheduledSendDate.Equals(other.ScheduledSendDate)
                ) && 
                (
                    this.VideoId == other.VideoId ||
                    this.VideoId != null &&
                    this.VideoId.Equals(other.VideoId)
                ) && 
                (
                    this.EmailId == other.EmailId ||
                    this.EmailId != null &&
                    this.EmailId.Equals(other.EmailId)
                ) && 
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) && 
                (
                    this.PromptBotId == other.PromptBotId ||
                    this.PromptBotId != null &&
                    this.PromptBotId.Equals(other.PromptBotId)
                ) && 
                (
                    this.ClientGroupId == other.ClientGroupId ||
                    this.ClientGroupId != null &&
                    this.ClientGroupId.Equals(other.ClientGroupId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ApplyTemplate == other.ApplyTemplate ||
                    this.ApplyTemplate != null &&
                    this.ApplyTemplate.Equals(other.ApplyTemplate)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.LastNotified == other.LastNotified ||
                    this.LastNotified != null &&
                    this.LastNotified.Equals(other.LastNotified)
                ) && 
                (
                    this.FacebookMessage == other.FacebookMessage ||
                    this.FacebookMessage != null &&
                    this.FacebookMessage.Equals(other.FacebookMessage)
                ) && 
                (
                    this.TwitterMessage == other.TwitterMessage ||
                    this.TwitterMessage != null &&
                    this.TwitterMessage.Equals(other.TwitterMessage)
                ) && 
                (
                    this.LinkedinMessage == other.LinkedinMessage ||
                    this.LinkedinMessage != null &&
                    this.LinkedinMessage.Equals(other.LinkedinMessage)
                ) && 
                (
                    this.SendMechanism == other.SendMechanism ||
                    this.SendMechanism != null &&
                    this.SendMechanism.Equals(other.SendMechanism)
                ) && 
                (
                    this.HasSocial == other.HasSocial ||
                    this.HasSocial != null &&
                    this.HasSocial.Equals(other.HasSocial)
                ) && 
                (
                    this.SendTypes == other.SendTypes ||
                    this.SendTypes != null &&
                    this.SendTypes.SequenceEqual(other.SendTypes)
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
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.EmailSubjectLine != null)
                    hash = hash * 59 + this.EmailSubjectLine.GetHashCode();
                if (this.EmailContent != null)
                    hash = hash * 59 + this.EmailContent.GetHashCode();
                if (this.ThumbnailUrl != null)
                    hash = hash * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.ContactId != null)
                    hash = hash * 59 + this.ContactId.GetHashCode();
                if (this.ToLists != null)
                    hash = hash * 59 + this.ToLists.GetHashCode();
                if (this.JerichoId != null)
                    hash = hash * 59 + this.JerichoId.GetHashCode();
                if (this.PromptSubject != null)
                    hash = hash * 59 + this.PromptSubject.GetHashCode();
                if (this.PromptHtml != null)
                    hash = hash * 59 + this.PromptHtml.GetHashCode();
                if (this.PromptIntro != null)
                    hash = hash * 59 + this.PromptIntro.GetHashCode();
                if (this.ExampleVideoId != null)
                    hash = hash * 59 + this.ExampleVideoId.GetHashCode();
                if (this.FollowupVideoId != null)
                    hash = hash * 59 + this.FollowupVideoId.GetHashCode();
                if (this.SendWithoutVideo != null)
                    hash = hash * 59 + this.SendWithoutVideo.GetHashCode();
                if (this.VideoDueDate != null)
                    hash = hash * 59 + this.VideoDueDate.GetHashCode();
                if (this.ScheduledSendDate != null)
                    hash = hash * 59 + this.ScheduledSendDate.GetHashCode();
                if (this.VideoId != null)
                    hash = hash * 59 + this.VideoId.GetHashCode();
                if (this.EmailId != null)
                    hash = hash * 59 + this.EmailId.GetHashCode();
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();
                if (this.PromptBotId != null)
                    hash = hash * 59 + this.PromptBotId.GetHashCode();
                if (this.ClientGroupId != null)
                    hash = hash * 59 + this.ClientGroupId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ApplyTemplate != null)
                    hash = hash * 59 + this.ApplyTemplate.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.LastNotified != null)
                    hash = hash * 59 + this.LastNotified.GetHashCode();
                if (this.FacebookMessage != null)
                    hash = hash * 59 + this.FacebookMessage.GetHashCode();
                if (this.TwitterMessage != null)
                    hash = hash * 59 + this.TwitterMessage.GetHashCode();
                if (this.LinkedinMessage != null)
                    hash = hash * 59 + this.LinkedinMessage.GetHashCode();
                if (this.SendMechanism != null)
                    hash = hash * 59 + this.SendMechanism.GetHashCode();
                if (this.HasSocial != null)
                    hash = hash * 59 + this.HasSocial.GetHashCode();
                if (this.SendTypes != null)
                    hash = hash * 59 + this.SendTypes.GetHashCode();
                return hash;
            }
        }
    }

}
