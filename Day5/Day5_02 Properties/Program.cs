namespace Day5_02_Properties
{
    public class Car
    {
        // Private fields to store data
        private string _make; // The make of the car (e.g., Toyota, Ford)
        private string _model; // The model of the car (e.g., Corolla, Mustang)
        private int _year; // The manufacturing year of the car
        private decimal _price; // The price of the car

        // Public property for 'Make'
        // This property allows getting and setting the value of the _make field
        public string Make
        {
            get
            {
                // Return the value of the _make field
                return _make;
            }
            set
            {
                // Validate the input value (cannot be null or empty)
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Make cannot be empty");
                }
                // Set the value of the _make field
                _make = value;
            }
        }

        // Public property for 'Model'
        // This property allows getting and setting the value of the _model field
        public string Model
        {
            get
            {
                // Return the value of the _model field
                return _model;
            }
            set
            {
                // Validate the input value (cannot be null or empty)
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty");
                }
                // Set the value of the _model field
                _model = value;
            }
        }

        // Public property for 'Year'
        // This property allows getting and setting the value of the _year field
        public int Year
        {
            get
            {
                // Return the value of the _year field
                return _year;
            }
            set
            {
                // Validate the input value (year should be within a reasonable range)
                if (value < 1886 || value > DateTime.Now.Year) // The first car was made in 1886
                {
                    throw new ArgumentException("Invalid year for a car");
                }
                // Set the value of the _year field
                _year = value;
            }
        }

        // Public property for 'Price'
        // This property allows getting and setting the value of the _price field
        public decimal Price
        {
            get
            {
                // Return the value of the _price field
                return _price;
            }
            set
            {
                // Validate the input value (price cannot be negative)
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                // Set the value of the _price field
                _price = value;
            }
        }

        // Read-only property to calculate the car's age
        // This property only has a 'get' accessor and no 'set' accessor
        public int Age
        {
            get
            {
                // Calculate and return the car's age based on the current year
                return DateTime.Now.Year - Year;
            }
        }

        // Write-only property for 'Description'
        // This property only has a 'set' accessor and no 'get' accessor
        public string Description
        {
            set
            {
                // The description is used to concatenate all car details into a string
                _make = value.Split(' ')[0]; // Assuming value is in the format "Make Model Year"
                _model = value.Split(' ')[1];
                _year = int.Parse(value.Split(' ')[2]);
            }
        }

        // Constructor to initialize a new Car object
        public Car(string make, string model, int year, decimal price)
        {
            Make = make; // Use the property to set the value
            Model = model;
            Year = year;
            Price = price;
        }

        // Method to display car details
        public void DisplayInfo()
        {
            // Display the car's make, model, year, price, and age
            Console.WriteLine("Car Details:");
            Console.WriteLine("Make: {0}", Make);
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Year: {0}", Year);
            Console.WriteLine("Price: ${0}", Price);
            Console.WriteLine("Age: {0} years", Age);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create a new Car object using the constructor
            Car myCar = new Car("Toyota", "Corolla", 2010, 8000m);

            // Display the car's initial details
            myCar.DisplayInfo();

            // Update some properties using the property setters
            myCar.Make = "Honda";
            myCar.Model = "Civic";
            myCar.Year = 2015;
            myCar.Price = 12000m;

            // Display the updated car details
            Console.WriteLine("\nUpdated Car Details:");
            myCar.DisplayInfo();

            // Using the write-only 'Description' property to set car details
            myCar.Description = "Ford Mustang 2020";

            // Display the car details after using the Description property
            Console.WriteLine("\nCar Details after using Description property:");
            myCar.DisplayInfo();
        }
    }

}
