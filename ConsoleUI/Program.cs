



using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

foreach (var item in carManager.GetCarsByColorId(1))
{
    Console.WriteLine(item.Description);
}

foreach (var item in carManager.GetCarsByBrandId(1))
{
    Console.WriteLine(item.Description);
}
