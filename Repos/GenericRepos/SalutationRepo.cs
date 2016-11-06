
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class SalutationRepo: RepositoryBase<Salutation>
	{
		public SalutationRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

