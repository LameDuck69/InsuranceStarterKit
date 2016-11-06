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

    // Provider
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class ProviderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Provider>
    {
        public ProviderConfiguration()
            : this("dbo")
        {
        }
 
        public ProviderConfiguration(string schema)
        {
            ToTable(schema + ".Provider");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ProviderName).HasColumnName("ProviderName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
        }
    }

}
// </auto-generated>