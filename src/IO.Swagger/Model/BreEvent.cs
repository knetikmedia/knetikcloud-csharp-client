/* 
 * Knetik Platform API Documentation latest 
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://knetikcloud.com
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// BreEvent
    /// </summary>
    [DataContract]
    public partial class BreEvent :  IEquatable<BreEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BreEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BreEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BreEvent" /> class.
        /// </summary>
        /// <param name="EventName">The event name of the trigger to be fired (required).</param>
        /// <param name="_Params">The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value. (required).</param>
        public BreEvent(string EventName = default(string), Object _Params = default(Object))
        {
            // to ensure "EventName" is required (not null)
            if (EventName == null)
            {
                throw new InvalidDataException("EventName is a required property for BreEvent and cannot be null");
            }
            else
            {
                this.EventName = EventName;
            }
            // to ensure "_Params" is required (not null)
            if (_Params == null)
            {
                throw new InvalidDataException("_Params is a required property for BreEvent and cannot be null");
            }
            else
            {
                this._Params = _Params;
            }
        }
        
        /// <summary>
        /// The event name of the trigger to be fired
        /// </summary>
        /// <value>The event name of the trigger to be fired</value>
        [DataMember(Name="event_name", EmitDefaultValue=false)]
        public string EventName { get; set; }
        /// <summary>
        /// The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.
        /// </summary>
        /// <value>The parameters to the event. A Map (assosiative array) with a key for each trigger parameter name and a corrosponding value.</value>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public Object _Params { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BreEvent {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
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
            return this.Equals(obj as BreEvent);
        }

        /// <summary>
        /// Returns true if BreEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of BreEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BreEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EventName == other.EventName ||
                    this.EventName != null &&
                    this.EventName.Equals(other.EventName)
                ) && 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.Equals(other._Params)
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
                if (this.EventName != null)
                    hash = hash * 59 + this.EventName.GetHashCode();
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
