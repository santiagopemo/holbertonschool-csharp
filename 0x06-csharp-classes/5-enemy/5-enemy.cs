using System;

namespace Enemies
{
    /// <summary>Represents a Zombie Enemy.</summary>
    class Zombie
    {
        /// <summary>Private field health.</summary>
        private int health;
        /// <summary>Private field name.</summary>
        private string name = "(No name)";

        /// <summary>Initializes a new instance of the <see cref="Enemies.Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Enemies.Zombie"/> class.</summary>
        /// <param name="value">Zombies's health value.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
        /// <summary>Returns the value of health a the Zombie object.</summary>
        public int GetHealth() => health; 
         
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

         /// <summary>Prints the Zombie object’s attributes to stdout</summary>
        public override string ToString()
        {
            return $"Zombie name: {name} / Total Health: {health}";
        }
    }
}
