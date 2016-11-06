
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class AddOnRepo: RepositoryBase<AddOn>
	{
		public AddOnRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

