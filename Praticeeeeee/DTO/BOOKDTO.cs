using System.ComponentModel.DataAnnotations;

namespace Praticeeeeee.DTO
{
	public class BOOKDTO
	{
		public int ID { get; set; }

		public string Title { get; set; }
		
		public string Author { get; set; }

		public string Description { get; set; }

		public string Category { get; set; }
		
		public int LanguageID { get; set; }
		public int Totalpages { get; set; }
	
	}
}
