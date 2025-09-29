using Microsoft.AspNetCore.Mvc;

namespace MVCSession2G01.Controllers
{
    //Mvc Controller
    public class MovieController : Controller
    {
        // Action : Public Non-static method 
        // Action : Have Special Return Types
        //ActionResult
        //public string GetMovie(int id)
        //{
        //    return $" Get Movie With Id {id}";
        //}

        //public string AddMovie(int id)
        //{
        //    return $" Add Movie With Id {id}";
        //}

        //public ContentResult GetMovie(int id)
        //{ 
        //      var contentResult=new ContentResult() 
        //      {
        //        Content=$"Get Movie With Id :{id}",
        //        ContentType="object/pdf",
        //        StatusCode=200
        //      };
        //        return contentResult;
        //}
        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://www.google.com/")

        //    return redirectResult;
        //}
        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectResult("AddMovie", "Movie", new { id = 133 });
        //    return redirectToActionResult;
        //}

        //[ActionName("GetMovie")]
        //[HttpPost]
        //public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie With Id :{id}", ContentType = "text/html" };
        //        return Content( $"Get Movie With Id :{id}", "text/html") ;

        //    }
        //    else if (id == 2)
        //    {
        //        // return new ContentResult() { Content = $"Get Movie With Id :{id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie With Id :{id}", "object/html");

        //    }
        //    else if (id == 3)
        //    {
        //        // return new RedirectResult("https://www.google.com/");
        //        return Redirect("https://www.google.com/");

        //    }
        //    else
        //    {
        //       // return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //        return  RedirectToAction("AddMovie", "Movie", new { id = 133 });

        //    }
        //}

        //public string AddMovie(int id)
        //{
        //    return $" Add Movie With Id {id}";
        //}

        //Action Parameter Binding 
        //1.Form
        //2.Segment
        //3.QuerypArams
        //4.Files

        public ActionResult GetMovie(int id)
        {
            return Content($"Get Movie With Id : {id}", "text/html");
        }
    }
}