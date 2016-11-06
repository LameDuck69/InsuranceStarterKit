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

    // TargetSystem
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class TargetSystem
    {
        public int Id { get; set; } // ID (Primary key)
        public string SystemName { get; set; } // SystemName (length: 20)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PersonLogin> PersonLogins { get; set; } // Many to many mapping
        
        public TargetSystem()
        {
            PersonLogins = new System.Collections.Generic.List<PersonLogin>();
        }
    }

}
// </auto-generated>
