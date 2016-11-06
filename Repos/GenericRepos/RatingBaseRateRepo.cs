
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class RatingBaseRateRepo: RepositoryBase<RatingBaseRate>
	{
		public RatingBaseRateRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

