using Microsoft.AspNetCore.Mvc;

namespace MVCSession2G01.Controllers
{
    // MVC Controller
    public class MovieController :Controller
    {
        //Actions : Public non-static method
        public string GetMovie(int id)
        {
            return $"Get Movie With Id: {id}";
        }
        public string AddMovie(int id)
        {
            return $"Add Movie With Id: {id}";
        }

    }
}
