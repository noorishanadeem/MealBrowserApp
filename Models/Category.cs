public class Category
{
    public string? IdCategory { get; set; }
    public string? StrCategory { get; set; }
    public string? StrCategoryThumb { get; set; }
}

public class CategoryResponse
{
    public List<Category>? Categories { get; set; }
}
