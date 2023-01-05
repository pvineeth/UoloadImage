using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Praticeeeeee.Models;
using Praticeeeeee.Repositorys;

namespace Praticeeeeee.Controllers
{
	public class BookController : Controller
	{
		private readonly BookRepository repo;
		public readonly IWebHostEnvironment webh;
		public BookController(BookRepository _repo, IWebHostEnvironment _webh)
		{
			this.repo = _repo;
			this.webh = _webh;
		}
		public async Task<ActionResult<List<BookModel>>> Getall()
		{
			var book = await repo.GetAllBooks();
			return View(book);

		}
		public async Task<ActionResult> AddBook(bool IsSuccess = false, int bookid = 0)
		{

			ViewBag.isSuccess = IsSuccess;
			ViewBag.Bookid = bookid;

			return View();


		}
		[HttpPost]
		public async Task<IActionResult> AddBook(BookModel book)
		{
			if (ModelState.IsValid)
			{
				if (book.Coverphoto != null)
				{
					string folder = "Images";
					folder += book.Coverphoto.FileName + Guid.NewGuid().ToString();
					string severfolder = Path.Combine(webh.WebRootPath, folder)

				}

				int num = await repo.AddBok(book);
				if (num > 0)
				{
					return RedirectToAction(nameof(AddBook), new { IsSuccess = true, bookid = num });
				}


			}


			return View();


		}

	}
}
