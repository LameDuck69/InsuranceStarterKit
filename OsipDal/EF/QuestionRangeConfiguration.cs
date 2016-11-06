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

    // QuestionRange
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.1.0")]
    public class QuestionRangeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<QuestionRange>
    {
        public QuestionRangeConfiguration()
            : this("dbo")
        {
        }
 
        public QuestionRangeConfiguration(string schema)
        {
            ToTable(schema + ".QuestionRange");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.RangeStart).HasColumnName("RangeStart").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.RangeEnd).HasColumnName("RangeEnd").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            HasMany(t => t.Questions).WithMany(t => t.QuestionRanges).Map(m => 
            {
                m.ToTable("QuestionRangeGroup", "dbo");
                m.MapLeftKey("QuestionangeID");
                m.MapRightKey("QuestionID");
            });
        }
    }

}
// </auto-generated>