// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace PersistentService.Controllers;

public record PersistentValue
{
    public string Name { get; init; } = default!;
    public string Description { get; init; } = default!;
}
