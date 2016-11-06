
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class QuestionRepo: RepositoryBase<Question>
	{
		public QuestionRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

