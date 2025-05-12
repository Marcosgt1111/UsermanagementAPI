namespace UserManagementAPI.Routes;

public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {
        app.MapGet("Person", () => "Ola Marcos");
    }
        
}