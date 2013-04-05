using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using PartialViewAspNet.Models;

namespace PartialViewAspNet.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepositary Repositary { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (Repositary == null)
            {
                Repositary = new ProductRepositary();
            }
            base.Initialize(requestContext);
        }

        //
        // GET: /Product/

        public ActionResult Index()
        {
            IList<Product> products = Repositary.GetAll();
            return PartialView(products);
        }
    }
}
