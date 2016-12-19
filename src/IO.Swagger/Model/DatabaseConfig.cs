/* 
 * Knetik Platform API Documentation Latest
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: Latest
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
    /// DatabaseConfig
    /// </summary>
    [DataContract]
    public partial class DatabaseConfig :  IEquatable<DatabaseConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseConfig" /> class.
        /// </summary>
        /// <param name="Mongo">Mongo.</param>
        /// <param name="Sql">Sql.</param>
        public DatabaseConfig(MongoDatabaseConfig Mongo = null, SqlDatabaseConfig Sql = null)
        {
            this.Mongo = Mongo;
            this.Sql = Sql;
        }
        
        /// <summary>
        /// Gets or Sets Mongo
        /// </summary>
        [DataMember(Name="mongo", EmitDefaultValue=false)]
        public MongoDatabaseConfig Mongo { get; set; }
        /// <summary>
        /// Gets or Sets Sql
        /// </summary>
        [DataMember(Name="sql", EmitDefaultValue=false)]
        public SqlDatabaseConfig Sql { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseConfig {\n");
            sb.Append("  Mongo: ").Append(Mongo).Append("\n");
            sb.Append("  Sql: ").Append(Sql).Append("\n");
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
            return this.Equals(obj as DatabaseConfig);
        }

        /// <summary>
        /// Returns true if DatabaseConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of DatabaseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatabaseConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mongo == other.Mongo ||
                    this.Mongo != null &&
                    this.Mongo.Equals(other.Mongo)
                ) && 
                (
                    this.Sql == other.Sql ||
                    this.Sql != null &&
                    this.Sql.Equals(other.Sql)
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
                if (this.Mongo != null)
                    hash = hash * 59 + this.Mongo.GetHashCode();
                if (this.Sql != null)
                    hash = hash * 59 + this.Sql.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
