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

    // Login
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class LoginConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
            : this("dbo")
        {
        }

        public LoginConfiguration(string schema)
        {
            ToTable("Login", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Login_).HasColumnName(@"Login").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
        }
    }

}
// </auto-generated>