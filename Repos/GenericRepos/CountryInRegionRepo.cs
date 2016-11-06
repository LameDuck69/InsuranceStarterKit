
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class CountryInRegionRepo: RepositoryBase<CountryInRegion>
	{
		public CountryInRegionRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

