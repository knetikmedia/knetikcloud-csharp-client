/* 
 * Knetik Platform API Documentation Latest
 *
 * This is the spec for the Knetik API.  Use this in conjunction with the documentation found at https://demo.sandbox.knetikcloud.com
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
    /// MongoDatabaseConfig
    /// </summary>
    [DataContract]
    public partial class MongoDatabaseConfig :  IEquatable<MongoDatabaseConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MongoDatabaseConfig" /> class.
        /// </summary>
        /// <param name="DbName">DbName.</param>
        /// <param name="Options">Options.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Servers">Servers.</param>
        /// <param name="Username">Username.</param>
        public MongoDatabaseConfig(string DbName = null, string Options = null, string Password = null, string Servers = null, string Username = null)
        {
            this.DbName = DbName;
            this.Options = Options;
            this.Password = Password;
            this.Servers = Servers;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets DbName
        /// </summary>
        [DataMember(Name="db_name", EmitDefaultValue=false)]
        public string DbName { get; set; }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public string Options { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets Servers
        /// </summary>
        [DataMember(Name="servers", EmitDefaultValue=false)]
        public string Servers { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MongoDatabaseConfig {\n");
            sb.Append("  DbName: ").Append(DbName).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Servers: ").Append(Servers).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as MongoDatabaseConfig);
        }

        /// <summary>
        /// Returns true if MongoDatabaseConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of MongoDatabaseConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MongoDatabaseConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DbName == other.DbName ||
                    this.DbName != null &&
                    this.DbName.Equals(other.DbName)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Servers == other.Servers ||
                    this.Servers != null &&
                    this.Servers.Equals(other.Servers)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.DbName != null)
                    hash = hash * 59 + this.DbName.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Servers != null)
                    hash = hash * 59 + this.Servers.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
