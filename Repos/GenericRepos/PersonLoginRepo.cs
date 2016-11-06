
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonLoginRepo: RepositoryBase<PersonLogin>
	{
		public PersonLoginRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

