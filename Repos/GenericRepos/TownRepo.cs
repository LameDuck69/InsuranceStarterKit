
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class TownRepo: RepositoryBase<Town>
	{
		public TownRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

//}

