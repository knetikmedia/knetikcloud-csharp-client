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
    /// ActivityOccurrenceSettingsResource
    /// </summary>
    [DataContract]
    public partial class ActivityOccurrenceSettingsResource :  IEquatable<ActivityOccurrenceSettingsResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOccurrenceSettingsResource" /> class.
        /// </summary>
        /// <param name="CoreSettings">Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity..</param>
        /// <param name="Settings">The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity..</param>
        public ActivityOccurrenceSettingsResource(CoreActivityOccurrenceSettings CoreSettings = default(CoreActivityOccurrenceSettings), List<SelectedSettingRequest> Settings = default(List<SelectedSettingRequest>))
        {
            this.CoreSettings = CoreSettings;
            this.Settings = Settings;
        }
        
        /// <summary>
        /// Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.
        /// </summary>
        /// <value>Defines core settings about the activity occurrence that affect how it behaves in the system. Validated against core settings in activity/challenge-activity.</value>
        [DataMember(Name="core_settings", EmitDefaultValue=false)]
        public CoreActivityOccurrenceSettings CoreSettings { get; set; }

        /// <summary>
        /// The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.
        /// </summary>
        /// <value>The values selected from the available settings defined for the activity. Ex: difficulty: hard. Can be left out if the activity is played during an event and the settings are already set at the event level. Ex: every monday, difficulty: hard, number of questions: 10, category: sport. Otherwise, the set must exactly match those of the activity.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public List<SelectedSettingRequest> Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivityOccurrenceSettingsResource {\n");
            sb.Append("  CoreSettings: ").Append(CoreSettings).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(input as ActivityOccurrenceSettingsResource);
        }

        /// <summary>
        /// Returns true if ActivityOccurrenceSettingsResource instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityOccurrenceSettingsResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityOccurrenceSettingsResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoreSettings == input.CoreSettings ||
                    (this.CoreSettings != null &&
                    this.CoreSettings.Equals(input.CoreSettings))
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.SequenceEqual(input.Settings))
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
                if (this.CoreSettings != null)
                    hashCode = hashCode * 59 + this.CoreSettings.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
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
