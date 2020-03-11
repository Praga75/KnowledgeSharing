using KnowledgeSharing.ServiceLayer;
using System.Web.Http;

namespace KnowledgeSharing.ApiControllers
{
    public class QuestionsController : ApiController
    {
        IAnswersService answersService;

        public QuestionsController(IAnswersService answersService)
        {
            this.answersService = answersService;
        }

        public void Post(int AnswerID, int UserID, int value)
        {
            this.answersService.UpdateAnswerVotesCount(AnswerID, UserID, value);
        }
    }
}
