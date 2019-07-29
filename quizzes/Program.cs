using System;

namespace CSharpQuiz04
{
    class Firearm
    {
        private string type;
        private string noise;

        public Firearm(string type, string noise)
        {
            this.type = type;
            this.noise = noise;
        }

        //public void Speak(string type, string noise)
        public void Speak()
        {
            Console.WriteLine($"I am a {type} and I go {noise}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Quiz 04 in C#");
            Firearm shotgun = new Firearm("shotgun", "boom");
            shotgun.Speak();
            Firearm rifle = new Firearm("rifle", "bang");
            rifle.Speak();
            Firearm pistol = new Firearm("pistol", "pop");
            pistol.Speak();
        }
    }
}
