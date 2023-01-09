using System;


namespace Homework11_2
{


    interface Icar
    {
        void AddCar(string carName, string year, int cellNumber);
    }

    class CarCollection : Icar
    {
        public Car[] cars; 
        
        int garageSize;

        public Car this[int index]
        {
            set { cars[index] = value; }
            get { return cars[index]; }
        }

        public CarCollection(int garageSize)
        {
            Car[] p = new Car[garageSize];
            cars = p;
        }

        public void AddCar(string carName, string year, int cellNumber)
        {
            Car car = new Car(carName);
            car.year = year;

            cars[cellNumber] = car;
        }


        public int QuantityCars { get => (cars == null ? 0 : cars.Length); }

        public void ClearCarCollection()
        {
            cars = null;            
        }

    }

    class Car
    {
        public string model;
        public string year;

        public Car(string model)
        {
            this.model = model;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            CarCollection carCollection = new CarCollection(3);


            carCollection.AddCar("Opel", "2022", 0);
            carCollection.AddCar("Mazda", "2022", 1);
            carCollection.AddCar("BMW", "2022", 2);

            Console.WriteLine("Quantity of cars in garage {0},",carCollection.QuantityCars);

            for (int i = 0; i < carCollection.QuantityCars; i++)
            {
                var x = carCollection[i];
                Console.WriteLine("Model: {0}, Year: {1}", x.model, x.year );
            }

            



            carCollection.ClearCarCollection(); //clear car collection

            Console.WriteLine("Car collection after clear: {0}",carCollection.QuantityCars);

            Console.ReadKey();
        }
    }
}
