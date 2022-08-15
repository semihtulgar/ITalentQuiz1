// See https://aka.ms/new-console-template for more information
using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;

CarParkContext context = new CarParkContext();

#region First Insert
//var park = new Park() { ParkName = "Sahil Otoparkı" };
//context.Parks.Add(new Park() { ParkName = "Cumhuriyet Otoparkı" });


//var brand = new Brand() { BrandName = "Opel" };
//var car = new Car() { RegistrationPlate = "52 EA 120", Brand = brand };
//car.Parks.Add(park);
//context.Cars.Add(car);
#endregion

#region Adding second car
//var park = context.Parks.Find(2);
//var brand = new Brand() { BrandName = "Chevrolet" };
//var car = new Car()
//{
//    RegistrationPlate = "27 ZD 047",
//    Brand = brand
//};
//car.Parks.Add(park);
//context.Cars.Add(car);
#endregion



#region Update Brands
//var brand = context.Brands.Find(1);
//brand.BrandName = "Renault";

//context.Brands.Update(brand);
#endregion


#region Get Park Detail
GetParkDetail(context);
#endregion


#region Remove
//var car = context.Cars.Find(1);
//context.Cars.Remove(car);
#endregion


GetParkDetail(context);


context.SaveChanges();

static void GetParkDetail(CarParkContext context)
{
    var results = context.Cars.Join(context.Parks, c => c.Id, p => p.Id, (c, p) => new
    {
        RegistrationPlate = c.RegistrationPlate,
        Park = p.ParkName
    });

    foreach (var item in results)
    {
        Console.WriteLine($"{item.RegistrationPlate} plakalı araç  {item.Park}nda");
    }
}