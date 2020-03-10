using KnowledgeSharing.ServiceLayer;
using System.Web.Http;
using KnowledgeSharing.ViewModels;

namespace KnowledgeSharing.ApiControllers
{
    public class AccountController : ApiController
    {
        IUsersService userService;

        public AccountController(IUsersService userService)
        {
            this.userService = userService;
        }

        public string GetIDPresentOrNot(string Email)
        {
            if (this.userService.GetUsersByEmail(Email) != null)
            {
                return "Found";
            }
            else
            {
                return "Not Found";
            }
        }
    }
}
