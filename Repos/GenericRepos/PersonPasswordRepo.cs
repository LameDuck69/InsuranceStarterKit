
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonPasswordRepo: RepositoryBase<PersonPassword>
	{
		public PersonPasswordRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

