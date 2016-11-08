// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace Pocos
{

    // Address
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Address
    {
        public int Id { get; set; } // ID (Primary key)
        public string AddressLine1 { get; set; } // AddressLine1 (length: 60)
        public string AddressLine2 { get; set; } // AddressLine2 (length: 60)
        public int CityId { get; set; } // CityID
        public int CountyId { get; set; } // CountyID
        public int CountryId { get; set; } // CountryID
        public string PostCode { get; set; } // PostCode (length: 15)
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate
        public string ModifiedBy { get; set; } // ModifiedBy (length: 20)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonAddress> PersonAddresses { get; set; } // Many to many mapping
        public virtual System.Collections.Generic.ICollection<Policy> Policies { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Country Country { get; set; } // FK_Address_Country
        public virtual County County { get; set; } // FK_Address_County
        public virtual Town Town { get; set; } // FK_Address_City

        public Address()
        {
            ModifiedDate = System.DateTime.Now;
            PersonAddresses = new System.Collections.Generic.List<PersonAddress>();
            Policies = new System.Collections.Generic.List<Policy>();
        }
    }

}
// </auto-generated>
