
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class PersonRepo: RepositoryBase<Person>
	{
		public PersonRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

