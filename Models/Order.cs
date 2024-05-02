using System.ComponentModel.DataAnnotations;

namespace API_CRUD.Models
{
	public class Order
	{
		[Key]
        public int Id { get; set; }
       
        public int Quantity { get; set; }
     

        public string ItemName { get; set; }
        
        public string Description { get; set; }
    }
}
