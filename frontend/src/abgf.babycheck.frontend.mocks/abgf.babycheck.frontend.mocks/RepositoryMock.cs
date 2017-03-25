using abgf.babycheck.frontend.contracts;
using abgf.babycheck.frontend.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abgf.babycheck.frontend.mocks
{
    public class RepositoryMock : IRepository
    {
        public List<Garment> GetGarmentsAsync()
        {
            var room1 = new Room() { Id = 1, Name = "Habitacion del niño" };
            var container1 = new Container() { Id = 1 , Name = "Armario"};
            var garmentType1 = new GarmentType() { Id = 1, Name = "Pijama", ImageName = "" };
            var garment1 = new Garment()
            {
                Id = 1,
                Name = "Pijama",
                ClothesSet = null,
                IdClothesSet = -1,
                Colour = "Amarillo",
                Container = container1,
                IdContainer = container1.Id,
                Size = 30,
                DestinationAge = 0,
                GarmentType = garmentType1,
                IdGarmentType = garmentType1.Id
            };

            room1.Containers = new List<Container>() { container1 };
            container1.Garments = new List<Garment>() { garment1 };
            container1.Room = room1;
            container1.IdRoom = room1.Id;

            return new List<Garment>() { garment1 };
        }
    }
}
