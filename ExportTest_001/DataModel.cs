using System;
using System.Collections.Generic;

namespace ExportTest_001
{
    public class DataModel
    {        
        public Person GetPerson()
        {
            var person = new Person
            {
                FirstName = "Neill",
                LastName = "Murdoch",
                Values = new List<int>
                {
                    1,
                    2
                },
                Postcodes = new List<Postcode>
                {
                    new Postcode { PostcodeValue = "Postcode1" },
                    new Postcode { PostcodeValue = "Postcode2" }
                },
                Addresses = new List<Address>
                {
                    new Address     // Address 1
                    {
                        Address1 = "Address 1 Line 1",
                        Address2 = "Address 1 Line 2",
                        Value = 100, 
                        Dates = new List<string>
                        {
                            new DateTime(2019, 07, 01).ToShortDateString(),
                            new DateTime(2019, 07, 02).ToShortDateString()
                        },
                        Flags = new List<bool>
                        {
                            true,
                            true
                        },
                        Postcodes = new List<Postcode>
                        {
                            new Postcode { PostcodeValue = "Postcode 3" },
                            new Postcode { PostcodeValue = "Postcode 4" },
                            new Postcode { PostcodeValue = "Postcode 5" },
                        }
                    },
                    new Address     // Address 2
                    {
                        Address1 = "Address 2 Line 1",
                        Address2 = "Address 2 Line 2",
                        Value = 200,
                        Dates = new List<string>
                        {
                            new DateTime(2019, 07, 03).ToShortDateString(),
                        },
                        Flags = new List<bool>
                        {
                            false
                        },
                        Postcodes = new List<Postcode>
                        {
                            new Postcode { PostcodeValue = "Postcode 6" },
                            new Postcode { PostcodeValue = "Postcode 7" },
                        }
                    }
                },
                Cars = new List<Car>
                {
                    new Car     // Car 1
                    {
                        Values = new List<int>
                        {
                            10000,
                            20000
                        },
                        Dates = new List<string>
                        {
                            new DateTime(2019, 07, 04).ToShortDateString(),
                            new DateTime(2019, 07, 05).ToShortDateString(),
                            new DateTime(2019, 07, 06).ToShortDateString(),
                        },
                        Colour = "Black",
                        RHD = true,
                        Wheels = new List<Wheel>
                        {
                            new Wheel
                            {
                                Size = 18,
                                Name = "Michelin",
                                Spokes = 6,
                                Alloy = true
                            },
                            new Wheel
                            {
                                Size = 18,
                                Name = "Michelin",
                                Spokes = 6,
                                Alloy = true
                            },
                            new Wheel
                            {
                                Size = 18,
                                Name = "Michelin",
                                Spokes = 6,
                                Alloy = true
                            },
                            new Wheel
                            {
                                Size = 18,
                                Name = "Michelin",
                                Spokes = 6,
                                Alloy = true
                            },
                        }
                    },
                    new Car     // Car 2
                    {
                        Values = new List<int>
                        {
                            30000,
                            40000,
                            50000
                        },
                        Dates = new List<string>
                        {
                            new DateTime(2019, 07, 07).ToShortDateString(),
                        },
                        Colour = "White",
                        RHD = true,
                        Wheels = new List<Wheel>
                        {
                            new Wheel
                            {
                                Size = 15,
                                Name = "Cheapo",
                                Spokes = 0,
                                Alloy = false
                            }
                        }
                    },
                    new Car     // Car 3
                    {
                        Values = new List<int>
                        {
                            60000
                        },
                        Dates = new List<string>
                        {
                            new DateTime(2019, 07, 08).ToShortDateString(),
                            new DateTime(2019, 07, 09).ToShortDateString(),
                            new DateTime(2019, 07, 10).ToShortDateString(),
                        },
                        Colour = "Silver",
                        RHD = false,
                        Wheels = new List<Wheel>
                        {
                            new Wheel
                            {
                                Size = 16,
                                Name = "Dunlop",
                                Spokes = 5,
                                Alloy = true
                            },
                            new Wheel
                            {
                                Size = 16,
                                Name = "Dunlop",
                                Spokes = 5,
                                Alloy = true
                            }
                        }
                    },
                }

            };

            return person;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Values { get; set; }
        public List<Postcode> Postcodes { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Car> Cars{ get; set; }

    }

    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int Value { get; set; }
        public List<string> Dates { get; set; }
        public List<bool> Flags { get; set; }
        public List<Postcode> Postcodes { get; set; }
    }

    public class Postcode
    {
        public string PostcodeValue { get; set; }
    }

    public class Car
    {
        public List<int> Values { get; set; }
        public List<string> Dates { get; set; }
        public string Colour { get; set; }
        public bool RHD { get; set; }
        public List<Wheel> Wheels { get; set; }
    }

    public class Wheel
    {
        public int Size { get; set; }
        public string Name { get; set; }
        public int Spokes { get; set; }
        public bool Alloy { get; set; }
    }



}
