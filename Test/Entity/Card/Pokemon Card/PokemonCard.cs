using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Entity
{
    public class PokemonCard : Card
    {
        #region Data
        public TCGType Type { get; private set; }
        public TCGPokemon Pokemon { get; private set; }
        public Stage Stage { get; private set; }
        public Weakness Weakness { get; private set; }
        public Resistance Resistance { get; private set; }
        public HP HP { get; private set; }
        public EnergyCost[] RetreatCost { get; private set; }
        public TCGPokemonMove[] Moves { get; private set; }
        public TCGPokemonPower Power { get; private set; }
        #endregion

        #region Constructors
        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, Resistance resistance, EnergyCost[] cost, TCGPokemonPower pokemonPower)
            : base(rarity, pokemon.ToString())
        {
            this.Type = type;
            this.Pokemon = pokemon;
            this.Stage = stage;
            this.HP = hp;
            this.Moves = moves;
            this.Weakness = weakness;
            this.Resistance = resistance;
            this.RetreatCost = RetreatCost;
            this.Power = pokemonPower;
        }
        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves)
            : this(rarity, type, pokemon, stage, hp, moves, null, null, null, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, null, null, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, EnergyCost[] retreatCost)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, null, retreatCost, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Resistance resistance)
            : this(rarity, type, pokemon, stage, hp, moves, null, resistance, null, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Resistance resistance, EnergyCost[] retreatCost)
            : this(rarity, type, pokemon, stage, hp, moves, null, resistance, retreatCost, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, EnergyCost[] retreatCost)
            : this(rarity, type, pokemon, stage, hp, moves, null, null, retreatCost, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, null, null, null, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, Resistance resistance)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, resistance, null, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, Resistance resistance, EnergyCost[] retreatCost)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, resistance, retreatCost, null) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, null, null, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, EnergyCost[] retreatCost, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, null, retreatCost, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Resistance resistance, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, null, resistance, null, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Resistance resistance, EnergyCost[] retreatCost, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, null, resistance, retreatCost, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, EnergyCost[] retreatCost, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, null, null, retreatCost, pokemonPower) { }

        public PokemonCard(Rarity rarity, TCGType type, TCGPokemon pokemon, Stage stage, HP hp, TCGPokemonMove[] moves, Weakness weakness, Resistance resistance, TCGPokemonPower pokemonPower)
            : this(rarity, type, pokemon, stage, hp, moves, weakness, resistance, null, pokemonPower) { }
        #endregion

        public override int GetHashCode()
        {
            return Tuple.Create(this.Type, this.Pokemon, this.Stage, this.Weakness, this.Resistance, this.HP, this.RetreatCost, Tuple.Create(this.Moves, this.Power)).GetHashCode();
        }
    }
}   
