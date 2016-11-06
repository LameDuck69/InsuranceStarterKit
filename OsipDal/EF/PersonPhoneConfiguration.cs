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

    // PersonPhone
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class PersonPhoneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PersonPhone>
    {
        public PersonPhoneConfiguration()
            : this("dbo")
        {
        }
 
        public PersonPhoneConfiguration(string schema)
        {
            ToTable(schema + ".PersonPhone");
            HasKey(x => new { x.PersonId, x.PhoneNumberId, x.PhoneNumberTypeId });

            Property(x => x.PersonId).HasColumnName("PersonID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberId).HasColumnName("PhoneNumberID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            // Foreign keys
            HasRequired(a => a.Person).WithMany(b => b.PersonPhones).HasForeignKey(c => c.PersonId); // FK_PersonPhone_Person
            HasRequired(a => a.PhoneNumber).WithMany(b => b.PersonPhones).HasForeignKey(c => c.PhoneNumberId); // FK_PersonPhone_PhoneNumber
            HasRequired(a => a.PhoneNumberType).WithMany(b => b.PersonPhones).HasForeignKey(c => c.PhoneNumberTypeId); // FK_PersonPhone_PhoneNumberType
        }
    }

}
// </auto-generated>
