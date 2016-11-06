
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class AnswerRepo: RepositoryBase<Answer>
	{
		public AnswerRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

