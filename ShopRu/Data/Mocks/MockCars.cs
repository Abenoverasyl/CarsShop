using ShopRu.Data.Interfaces;
using ShopRu.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopRu.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car { 
                        Name = "car1", 
                        Shortdesc = "asdasd as asdasdas asdasda", 
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd", 
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349", 
                        Price = 15000,
                        IsFavourite = true,
                        Available = true, 
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car2",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d37033a95e0230008f64eb2/960x0.jpg?cropX1=0&cropX2=3000&cropY1=157&cropY2=1844",
                        Price = 60000,
                        IsFavourite = true,
                        Available = true,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car3",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 15000,
                        IsFavourite = false,
                        Available = false,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car4",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 20000,
                        IsFavourite = true,
                        Available = false,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car5",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 50000,
                        IsFavourite = false,
                        Available = true,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car6",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 1000,
                        IsFavourite = true,
                        Available = true,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car7",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 5000,
                        IsFavourite = true,
                        Available = true,
                        Category =  _carsCategory.AllCategories.First()
                    },
                    new Car {
                        Name = "car8",
                        Shortdesc = "asdasd as asdasdas asdasda",
                        LongDesc = "asd asdasdasd asdasdasdasd asdasdasd  asdasdasdas  asdasdas  asdasd dasdasd",
                        Img = "https://specials-images.forbesimg.com/imageserve/5d35eacaf1176b0008974b54/960x0.jpg?cropX1=790&cropX2=5350&cropY1=784&cropY2=3349",
                        Price = 50000,
                        IsFavourite = true,
                        Available = true,
                        Category =  _carsCategory.AllCategories.First()
                    },
                };
            }
        }

        public IEnumerable<Car> GetFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
