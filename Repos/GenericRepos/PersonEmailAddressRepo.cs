
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonEmailAddressRepo: RepositoryBase<PersonEmailAddress>
	{
		public PersonEmailAddressRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

