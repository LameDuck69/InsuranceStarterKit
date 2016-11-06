
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class QuestionTypeRepo: RepositoryBase<QuestionType>
	{
		public QuestionTypeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

