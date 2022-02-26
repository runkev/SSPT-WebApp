using Microsoft.AspNetCore.Mvc;
using SSPT_Calculator.Models;
using SSPT_Calculator.Services;


namespace SSPT_Calculator.Controllers
{
    public class MenuController : Controller
    {
        //IVessel _vessel;
        //public MenuController(IVessel vessel) //dependency injection
        //{
        //    _vessel = vessel;
        //}
        public IActionResult Applicability()
        {
            return View();
        }
        public IActionResult EnterTestInfo()
        {
            return View();
        }
        public IActionResult VCGR()
        {
            return View();
        }
        public IActionResult TestWeightInfo()
        {
            return View();
        }
        public IActionResult WeightByDeck()
        {
            return View();
        }
        public IActionResult VesselDimensions()
        {
            return View();
        }
        public IActionResult ImmersionMark()
        {
            return View();
        }
        public IActionResult WindHeel()
        {
            return View();
        }
        public IActionResult HMR()
        {
            return View();
        }
        public IActionResult WeightMovement()
        {
            return View();
        }
        public IActionResult FinalImmersion()
        {
            return View();
        }
        public IActionResult TestSummary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TestInfo W)
        {
            W.paxWeight = W.weight * W.pax;
            return View(W);
        }
    }
}
