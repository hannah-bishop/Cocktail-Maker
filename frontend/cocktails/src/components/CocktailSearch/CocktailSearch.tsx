import React, { useState, FormEvent, useEffect } from "react";
import {
  fetchAllIngredients,
  IngredientResponse,
} from "../../clients/internalApiClients";

type FormStatus = "READY" | "SUBMITTING" | "ERROR" | "FINISHED";

export const CocktailSearch: React.FunctionComponent = () => {
  const [ingredients, setIngredients] = useState<IngredientResponse[]>();

  useEffect(() => {
    fetchAllIngredients().then((response) =>
      setIngredients(response.ingredients)
    );
  }, []);

  return (
    <div>{ingredients && ingredients.map((i) => <div>{i.name}</div>)}</div>
  );
};
