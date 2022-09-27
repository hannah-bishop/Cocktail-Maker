const baseUrl = "http://localhost:5140";

export interface CocktailResponse {
  id: number;
  name: string;
  imageUrl: string;
  cocktailIngredient: CocktailIngredientResponse[];
  glass: GlassResponse;
  alcoholic: boolean;
}

export interface GlassResponse {
  id: number;
  name: string;
  imageUrl: string;
}

export interface CocktailIngredientResponse {
  cocktailId: number;
  ingredientId: number;
}

export interface CocktailListResponse {
  cocktails: CocktailResponse[];
}

export interface IngredientResponse {
  id: number;
  name: string;
  availability: number;
}

export interface IngredientListResponse {
  ingredients: IngredientResponse[];
}

export async function fetchCocktailByIngredient(
  id: number
): Promise<CocktailListResponse> {
  const response = await fetch(`${baseUrl}/${id}`, {
    headers: {
      "Access-Control-Allow-Origin": "*",
    },
  });
  return await response.json();
}

export async function fetchAllIngredients(): Promise<IngredientListResponse> {
  const response = await fetch(`${baseUrl}/ingredients`, {
    headers: {
      "Access-Control-Allow-Origin": "*",
    },
  });
  return await response.json();
}
