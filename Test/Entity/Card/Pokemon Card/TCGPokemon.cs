using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class TCGPokemon
    {
        public string Name { get; private set; }
        public int PokemonNumber { get; private set; }
        public string Species { get; private set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public string Description { get; private set; }
        public int Level { get; private set; }
        public Trainer Trainer { get; private set; }
        public PokemonForce Force { get; private set; }

        public TCGPokemon(string name, int pokemonNumber, string species, double height, double weight, string description, int level)
        {
            this.Name = name;
            this.PokemonNumber = pokemonNumber;
            this.Species = species;
            this.Height = height;
            this.Weight = weight;
            this.Description = description;
            this.Level = level;
            this.Force = new PokemonForce(PokemonForce.Forces.Normal);
        }

        public TCGPokemon(string name, int pokemonNumber, string species, double height, double weight, string description, int level, Trainer trainer)
            : this(name, pokemonNumber, species, height, weight, description, level)
        {
            this.Trainer = trainer;
        }

        public TCGPokemon(string name, int pokemonNumber, string species, double height, double weight, string description, int level, PokemonForce force)
            : this(name, pokemonNumber, species, height, weight, description, level)
        {
            this.Force = force;
        }

        public override string ToString()
        {
            string ret = string.Empty;

            if (this.Trainer != null)
                ret += this.Trainer.Name + "'s" + " ";

            if (this.Force != null && this.Force.Type != PokemonForce.Forces.Normal)
                ret += this.Force.ToString() + " ";

            ret += this.Name;

            return ret;
        }
    }
}
