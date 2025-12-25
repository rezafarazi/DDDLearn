using MediatR;
using Microsoft.AspNetCore.Mvc;
using Application.Commands.CreateUser;
using Application.Commands.UpdateUser;

namespace Presentation.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        private readonly IMediator Mediator;

        public HomeController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> NewUserDone(CreateUserCommand command)
        {
            var userId = await Mediator.Send(command);

            return Redirect(Request.Headers.Referer+"?message=Done");
        }





        [Route("update")]
        public IActionResult update()
        {
            return View();
        }


        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> updateUserDone(UpdateUserCommand command)
        {
            var userId = await Mediator.Send(command);

            return Redirect(Request.Headers.Referer + "?message=Update Done");
        }

    }
}
