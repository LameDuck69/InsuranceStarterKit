
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class CountyRepo: RepositoryBase<County>
	{
		public CountyRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

