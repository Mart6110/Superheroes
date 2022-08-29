using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Superhero
    {
        //Instans variables
        private string _secretIdentity;
        private string _powers;
        private string _mask;
        private string _costume;
        private string _moralCode;
        private string _archenemy;
        private string _fear;

        public string SecretIdentity
        {
            get => _secretIdentity;
            set => _secretIdentity = value;
        }
        public string Powers
        {
            get => _powers;
            set => _powers = value;
        }
        public string Mask
        {
            get => _mask;
            set => _mask = value;
        }
        public string Costume
        {
            get => _costume;
            set => _costume = value;
        }
        public string MoralCode
        {
            get => _moralCode;
            set => _moralCode = value;
        }
        public string Archenemy
        {
            get => _archenemy;
            set => _archenemy = value;
        }
        public string Fear
        {
            get => _fear;
            set => _fear = value;
        }

        //Instans metode
        public void UsePower()
        {
            Console.WriteLine("Using superpowers");
        }

        //Instans metode
        public void Flying()
        {
            Console.WriteLine("Fly away...!");
        }

        //Instans metode
        public void ChangeToCostume()
        {
            Console.WriteLine("Changing to superhero costume");
        }
    }
}
