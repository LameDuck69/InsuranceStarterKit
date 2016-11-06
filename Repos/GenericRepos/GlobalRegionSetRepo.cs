
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class GlobalRegionSetRepo: RepositoryBase<GlobalRegionSet>
	{
		public GlobalRegionSetRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

