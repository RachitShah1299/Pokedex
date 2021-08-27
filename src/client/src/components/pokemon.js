export const Pokemon = ({ data: pokemon, isLoading, isError }) => {
  if (isError) {
    return (
      <div>
        <h3>Error:</h3>
        <ul>
          <li>Status Code: {isError.status}</li>
          <li>
            Response from server: {JSON.stringify(isError.message, null, 2)}
          </li>
        </ul>
      </div>
    );
  }

  if (isLoading) {
    return <div>Loading...</div>;
  }

  return (
    <div>
      <img
        src={pokemon.sprites.other["official-artwork"]["front_default"]}
        alt={pokemon.name}
        height={200}
        width={200}
      />
      <ul>
        <li>Id: {pokemon.id}</li>
        <li>Name: {pokemon.name}</li>
        <li>
          Abilities:
          <ul>
            {pokemon.abilities.map((a) => {
              return <li key={a.ability.name}>{a.ability.name}</li>;
            })}
          </ul>
        </li>
        <li>
          Moves:
          <ul>
            {pokemon.moves.map((m) => {
              return <li key={m.move.name}>{m.move.name}</li>;
            })}
          </ul>
        </li>
      </ul>
    </div>
  );
};
