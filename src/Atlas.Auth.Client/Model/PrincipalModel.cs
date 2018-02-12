/* 
 * Atlas.Auth API
 *
 * Authentication/authorization service
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = Atlas.Auth.Client.Client.SwaggerDateConverter;

namespace Atlas.Auth.Client.Model
{
    /// <summary>
    /// PrincipalModel
    /// </summary>
    [DataContract]
    public partial class PrincipalModel :  IEquatable<PrincipalModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalModel" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Company">Company.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="DescedantCompanies">DescedantCompanies.</param>
        public PrincipalModel(Guid? Id = default(Guid?), string Name = default(string), CompanyIdWithNameModel Company = default(CompanyIdWithNameModel), List<string> Roles = default(List<string>), List<CompanyIdModel> DescedantCompanies = default(List<CompanyIdModel>))
        {
            this.Id = Id;
            this.Name = Name;
            this.Company = Company;
            this.Roles = Roles;
            this.DescedantCompanies = DescedantCompanies;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public CompanyIdWithNameModel Company { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Gets or Sets DescedantCompanies
        /// </summary>
        [DataMember(Name="descedantCompanies", EmitDefaultValue=false)]
        public List<CompanyIdModel> DescedantCompanies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrincipalModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  DescedantCompanies: ").Append(DescedantCompanies).Append("\n");
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
            return this.Equals(obj as PrincipalModel);
        }

        /// <summary>
        /// Returns true if PrincipalModel instances are equal
        /// </summary>
        /// <param name="other">Instance of PrincipalModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrincipalModel other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.DescedantCompanies == other.DescedantCompanies ||
                    this.DescedantCompanies != null &&
                    this.DescedantCompanies.SequenceEqual(other.DescedantCompanies)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.DescedantCompanies != null)
                    hash = hash * 59 + this.DescedantCompanies.GetHashCode();
                return hash;
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