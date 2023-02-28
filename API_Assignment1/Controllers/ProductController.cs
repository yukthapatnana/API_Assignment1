using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_Assignment1.Models;
using System.Collections.Generic;

namespace API_Assignment1.Controllers
{
	//[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		[Route("ProductDetails")]
		public Product GetProductDetail() => new Product()
		{
			ProductId = 2,
			ProductName = "Watch",
			Quantity = 1,
			Price = 2000

		};
		[Route("all")]
		//[Route("Product/all")]
		[Route("Product/GetAllProducts")]
		public string GetAllProducts()
		{
			return "All details of the products are available";
		}
		[Route("Product/{id}")]
		public string GetProductById(int id)
		{
			return $"Response from GetProductById {id}";
		}
		[Route("All")]
		public IActionResult GetProducts()
		{
			var Products = new List<Product>()
			{
				new Product() {ProductId=1,ProductName="watch",Quantity=1,Price=3000},
				new Product() {ProductId=2,ProductName="laptop",Quantity=1,Price=70000},
				new Product() {ProductId=3,ProductName="ipad",Quantity=2,Price=7000},
				new Product() {ProductId=4,ProductName="sunglasses",Quantity=1,Price=2000}
			};
			if(Products.Count>0)
			{
				return Ok(Products);
			}
			else
			{
				return NotFound();
			}
		}
		[Route("{id:int:min(105):max(155)}")]
		public string GetProductId(int id)
		{
			return "Response from GetProductDetails {id} from ProductController";
		}
	}
}
