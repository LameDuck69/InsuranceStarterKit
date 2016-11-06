
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class CommunicationTypeRepo: RepositoryBase<CommunicationType>
	{
		public CommunicationTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

