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

    // EmailAddress
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class EmailAddressConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<EmailAddress>
    {
        public EmailAddressConfiguration()
            : this("dbo")
        {
        }
 
        public EmailAddressConfiguration(string schema)
        {
            ToTable(schema + ".EmailAddress");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EmailAddress_).HasColumnName("EmailAddress").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>