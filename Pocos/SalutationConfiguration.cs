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

    // Salutation
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class SalutationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Salutation>
    {
        public SalutationConfiguration()
            : this("dbo")
        {
        }

        public SalutationConfiguration(string schema)
        {
            ToTable("Salutation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName(@"Title").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
        }
    }

}
// </auto-generated>
