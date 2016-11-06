
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonPhoneRepo: RepositoryBase<PersonPhone>
	{
		public PersonPhoneRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

