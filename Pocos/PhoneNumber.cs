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

    // PhoneNumber
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class PhoneNumber
    {
        public int Id { get; set; } // ID (Primary key)
        public string PhoneNumber_ { get; set; } // PhoneNumber (length: 40)
        public string ModifiedBy { get; set; } // ModifiedBy (length: 20)
        public System.DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonPhone> PersonPhones { get; set; } // Many to many mapping

        public PhoneNumber()
        {
            ModifiedDate = System.DateTime.Now;
            PersonPhones = new System.Collections.Generic.List<PersonPhone>();
        }
    }

}
// </auto-generated>
