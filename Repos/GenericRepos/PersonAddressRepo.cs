
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonAddressRepo: RepositoryBase<PersonAddress>
	{
		public PersonAddressRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

