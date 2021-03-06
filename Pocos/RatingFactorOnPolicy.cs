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

    // RatingFactorOnPolicy
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RatingFactorOnPolicy
    {
        public int RatingFactorId { get; set; } // RatingFactorID (Primary key)
        public int PolicyId { get; set; } // PolicyID (Primary key)
        public int AnswerId { get; set; } // AnswerID (Primary key)

        // Foreign keys
        public virtual Answer Answer { get; set; } // FK_RatingFactorOnPolicy_Answer
        public virtual Policy Policy { get; set; } // FK_RatingFactorOnPolicy_Policy
        public virtual RatingFactor RatingFactor { get; set; } // FK_RatingFactorOnPolicy_RatingFactor
    }

}
// </auto-generated>
