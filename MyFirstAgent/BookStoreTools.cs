using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace MyFirstAgent;

public sealed class BookStoreTools
{
    private record Book(string Title, string Author, decimal Price);

    private static readonly List<Book> _books = new()
    {
        new("The Trial", "Franz Kafka", 9.99m),
        new("The City and It's Uncertain Walls", "Haruki Murakami", 12.99m),
        new("Runaway Horses", "Yukio Mishima", 14.99m),
        new("Villet", "Emily Bronte", 18.99m)
    };

    [KernelFunction("get_final_price")]
    [Description("Get the final price of a book after applying a discount.")]
    public string GetFinalPrice(
        [Description("The title of the book")] string title,
        [Description("The discount percentage, e.g. 10 for 10%")] decimal discount)
    {
        var book = _books.FirstOrDefault(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase));

        if (book is null) return $"Can't find any book with title '{title}'";

        var finalPrice = book.Price * (100 - discount) / 100;

        return $"The final price of '{book.Title}' by {book.Author} after a {discount}% discount is: ${finalPrice:F2}";
    }
}
