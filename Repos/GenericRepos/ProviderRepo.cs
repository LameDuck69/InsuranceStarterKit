
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class ProviderRepo: RepositoryBase<Provider>
	{
		public ProviderRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

