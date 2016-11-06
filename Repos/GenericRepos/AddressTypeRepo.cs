
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class AddressTypeRepo: RepositoryBase<AddressType>
	{
		public AddressTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

