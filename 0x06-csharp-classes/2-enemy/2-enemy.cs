using System;

namespace Enemies
{
    /// <summary>Represents a Zombie Enemy.</summary>
    class Zombie
    {
        /// <summary>Public field health.</summary>
        public int health;

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
    }
}
