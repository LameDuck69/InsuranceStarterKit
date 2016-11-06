
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class EmailAddressTypeRepo: RepositoryBase<EmailAddressType>
	{
		public EmailAddressTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

