// See https://aka.ms/new-console-template for more information

using SingleResponsibilityExample;

List<Car> cars = new() {
    new Car() { CarId = 1, BrandId = 1, ColorId = 1, YearOfModel = DateTime.Now, Description = "Hatasız boyasız", Price = 150000 }, 
    new Car() { CarId = 2, BrandId = 2, ColorId = 2, YearOfModel = DateTime.Now, Description = "Hatasız boyasız", Price = 300000 } 
};

CarManager carManager = new CarManager();
carManager.RentCar(cars[0]);
carManager.SellCar(cars[1]);


