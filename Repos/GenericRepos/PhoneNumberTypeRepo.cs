
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PhoneNumberTypeRepo: RepositoryBase<PhoneNumberType>
	{
		public PhoneNumberTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

