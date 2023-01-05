using Microsoft.EntityFrameworkCore;
using Praticeeeeee.Data;
using Praticeeeeee.DTO;
using Praticeeeeee.Models;
using System.Linq;

namespace Praticeeeeee.Repositorys
{
	public class BookRepository
	{
		private readonly Contextclass context;
		public BookRepository(Contextclass _context)
		{
			this.context = _context;

		}
		public async Task<List<BookModel>> GetAllBooks()
		{
			var allbook = await context.Booksp.ToListAsync();
			var books = new List<BookModel>();
			if (allbook.Any() == true)
			{
				foreach (var book in allbook)
				{
					books.Add(new BookModel()
					{
						ID = book.ID,
						Title = book.Title,
						Author = book.Author,
						Description = book.Description,
						Category = book.Category,
						LanguageID=book.LanguageID,
						Totalpages = book.Totalpages,
					});
				}
			}

			return books;
		}
		public async Task<int> AddBok(BookModel book)
		{
			var Addnew = new BOOKDTO()
			{

				Title = book.Title,
				Author = book.Author,
				Description = book.Description,
				Category = book.Category,
				LanguageID = book.LanguageID,
				Totalpages = book.Totalpages.HasValue ? book.Totalpages.Value : 0,
			};
			await context.Booksp.AddAsync(Addnew);
			await context.SaveChangesAsync();

			return Addnew.ID;
		}
	}
}
