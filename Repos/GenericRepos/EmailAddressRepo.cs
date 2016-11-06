
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class EmailAddressRepo: RepositoryBase<EmailAddress>
	{
		public EmailAddressRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

