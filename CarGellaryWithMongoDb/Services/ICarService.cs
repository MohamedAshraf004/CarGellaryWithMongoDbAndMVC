using CarGellaryWithMongoDb.Models;
using System.Collections.Generic;

namespace CarGellaryWithMongoDb.Services
{
    public interface ICarService
    {
        Car Create(Car car);
        List<Car> Get();
        Car Get(string id);
        void Remove(Car carIn);
        void Remove(string id);
        void Update(string id, Car carIn);
    }
}