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

    // CommunicationType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class CommunicationTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CommunicationType>
    {
        public CommunicationTypeConfiguration()
            : this("dbo")
        {
        }

        public CommunicationTypeConfiguration(string schema)
        {
            ToTable("CommunicationType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.CommsTypeName).HasColumnName(@"CommsTypeName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
        }
    }

}
// </auto-generated>