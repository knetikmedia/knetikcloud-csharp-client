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
    /// PageResourceSavedAddressResource
    /// </summary>
    [DataContract]
    public partial class PageResourceSavedAddressResource :  IEquatable<PageResourceSavedAddressResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageResourceSavedAddressResource" /> class.
        /// </summary>
        /// <param name="Content">Content.</param>
        /// <param name="First">First.</param>
        /// <param name="Last">Last.</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberOfElements">NumberOfElements.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Sort">Sort.</param>
        /// <param name="TotalElements">TotalElements.</param>
        /// <param name="TotalPages">TotalPages.</param>
        public PageResourceSavedAddressResource(List<SavedAddressResource> Content = default(List<SavedAddressResource>), bool? First = default(bool?), bool? Last = default(bool?), int? Number = default(int?), int? NumberOfElements = default(int?), int? Size = default(int?), List<Order> Sort = default(List<Order>), long? TotalElements = default(long?), int? TotalPages = default(int?))
        {
            this.Content = Content;
            this.First = First;
            this.Last = Last;
            this.Number = Number;
            this.NumberOfElements = NumberOfElements;
            this.Size = Size;
            this.Sort = Sort;
            this.TotalElements = TotalElements;
            this.TotalPages = TotalPages;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<SavedAddressResource> Content { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public bool? First { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public bool? Last { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int? Number { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="number_of_elements", EmitDefaultValue=false)]
        public int? NumberOfElements { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public List<Order> Sort { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="total_elements", EmitDefaultValue=false)]
        public long? TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageResourceSavedAddressResource {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(input as PageResourceSavedAddressResource);
        }

        /// <summary>
        /// Returns true if PageResourceSavedAddressResource instances are equal
        /// </summary>
        /// <param name="input">Instance of PageResourceSavedAddressResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageResourceSavedAddressResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.SequenceEqual(input.Content))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.NumberOfElements == input.NumberOfElements ||
                    (this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(input.NumberOfElements))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.SequenceEqual(input.Sort))
                ) && 
                (
                    this.TotalElements == input.TotalElements ||
                    (this.TotalElements != null &&
                    this.TotalElements.Equals(input.TotalElements))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.NumberOfElements != null)
                    hashCode = hashCode * 59 + this.NumberOfElements.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.TotalElements != null)
                    hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
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