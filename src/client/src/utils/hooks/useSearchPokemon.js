import useSWR from "swr";
import { fetcher } from "../fetcher";

export const useSearchPokemon = (name) => {
  const { data, error } = useSWR(
    `https://localhost:5001/api/PokemonSearch/SearchPokemon/${name}`,
    fetcher
  );

  return {
    pokemon: data,
    isLoading: !error && !data,
    isError: error
      ? JSON.parse(error.toString().replace("Error: ", ""))
      : undefined,
  };
};
