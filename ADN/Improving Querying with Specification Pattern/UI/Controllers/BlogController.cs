using System.Linq;
using System.Web.Mvc;
using BusinessLogic;
using DataAccess;
using DataAccess.Queries;
using UI.Properties;


namespace UI.Controllers
{
    public class BlogController : Controller
    {
        private IRepository _blogRepository;

        public BlogController() : this(new BlogRepository(new BlogContext(Settings.Default.BlogConnection))) { }

        public BlogController(IRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        //
        // GET: /Blog/

        public ActionResult Display()
        {
            Blog blog = _blogRepository.Set(new TitleMatchSpecification("Test")).First();
            return View(blog);
        }
    }

}
