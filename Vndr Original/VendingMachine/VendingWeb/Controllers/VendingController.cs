using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendingService;
using VendingService.Interfaces;

namespace VendingWeb.Controllers
{
    public class VendingController : VendingBaseController
    {
        public VendingController(IVendingService db, ILogService log) : base(db,log)
        {
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            string nextView = "Index";

            if (Role.IsAdministrator)
            {
                nextView = "Admin";
            }

            return GetAuthenticatedView(nextView);
        }
                
        [HttpGet]
        public ActionResult Log()
        {
            if (!Role.IsExecutive)
            {
                VendingMachine.LogoutUser();
            }

            LogViewModel vm = new LogViewModel();
            vm.Users = VendingMachine.Users;
            vm.Products = VendingMachine.Products;
            vm.OperationTypes = VendingMachine.OperationTypes;

            return GetAuthenticatedView("Log", vm);
        }

        [HttpGet]
        public ActionResult Report()
        {
            if (!Role.IsExecutive)
            {
                VendingMachine.LogoutUser();
            }

            return GetAuthenticatedView("Report", VendingMachine.Users);
        }

        [HttpGet]
        public ActionResult About()
        {
            return GetAuthenticatedView("About");
        }

        [HttpGet]
        public ActionResult Restock()
        {
            if (!Role.IsServiceman)
            {
                VendingMachine.LogoutUser();
            }

            return GetAuthenticatedView("Restock");
        }

        [HttpPost]
        public ActionResult Restock(int qty)
        {
            if (!Role.IsServiceman)
            {
                VendingMachine.LogoutUser();
            }

            VendingMachine.Restock(qty);

            return GetAuthenticatedView("Index");
        }

        [HttpGet]
        public ActionResult Admin()
        {
            if (!Role.IsAdministrator)
            {
                VendingMachine.LogoutUser();
            }

            return GetAuthenticatedView("Admin");
        }
    }
}