
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class GlobalRegionRepo: RepositoryBase<GlobalRegion>
	{
		public GlobalRegionRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

