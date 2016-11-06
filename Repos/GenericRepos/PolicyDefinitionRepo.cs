
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PolicyDefinitionRepo: RepositoryBase<PolicyDefinition>
	{
		public PolicyDefinitionRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

