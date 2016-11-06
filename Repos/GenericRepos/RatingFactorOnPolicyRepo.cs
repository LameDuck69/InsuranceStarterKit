
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class RatingFactorOnPolicyRepo: RepositoryBase<RatingFactorOnPolicy>
	{
		public RatingFactorOnPolicyRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

