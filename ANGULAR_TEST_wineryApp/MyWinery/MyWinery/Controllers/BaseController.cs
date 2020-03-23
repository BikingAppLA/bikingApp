using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWinery.Controllers
{
    public class BaseController : ApiController
    {
        
        protected WineryManagementEntities _context;

        public BaseController()
        {
            _context = WineryManagementEntities.Instance;
        }
    }
}