using System;

namespace studio17
{
    class PersonBuilder
    {

        private string _firstName;
        private string _lastName;
        private int _eyeColor;

        private int _hairColor;
        private int _age;

        public PersonBuilder()
        {
            // implementazione del pattern builder della classe persona
            // nello specifico senza niente assegna una persona di default
            SetDefault();
        }

        private void SetDefault()
        {
            // ovviamente questa è la persona creata con new personabuilder
            _firstName = "Mario";
            _lastName = "Rossi";
            _eyeColor = 153; // RGD

            _hairColor = 153;//RGB
            _age = 30;


        }
        public PersonBuilder WithFirstName(string firstName)
        {
            // come già visto in javasript imposto una proprietà e restituendo l'oggetto intero
            // posso iterare l'assenazione di altre proprietà
            _firstName = firstName;
            return this;  //    <----  ecco la magia
        }
        public PersonBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }
        public PersonBuilder WithEyeColor(int eyecolor)
        {
            _eyeColor = eyecolor;
            return this;
        }
        public PersonBuilder WithHairColor(int haircolor)
        {
            _hairColor = haircolor;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            _age = age;
            return this;
        }
        public Person Build()
        {
            // il metodo che materialmente crea la nuova persona dopo averne modificato i parametri (possibilmente ma anche no)
            // vedi sul main di program.cs l'uso nel concreto
            Person person = new Person(_firstName, _lastName, _age, _eyeColor, _hairColor);
            return person;
        }

    }
}