// See https://aka.ms/new-console-template for more information

using ExampleofCollection;
using System.Collections;


Dictionary<string, Car> cars = new Dictionary<string, Car>()
{
    {"27 ZD 047", new Car() { OwnerFullName = "Tolga TULGAR" , CarBrand = "Chevrolet" }},
    {"34 ABE 11", new Car(){ OwnerFullName = "Ahmet Yılmaz", CarBrand = "Opel" }},
};

Console.WriteLine("---> Cars <---");
ShowCars(cars);

#region Car Dictionary Methods
Console.WriteLine("---> Cars <---");
// Add
cars.Add("06 ANK 06", new Car() { OwnerFullName = "Veli Yılmaz", CarBrand = "Renault" });
// Update
cars["34 ABE 11"].CarBrand = "Pevgeot";
// Remove
cars.Remove("06 ANK 06");
// Get All Cars
ShowCars(cars);
#endregion





LinkedList<string> students = new LinkedList<string>();
#region Student LınkedList Methods
students.AddLast("Emre");
students.AddLast("Enes");
LinkedListNode<string> studentNode = students.AddLast("Semih");

Console.WriteLine($"---> Students <---");
ShowStudents(students);

Console.WriteLine($"---> Students <---");
students.AddBefore(studentNode, "Serkan");
students.AddFirst("Melih");
students.AddLast("Ahmet");
ShowStudents(students);
#endregion







#region Print Methods
static void ShowCars(Dictionary<string, Car> cars)
{
    foreach (var (plate, car) in cars)
    {
        Console.WriteLine($"{plate} - {car.OwnerFullName} {car.CarBrand}");
    }
}

static void ShowStudents(LinkedList<string> students)
{
    foreach (var item in students)
    {
        Console.WriteLine(item);
    }
}
#endregion
