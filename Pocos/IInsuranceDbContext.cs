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

    public interface IInsuranceDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AddOn> AddOns { get; set; } // AddOn
        System.Data.Entity.DbSet<Address> Addresses { get; set; } // Address
        System.Data.Entity.DbSet<AddressType> AddressTypes { get; set; } // AddressType
        System.Data.Entity.DbSet<Answer> Answers { get; set; } // Answer
        System.Data.Entity.DbSet<CommunicationType> CommunicationTypes { get; set; } // CommunicationType
        System.Data.Entity.DbSet<Country> Countries { get; set; } // Country
        System.Data.Entity.DbSet<CountryInRegion> CountryInRegions { get; set; } // CountryInRegion
        System.Data.Entity.DbSet<County> Counties { get; set; } // County
        System.Data.Entity.DbSet<CustomerCommunication> CustomerCommunications { get; set; } // CustomerCommunication
        System.Data.Entity.DbSet<EmailAddress> EmailAddresses { get; set; } // EmailAddress
        System.Data.Entity.DbSet<EmailAddressType> EmailAddressTypes { get; set; } // EmailAddressType
        System.Data.Entity.DbSet<GlobalRegion> GlobalRegions { get; set; } // GlobalRegion
        System.Data.Entity.DbSet<GlobalRegionSet> GlobalRegionSets { get; set; } // GlobalRegionSet
        System.Data.Entity.DbSet<Login> Logins { get; set; } // Login
        System.Data.Entity.DbSet<Password> Passwords { get; set; } // Password
        System.Data.Entity.DbSet<Person> People { get; set; } // Person
        System.Data.Entity.DbSet<PersonAddress> PersonAddresses { get; set; } // PersonAddress
        System.Data.Entity.DbSet<PersonEmailAddress> PersonEmailAddresses { get; set; } // PersonEmailAddress
        System.Data.Entity.DbSet<PersonLogin> PersonLogins { get; set; } // PersonLogin
        System.Data.Entity.DbSet<PersonPassword> PersonPasswords { get; set; } // PersonPassword
        System.Data.Entity.DbSet<PersonPhone> PersonPhones { get; set; } // PersonPhone
        System.Data.Entity.DbSet<PhoneNumber> PhoneNumbers { get; set; } // PhoneNumber
        System.Data.Entity.DbSet<PhoneNumberType> PhoneNumberTypes { get; set; } // PhoneNumberType
        System.Data.Entity.DbSet<Policy> Policies { get; set; } // Policy
        System.Data.Entity.DbSet<PolicyAmendment> PolicyAmendments { get; set; } // PolicyAmendment
        System.Data.Entity.DbSet<PolicyAmentmentType> PolicyAmentmentTypes { get; set; } // PolicyAmentmentType
        System.Data.Entity.DbSet<PolicyDefinition> PolicyDefinitions { get; set; } // PolicyDefinition
        System.Data.Entity.DbSet<PolicyType> PolicyTypes { get; set; } // PolicyType
        System.Data.Entity.DbSet<Provider> Providers { get; set; } // Provider
        System.Data.Entity.DbSet<Question> Questions { get; set; } // Question
        System.Data.Entity.DbSet<QuestionMultiChoice> QuestionMultiChoices { get; set; } // QuestionMultiChoice
        System.Data.Entity.DbSet<QuestionMultipleChoiceGroup> QuestionMultipleChoiceGroups { get; set; } // QuestionMultipleChoiceGroup
        System.Data.Entity.DbSet<QuestionRange> QuestionRanges { get; set; } // QuestionRange
        System.Data.Entity.DbSet<QuestionType> QuestionTypes { get; set; } // QuestionType
        System.Data.Entity.DbSet<RatingBaseRate> RatingBaseRates { get; set; } // RatingBaseRate
        System.Data.Entity.DbSet<RatingFactor> RatingFactors { get; set; } // RatingFactor
        System.Data.Entity.DbSet<RatingFactorOnPolicy> RatingFactorOnPolicies { get; set; } // RatingFactorOnPolicy
        System.Data.Entity.DbSet<RefactorLog> RefactorLogs { get; set; } // __RefactorLog
        System.Data.Entity.DbSet<Salutation> Salutations { get; set; } // Salutation
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        System.Data.Entity.DbSet<TargetSystem> TargetSystems { get; set; } // TargetSystem
        System.Data.Entity.DbSet<Town> Towns { get; set; } // Town

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

}
// </auto-generated>
