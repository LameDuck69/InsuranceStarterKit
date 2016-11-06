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

    // TargetSystem
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class TargetSystemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TargetSystem>
    {
        public TargetSystemConfiguration()
            : this("dbo")
        {
        }
 
        public TargetSystemConfiguration(string schema)
        {
            ToTable(schema + ".TargetSystem");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SystemName).HasColumnName("SystemName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
        }
    }

}
// </auto-generated>
