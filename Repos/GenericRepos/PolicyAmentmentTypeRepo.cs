
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PolicyAmentmentTypeRepo: RepositoryBase<PolicyAmentmentType>
	{
		public PolicyAmentmentTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

