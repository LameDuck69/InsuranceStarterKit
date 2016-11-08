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

    // AddOn
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class AddOnConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AddOn>
    {
        public AddOnConfiguration()
            : this("dbo")
        {
        }

        public AddOnConfiguration(string schema)
        {
            ToTable("AddOn", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.AddOnName).HasColumnName(@"AddOnName").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.OneOffCost).HasColumnName(@"OneOffCost").IsOptional().HasColumnType("decimal").HasPrecision(4,2);
            Property(x => x.PercentPerPersonOrItemCovered).HasColumnName(@"PercentPerPersonOrItemCovered").IsOptional().HasColumnType("decimal").HasPrecision(2,2);
            Property(x => x.PercentagePerPremium).HasColumnName(@"PercentagePerPremium").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
            Property(x => x.PercentagePayableCommision).HasColumnName(@"PercentagePayableCommision").IsOptional().HasColumnType("decimal").HasPrecision(2,2);
            Property(x => x.ProviderId).HasColumnName(@"ProviderID").IsOptional().HasColumnType("int");

            // Foreign keys
            HasOptional(a => a.Provider).WithMany(b => b.AddOns).HasForeignKey(c => c.ProviderId).WillCascadeOnDelete(false); // FK_AddOn_Provider
            HasMany(t => t.PolicyDefinitions).WithMany(t => t.AddOns).Map(m =>
            {
                m.ToTable("PolicyAddOnAvailable", "dbo");
                m.MapLeftKey("AddonID");
                m.MapRightKey("PolicyID");
            });
            HasMany(t => t.Policies).WithMany(t => t.AddOns).Map(m =>
            {
                m.ToTable("PolicyAddOnPurchased", "dbo");
                m.MapLeftKey("AddOnID");
                m.MapRightKey("PolicyID");
            });
        }
    }

}
// </auto-generated>