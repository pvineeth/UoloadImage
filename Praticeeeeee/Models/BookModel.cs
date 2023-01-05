using System.ComponentModel.DataAnnotations;

namespace Praticeeeeee.Models
{
	public class BookModel
	{
		[Required]
		public int ID { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Author { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Category { get; set; }
		[Required]	
		public int LanguageID { get; set; }
		[Required]
		public int? Totalpages { get; set; }
		[Required]
		public IFormFile Coverphoto { get; set; }
	}
}
