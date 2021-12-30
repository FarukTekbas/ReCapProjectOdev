



using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());



foreach (var item in carManager.GetCarDetails())
{
    Console.WriteLine(item.CarName + "/" + item.BrandName + "/" + item.ColorName + "/" + item.DailyPrice);
}

//foreach (var item in carManager.GetCarsByBrandId(1))
//{
//    Console.WriteLine(item.Name);
//}
