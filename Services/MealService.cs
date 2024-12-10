using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class MealService
{
    private readonly HttpClient _httpClient;

    public MealService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    // Method to search meals by name
    public async Task<MealResponse?> SearchMealsByName(string mealName)
    {
        var response = await _httpClient.GetFromJsonAsync<MealResponse>($"https://www.themealdb.com/api/json/v1/1/search.php?s={mealName}");
        return response;
    }

    // Method to get meal details by ID
    public async Task<MealResponse?> GetMealById(string mealId)
    {
        return await _httpClient.GetFromJsonAsync<MealResponse>(
            $"https://www.themealdb.com/api/json/v1/1/lookup.php?i={mealId}");
    }

    public async Task<CategoryResponse?> GetCategories()
    {
        return await _httpClient.GetFromJsonAsync<CategoryResponse>("https://www.themealdb.com/api/json/v1/1/categories.php");
    }
}
