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

    // Provider
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class Provider
    {
        public int Id { get; set; } // ID (Primary key)
        public string ProviderName { get; set; } // ProviderName (length: 30)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<AddOn> AddOns { get; set; } // AddOn.FK_AddOn_Provider
        public virtual System.Collections.Generic.ICollection<PolicyDefinition> PolicyDefinitions { get; set; } // PolicyDefinition.FK_PolicyDefinition_Provider

        public Provider()
        {
            AddOns = new System.Collections.Generic.List<AddOn>();
            PolicyDefinitions = new System.Collections.Generic.List<PolicyDefinition>();
        }
    }

}
// </auto-generated>
