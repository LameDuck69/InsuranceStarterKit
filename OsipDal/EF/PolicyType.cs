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

    // PolicyType
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class PolicyType
    {
        public int Id { get; set; } // ID (Primary key)
        public string PolicyTypeName { get; set; } // PolicyTypeName (length: 30)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<PolicyDefinition> PolicyDefinitions { get; set; } // PolicyDefinition.FK_PolicyDefinition_PolicyType
        
        public PolicyType()
        {
            PolicyDefinitions = new System.Collections.Generic.List<PolicyDefinition>();
        }
    }

}
// </auto-generated>
