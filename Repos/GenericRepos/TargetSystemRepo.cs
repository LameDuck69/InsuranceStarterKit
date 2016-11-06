
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class TargetSystemRepo: RepositoryBase<TargetSystem>
	{
		public TargetSystemRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

