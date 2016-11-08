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

    // RatingFactor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RatingFactor
    {
        public int Id { get; set; } // ID (Primary key)

        ///<summary>
        /// 1 = * : 2 = + : 3  = - : 4 = / :
        ///</summary>
        public int? RatingOperator { get; set; } // RatingOperator
        public decimal? RatingOperand { get; set; } // RatingOperand

        ///<summary>
        /// Rate versioning through this
        ///</summary>
        public int RatingbaseRateId { get; set; } // RatingbaseRateID

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<RatingFactorOnPolicy> RatingFactorOnPolicies { get; set; } // Many to many mapping

        // Foreign keys
        public virtual RatingBaseRate RatingBaseRate { get; set; } // FK_RatingFactor_RatingBaseRate

        public RatingFactor()
        {
            RatingOperator = 1;
            RatingFactorOnPolicies = new System.Collections.Generic.List<RatingFactorOnPolicy>();
        }
    }

}
// </auto-generated>