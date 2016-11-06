
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class CountryRepo: RepositoryBase<Country>
	{
		public CountryRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

