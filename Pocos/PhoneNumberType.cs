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

    // PhoneNumberType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class PhoneNumberType
    {
        public int Id { get; set; } // ID (Primary key)
        public string PhoneNumberTypeName { get; set; } // PhoneNumberTypeName (length: 20)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonPhone> PersonPhones { get; set; } // Many to many mapping

        public PhoneNumberType()
        {
            PersonPhones = new System.Collections.Generic.List<PersonPhone>();
        }
    }

}
// </auto-generated>
