using API_CRUD.Data;
using API_CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly OrderDbContext _context;
        public OrderController(OrderDbContext context)
        {
			_context = context;
            
        }
		[HttpGet]
		[Route("AllOrders")]
		public List<Order> GetOrders() 
		{
			return _context.orders.ToList();
		}
		[HttpPost]
		[Route("NewOrder")]
		public string NewOrder(Order order) 
		{
			string response = string.Empty;
			_context.orders.Add(order);
			_context.SaveChanges();
			return "Order made!";
		}
		[HttpGet]
		[Route("SingleOrder")]
		public Order GetOrder(int id) 
		{
			return _context.orders.Where(x=>x.Id==id).FirstOrDefault();
		}
		[HttpPut]
		[Route("UpdateOrder")]
		public string UpdateOrder (Order order) 
		{
			_context.Entry(order).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
			_context.SaveChanges ();
			return "Order updated!";
		}
		[HttpDelete]
		[Route("DeleteOrder")]
		public string DeleteOrder(int id) 
		{
			_context.orders.Remove(GetOrder(id));
			_context.SaveChanges();
			return "Order deleted!";
		}
    }
}
