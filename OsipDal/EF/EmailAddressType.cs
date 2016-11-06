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

namespace OsipDal.EF
{

    // EmailAddressType
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class EmailAddressType
    {
        public int Id { get; set; } // ID (Primary key)
        public string EmailAddresstypeName { get; set; } // EmailAddresstypeName (length: 30)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonEmailAddress> PersonEmailAddresses { get; set; } // Many to many mapping
        
        public EmailAddressType()
        {
            PersonEmailAddresses = new System.Collections.Generic.List<PersonEmailAddress>();
        }
    }

}
// </auto-generated>