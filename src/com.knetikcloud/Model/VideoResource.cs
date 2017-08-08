/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com.
 *
 * OpenAPI spec version: latest 
 * Contact: support@knetik.com
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
using SwaggerDateConverter = com.knetikcloud.Client.SwaggerDateConverter;

namespace com.knetikcloud.Model
{
    /// <summary>
    /// VideoResource
    /// </summary>
    [DataContract]
    public partial class VideoResource :  IEquatable<VideoResource>, IValidatableObject
    {
        /// <summary>
        /// The privacy setting. default: private
        /// </summary>
        /// <value>The privacy setting. default: private</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PrivacyEnum
        {
            
            /// <summary>
            /// Enum Private for "private"
            /// </summary>
            [EnumMember(Value = "private")]
            Private,
            
            /// <summary>
            /// Enum Friends for "friends"
            /// </summary>
            [EnumMember(Value = "friends")]
            Friends,
            
            /// <summary>
            /// Enum Public for "public"
            /// </summary>
            [EnumMember(Value = "public")]
            Public
        }

        /// <summary>
        /// The privacy setting. default: private
        /// </summary>
        /// <value>The privacy setting. default: private</value>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public PrivacyEnum? Privacy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VideoResource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoResource" /> class.
        /// </summary>
        /// <param name="Author">The original artist of the media.</param>
        /// <param name="Authored">The date the media was created as a unix timestamp in seconds.</param>
        /// <param name="Category">The category of the video (required).</param>
        /// <param name="Comments">The comments of the video.</param>
        /// <param name="Contributors">Artists that contributed to the creation. See separate endpoint to add to list.</param>
        /// <param name="Embed">The country of an embedable version.</param>
        /// <param name="Extension">The file extension of the media file. 1-5 characters (required).</param>
        /// <param name="Height">The height of the video in px (required).</param>
        /// <param name="Length">The length of the video in seconds (required).</param>
        /// <param name="Location">The country of the media. Typically a url. Cannot be blank (required).</param>
        /// <param name="LongDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="MimeType">The mime-type of the media.</param>
        /// <param name="Name">The user friendly name of that resource (required).</param>
        /// <param name="Priority">The sort order of the video. default: 100.</param>
        /// <param name="Privacy">The privacy setting. default: private.</param>
        /// <param name="Published">Whether the video has been made public. Default true.</param>
        /// <param name="ShortDescription">The user friendly name of that resource. Defaults to blank string.</param>
        /// <param name="Size">The size of the media. Minimum 0 if supplied.</param>
        /// <param name="Tags">The tags for the video.</param>
        /// <param name="Thumbnail">The country of a thumbnail version. Typically a url.</param>
        /// <param name="Uploader">The user the media was uploaded by. May be null for system uploaded media. May only be set to a user other than the current caller if VIDEOS_ADMIN permission. Null will mean the caller is the uploader unless the caller has VIDEOS_ADMIN permission, in which case it will be set to null.</param>
        /// <param name="Width">The width of the video in px (required).</param>
        public VideoResource(SimpleReferenceResourcelong Author = default(SimpleReferenceResourcelong), long? Authored = default(long?), SimpleReferenceResourcestring Category = default(SimpleReferenceResourcestring), List<CommentResource> Comments = default(List<CommentResource>), List<ContributionResource> Contributors = default(List<ContributionResource>), string Embed = default(string), string Extension = default(string), int? Height = default(int?), int? Length = default(int?), string Location = default(string), string LongDescription = default(string), string MimeType = default(string), string Name = default(string), int? Priority = default(int?), PrivacyEnum? Privacy = default(PrivacyEnum?), bool? Published = default(bool?), string ShortDescription = default(string), long? Size = default(long?), List<string> Tags = default(List<string>), string Thumbnail = default(string), SimpleUserResource Uploader = default(SimpleUserResource), int? Width = default(int?))
        {
            // to ensure "Category" is required (not null)
            if (Category == null)
            {
                throw new InvalidDataException("Category is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Category = Category;
            }
            // to ensure "Extension" is required (not null)
            if (Extension == null)
            {
                throw new InvalidDataException("Extension is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Extension = Extension;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
            // to ensure "Length" is required (not null)
            if (Length == null)
            {
                throw new InvalidDataException("Length is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Length = Length;
            }
            // to ensure "Location" is required (not null)
            if (Location == null)
            {
                throw new InvalidDataException("Location is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Location = Location;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for VideoResource and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            this.Author = Author;
            this.Authored = Authored;
            this.Comments = Comments;
            this.Contributors = Contributors;
            this.Embed = Embed;
            this.LongDescription = LongDescription;
            this.MimeType = MimeType;
            this.Priority = Priority;
            this.Privacy = Privacy;
            this.Published = Published;
            this.ShortDescription = ShortDescription;
            this.Size = Size;
            this.Tags = Tags;
            this.Thumbnail = Thumbnail;
            this.Uploader = Uploader;
        }
        
        /// <summary>
        /// Whether the video is available, based on various factors
        /// </summary>
        /// <value>Whether the video is available, based on various factors</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; private set; }

        /// <summary>
        /// The original artist of the media
        /// </summary>
        /// <value>The original artist of the media</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public SimpleReferenceResourcelong Author { get; set; }

        /// <summary>
        /// The date the media was created as a unix timestamp in seconds
        /// </summary>
        /// <value>The date the media was created as a unix timestamp in seconds</value>
        [DataMember(Name="authored", EmitDefaultValue=false)]
        public long? Authored { get; set; }

        /// <summary>
        /// Whether the video has been banned or not
        /// </summary>
        /// <value>Whether the video has been banned or not</value>
        [DataMember(Name="banned", EmitDefaultValue=false)]
        public bool? Banned { get; private set; }

        /// <summary>
        /// The category of the video
        /// </summary>
        /// <value>The category of the video</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public SimpleReferenceResourcestring Category { get; set; }

        /// <summary>
        /// The comments of the video
        /// </summary>
        /// <value>The comments of the video</value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<CommentResource> Comments { get; set; }

        /// <summary>
        /// Artists that contributed to the creation. See separate endpoint to add to list
        /// </summary>
        /// <value>Artists that contributed to the creation. See separate endpoint to add to list</value>
        [DataMember(Name="contributors", EmitDefaultValue=false)]
        public List<ContributionResource> Contributors { get; set; }

        /// <summary>
        /// The date/time this resource was created in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was created in seconds since unix epoch</value>
        [DataMember(Name="created_date", EmitDefaultValue=false)]
        public long? CreatedDate { get; private set; }

        /// <summary>
        /// The country of an embedable version
        /// </summary>
        /// <value>The country of an embedable version</value>
        [DataMember(Name="embed", EmitDefaultValue=false)]
        public string Embed { get; set; }

        /// <summary>
        /// The file extension of the media file. 1-5 characters
        /// </summary>
        /// <value>The file extension of the media file. 1-5 characters</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// The height of the video in px
        /// </summary>
        /// <value>The height of the video in px</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// The unique ID for that resource
        /// </summary>
        /// <value>The unique ID for that resource</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; private set; }

        /// <summary>
        /// The length of the video in seconds
        /// </summary>
        /// <value>The length of the video in seconds</value>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The country of the media. Typically a url. Cannot be blank
        /// </summary>
        /// <value>The country of the media. Typically a url. Cannot be blank</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="long_description", EmitDefaultValue=false)]
        public string LongDescription { get; set; }

        /// <summary>
        /// The mime-type of the media
        /// </summary>
        /// <value>The mime-type of the media</value>
        [DataMember(Name="mime_type", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// The user friendly name of that resource
        /// </summary>
        /// <value>The user friendly name of that resource</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The sort order of the video. default: 100
        /// </summary>
        /// <value>The sort order of the video. default: 100</value>
        [DataMember(Name="priority", EmitDefaultValue=false)]
        public int? Priority { get; set; }


        /// <summary>
        /// Whether the video has been made public. Default true
        /// </summary>
        /// <value>Whether the video has been made public. Default true</value>
        [DataMember(Name="published", EmitDefaultValue=false)]
        public bool? Published { get; set; }

        /// <summary>
        /// The user friendly name of that resource. Defaults to blank string
        /// </summary>
        /// <value>The user friendly name of that resource. Defaults to blank string</value>
        [DataMember(Name="short_description", EmitDefaultValue=false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// The size of the media. Minimum 0 if supplied
        /// </summary>
        /// <value>The size of the media. Minimum 0 if supplied</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public long? Size { get; set; }

        /// <summary>
        /// The tags for the video
        /// </summary>
        /// <value>The tags for the video</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The country of a thumbnail version. Typically a url
        /// </summary>
        /// <value>The country of a thumbnail version. Typically a url</value>
        [DataMember(Name="thumbnail", EmitDefaultValue=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// The date/time this resource was last updated in seconds since unix epoch
        /// </summary>
        /// <value>The date/time this resource was last updated in seconds since unix epoch</value>
        [DataMember(Name="updated_date", EmitDefaultValue=false)]
        public long? UpdatedDate { get; private set; }

        /// <summary>
        /// The user the media was uploaded by. May be null for system uploaded media. May only be set to a user other than the current caller if VIDEOS_ADMIN permission. Null will mean the caller is the uploader unless the caller has VIDEOS_ADMIN permission, in which case it will be set to null
        /// </summary>
        /// <value>The user the media was uploaded by. May be null for system uploaded media. May only be set to a user other than the current caller if VIDEOS_ADMIN permission. Null will mean the caller is the uploader unless the caller has VIDEOS_ADMIN permission, in which case it will be set to null</value>
        [DataMember(Name="uploader", EmitDefaultValue=false)]
        public SimpleUserResource Uploader { get; set; }

        /// <summary>
        /// The view count of the video
        /// </summary>
        /// <value>The view count of the video</value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public long? Views { get; private set; }

        /// <summary>
        /// The width of the video in px
        /// </summary>
        /// <value>The width of the video in px</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoResource {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Authored: ").Append(Authored).Append("\n");
            sb.Append("  Banned: ").Append(Banned).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Contributors: ").Append(Contributors).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  Embed: ").Append(Embed).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LongDescription: ").Append(LongDescription).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Published: ").Append(Published).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  Uploader: ").Append(Uploader).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as VideoResource);
        }

        /// <summary>
        /// Returns true if VideoResource instances are equal
        /// </summary>
        /// <param name="input">Instance of VideoResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Authored == input.Authored ||
                    (this.Authored != null &&
                    this.Authored.Equals(input.Authored))
                ) && 
                (
                    this.Banned == input.Banned ||
                    (this.Banned != null &&
                    this.Banned.Equals(input.Banned))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments))
                ) && 
                (
                    this.Contributors == input.Contributors ||
                    (this.Contributors != null &&
                    this.Contributors.SequenceEqual(input.Contributors))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.Embed == input.Embed ||
                    (this.Embed != null &&
                    this.Embed.Equals(input.Embed))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.LongDescription == input.LongDescription ||
                    (this.LongDescription != null &&
                    this.LongDescription.Equals(input.LongDescription))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    (this.Privacy != null &&
                    this.Privacy.Equals(input.Privacy))
                ) && 
                (
                    this.Published == input.Published ||
                    (this.Published != null &&
                    this.Published.Equals(input.Published))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.UpdatedDate == input.UpdatedDate ||
                    (this.UpdatedDate != null &&
                    this.UpdatedDate.Equals(input.UpdatedDate))
                ) && 
                (
                    this.Uploader == input.Uploader ||
                    (this.Uploader != null &&
                    this.Uploader.Equals(input.Uploader))
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Authored != null)
                    hashCode = hashCode * 59 + this.Authored.GetHashCode();
                if (this.Banned != null)
                    hashCode = hashCode * 59 + this.Banned.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Contributors != null)
                    hashCode = hashCode * 59 + this.Contributors.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Embed != null)
                    hashCode = hashCode * 59 + this.Embed.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.LongDescription != null)
                    hashCode = hashCode * 59 + this.LongDescription.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Privacy != null)
                    hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                if (this.Published != null)
                    hashCode = hashCode * 59 + this.Published.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.UpdatedDate != null)
                    hashCode = hashCode * 59 + this.UpdatedDate.GetHashCode();
                if (this.Uploader != null)
                    hashCode = hashCode * 59 + this.Uploader.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
