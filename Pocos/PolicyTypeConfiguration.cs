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

    // PolicyType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class PolicyTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PolicyType>
    {
        public PolicyTypeConfiguration()
            : this("dbo")
        {
        }

        public PolicyTypeConfiguration(string schema)
        {
            ToTable("PolicyType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PolicyTypeName).HasColumnName(@"PolicyTypeName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
        }
    }

}
// </auto-generated>