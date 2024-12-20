using Microsoft.AspNetCore.Mvc;
using CAR_WEB_API_HW.Models;
namespace CAR_WEB_API_HW.Controllers
{
	[ApiController]
	[Route("cars")]
	public class CarController : ControllerBase
	{
		//1) отримати всі машини з пагінацією
		[HttpGet]
		public ActionResult<List<Car>> GetCars()
		{
			var cars = new List<Car>
			{
				new Car
				{
					Id = 1,
					Brand = "Toyota",
					Model = "Corolla",
					Color = "Black"
				},
				new Car
				{
					Id = 1,
					Brand = "Honda",
					Model = "CR-V",
					Color = "Red"
				}
			};
			return Ok(cars);
		}

		//2) отримати машину по Id
		[HttpGet("{Id}")]
		public ActionResult<Car> GetCarById([FromRoute] int id)
		{
			var cars = new Car
			{
				Id = id,
				Brand = "Honda",
				Model = "CR-V",
				Color = "Red"
			};
			return Ok(cars);
		}

		//4) додати машину
		[HttpPost]
		public ActionResult<Car> AddCar([FromBody] Car car)
		{
			car.Id = new Random().Next(1, 10000);
			return Created($"/books/{car.Id}", car);
		}

		//5) видалити машину по id
		[HttpDelete("{id}")]
		public ActionResult<int> DeleteCar([FromRoute] int id)
		{
			return Ok(id);
		}

		//6) оновити машину
		[HttpPut]
		public ActionResult<Car> UpdateBook([FromBody] Car car)
		{
			return Ok(car);
		}

		//1) оновити колір машини
		[HttpPatch]
		public ActionResult<Car> UpdateColor([FromBody] string color)
		{
			var car = new Car()
			{
				Id = new Random().Next(50, 100),
				Brand = "Honda",
				Model = "CR-V",
				Color = color

			};
			return Ok(car);
		}

		//2) видалити машини по id
		[HttpDelete]
		public ActionResult<int> DeleteCars([FromBody] List<int> count)
		{
			int i = 0;
			while (i < count.Count)
			{
				//видалення
				i++;
			}
			return Ok(i);
		}
	}
}
