using System;

namespace Enemies
{
    /// <summary>Represents a Zombie Enemy.</summary>
    class Zombie
    {
        /// <summary>Private field health.</summary>
        private int health;

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
    }
}
