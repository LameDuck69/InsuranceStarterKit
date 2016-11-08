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

    // AddOn
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class AddOn
    {
        public int Id { get; set; } // ID (Primary key)
        public string AddOnName { get; set; } // AddOnName (length: 30)
        public decimal? OneOffCost { get; set; } // OneOffCost
        public decimal? PercentPerPersonOrItemCovered { get; set; } // PercentPerPersonOrItemCovered
        public string PercentagePerPremium { get; set; } // PercentagePerPremium (length: 10)
        public decimal? PercentagePayableCommision { get; set; } // PercentagePayableCommision
        public int? ProviderId { get; set; } // ProviderID

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Policy> Policies { get; set; } // Many to many mapping
        public virtual System.Collections.Generic.ICollection<PolicyDefinition> PolicyDefinitions { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Provider Provider { get; set; } // FK_AddOn_Provider

        public AddOn()
        {
            PolicyDefinitions = new System.Collections.Generic.List<PolicyDefinition>();
            Policies = new System.Collections.Generic.List<Policy>();
        }
    }

}
// </auto-generated>
