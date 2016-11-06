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

    // PersonPassword
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class PersonPassword
    {
        public int PersonId { get; set; } // PersonID (Primary key)
        public int PasswordId { get; set; } // PasswordID (Primary key)
        public int TargetSystemId { get; set; } // TargetSystemID (Primary key)

        // Foreign keys
        public virtual Password Password { get; set; } // FK_PersonPassword_Password
        public virtual Person Person { get; set; } // FK_PersonPassword_Person
    }

}
// </auto-generated>