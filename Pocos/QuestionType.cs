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

    // QuestionType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class QuestionType
    {
        public int Id { get; set; } // ID (Primary key)

        ///<summary>
        /// Possibly a free text answer
        ///</summary>
        public string QuiestionTypeName { get; set; } // QuiestionTypeName (length: 20)

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<Question> Questions { get; set; } // Question.FK_Question_QuestionType

        public QuestionType()
        {
            Questions = new System.Collections.Generic.List<Question>();
        }
    }

}
// </auto-generated>