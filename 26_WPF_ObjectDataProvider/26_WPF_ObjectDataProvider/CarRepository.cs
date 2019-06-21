using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_WPF_ObjectDataProvider
{
    public class CarRepository
    {
        ObservableCollection<Car> Cars;
        public CarRepository()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car{Manufactured="Mercedes", Model="S 500", DataSell=new DateTime(2017,5,12),Price=100000},
                 new Car{Manufactured="BMW", Model="X 5", DataSell=new DateTime(2015,5,12), Price=80000},
                  new Car{Manufactured="Audi", Model="A 8", DataSell=new DateTime(2018,5,12),Price=70000}
            };

        }
        public ObservableCollection<Car> GetCars()
        {
            return Cars;
        }

    }
}
