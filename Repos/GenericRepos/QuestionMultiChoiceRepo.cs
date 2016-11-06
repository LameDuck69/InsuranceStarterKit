
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class QuestionMultiChoiceRepo: RepositoryBase<QuestionMultiChoice>
	{
		public QuestionMultiChoiceRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

