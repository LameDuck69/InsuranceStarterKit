
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class AddressRepo: RepositoryBase<Address>
	{
		public AddressRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

