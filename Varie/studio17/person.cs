using System;

namespace studio17
{
    class Person
    {
        private string firstName;
        public string lastName;
        public  int eyeColor;

        private int hairColor;
        private int age;

        public string FirstName { get; set ; }
        public string LastName { get; set ; }
        public int EyeColor { get ; set ; }
        public int Age { get ; set ; }
        public int HairColor { get ; set ; }

        public Person(string firstName,string lastName, int Age,int EyeColor, int HairColor ){
            this.firstName=firstName;
            this.lastName=lastName;
            this.Age=Age;
            this.EyeColor=EyeColor;
            this.HairColor=HairColor;
        }
        
        public void Walk(){
            Console.WriteLine("i'm walking");
        }
        public void Eat(){
            Console.WriteLine("i'm eating");
        }
        public void Sleep(){
            Console.WriteLine("i'm sleeping");
        }
        // string _ssn = "SSN";
        // string _passportData = "Data";
        // string _driverLicenseNumber = "as76276375";

        // // string _firstName = "Mario";
        // // string _lastName = "Rossi";
        // public Person(){       
        // }
        // public Person(string ssn,string passport, string driverLicenseNumber){
        //     _ssn=ssn;
        //     _passportData=passport;
        //     _driverLicenseNumber=driverLicenseNumber;
        // }
        // public bool HasProperDocuments
        // {
        //     get
        //     {
        //         return _ssn.Length > 0 && _passportData.Length > 0 && _driverLicenseNumber.Length > 0;
        //     }


        // }


        // public string FirstName
        // {
        //     get => _firstName;

        //     set
        //     {
        //         if (value.Length < 1)
        //         {
        //             Console.WriteLine("input non valido");
        //             return;
        //         }
        //         _firstName = value;
        //     }
        // }

        // public string LastName
        // {
        //     get => _lastName;
        //     set
        //     {
        //         if (value.Length < 1)
        //         {
        //             Console.WriteLine("input non valido");
        //             return;
        //         }

        //         _lastName = value;
        //     }


        // }


    }
}
