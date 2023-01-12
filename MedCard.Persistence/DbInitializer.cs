namespace MedCard.Persistence;

public class DbInitializer
{
    public static void Initialize(MedCardDbContext context)
    {
        context.Database.EnsureCreated();
    }
}