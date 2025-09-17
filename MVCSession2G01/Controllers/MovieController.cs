using Microsoft.AspNetCore.Mvc;

namespace MVCSession2G01.Controllers
{
    public class MovieController : Controller
    {
        // Actions : public non-static method  
        // Actions : Have Special Return Types
        // ActionResult 


        //public string GetMovie(int id)
        //{
        //    return $"Get Movie With Id: {id} ";
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie With Id: {id} ";
        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    { 
        //        Content = $"Add Movie With Id: {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200
        //    };

        //    return contentResult;

        //}

        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Add Movie With Id: {id}",
        //        ContentType = "object/pdf",
        //        StatusCode = 200
        //    };

        //    return contentResult;

        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redircetResult = new RedirectResult("https://google.com/");

        //    return redircetResult;

        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });

        //    return redirectToActionResult;

        //}



        // Any Action I Will Create in Mvc Controller html El Returnt Type IActionResult
        [ActionName("GetMovie")]
        public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id)
        {
            if (id == 1)
            {
                //return new ContentResult() { Content = $"Add Movie With Id: {id}", ContentType = "text/html" };
                return Content($"Add Movie With Id: {id}", "text/html");
            } 
            else if (id == 2)
            {
                //return new ContentResult(){ Content = $"Add Movie With Id: {id}", ContentType = "object/pdf" };
                return Content($"Add Movie With Id: {id}", "object/pdf");
            } 
            else if (id == 3)
            {
                // return new RedirectResult("https://google.com/");
                return Redirect("https://google.com/");
            }
            
            else
            {
               // return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
                return RedirectToAction("AddMovie", "Movie", new { id = 133 });
            }
        }

        
    }
}
