
using Pocos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Repos.GenericRepos
{


	public partial class QuestionRangeRepo: RepositoryBase<QuestionRange>
	{
		public QuestionRangeRepo(InsuranceDbContext context) : base(context) 
			{ }
	}
}

