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

    // PhoneNumber
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class PhoneNumberConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PhoneNumber>
    {
        public PhoneNumberConfiguration()
            : this("dbo")
        {
        }

        public PhoneNumberConfiguration(string schema)
        {
            ToTable("PhoneNumber", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PhoneNumber_).HasColumnName(@"PhoneNumber").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.ModifiedDate).HasColumnName(@"ModifiedDate").IsRequired().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
