
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class RatingFactorRepo: RepositoryBase<RatingFactor>
	{
		public RatingFactorRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

