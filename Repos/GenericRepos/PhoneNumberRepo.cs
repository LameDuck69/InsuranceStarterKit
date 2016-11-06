
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PhoneNumberRepo: RepositoryBase<PhoneNumber>
	{
		public PhoneNumberRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

