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
            this.health = 0;
        }
        /// <summary>Initializes a new instance of the <see cref="Enemies.Zombie"/> class.</summary>
        /// <param name="value">Zombies's health value.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
        /// <summary>Returns the value of health a the Zombie object.</summary>
        public int GetHealth() => this.health; 
         
        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

         /// <summary>Prints the Zombie object’s attributes to stdout</summary>
        public override string ToString()
        {
            return string.Format("Zombie name: {0} / Total Health: {1}", this.name, this.health);
        }
    }
}
