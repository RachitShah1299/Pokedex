import { useState } from "react";
import { Pokemon } from "./components/pokemon";
import { useDebounce } from "./utils/hooks/useDebounce";
import { useSearchPokemon } from "./utils/hooks/useSearchPokemon";

export const App = () => {
  const [searchInput, setSearchInput] = useState("pikachu");
  const [searchVal, setSearchVal] = useState("pikachu");
  const debouncedValue = useDebounce(searchInput, 500);

  const { pokemon, isLoading, isError } = useSearchPokemon(searchVal);

  return (
    <div>
      <input
        value={searchInput}
        onChange={(e) => setSearchInput(e.target.value)}
      />
      <button onClick={() => setSearchVal(searchInput)}>Search</button>
      <Pokemon isLoading={isLoading} isError={isError} data={pokemon} />
    </div>
  );
};
