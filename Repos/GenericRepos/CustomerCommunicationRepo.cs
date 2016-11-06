
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class CustomerCommunicationRepo: RepositoryBase<CustomerCommunication>
	{
		public CustomerCommunicationRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

