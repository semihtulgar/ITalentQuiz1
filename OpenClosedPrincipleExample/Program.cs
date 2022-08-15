// See https://aka.ms/new-console-template for more information


using OpenClosedPrincipleExample;

Car car = new Car() { CarId = 1, BrandId = 1, ColorId = 1, YearOfModel = DateTime.Now, Description = "Hatasız boyasız", Price = 150000 };

DoTransaction transaction = new DoTransaction(new ToChangeEngineOil());
transaction.PerformTransaction(car);

