const baseUrl = "https://localhost:7003";

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

export async function fetchCocktailByIngredient(
  id: number
): Promise<CocktailListResponse> {
  const response = await fetch(`${baseUrl}/${id}`);
  return await response.json();
}
