  
namespace Enemies
{
    /// <summary>Represents a Zombie Enemy.</summary>
    public class Zombie
    {
        /// <summary>Private field health.</summary>
        public int health;

        /// <summary>Private field name.</summary>
        private string name = "(No name)";

        /// <summary>Gets or sets the name.</summary>
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

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
                throw new System.ArgumentException("Health must be greater than or equal to 0");

            else
                this.health = value;
        }
        
        /// <summary>Returns the value of health a the Zombie object.</summary>
        public int GetHealth()
        {
            return (this.health);
        }

        /// <summary>Public method that returns the string representation of the Zombie instance</summary>
        public override string ToString()
        {
            return ($"Zombie Name: {this.name} / Total Health: {this.health}");
        }
    }
}