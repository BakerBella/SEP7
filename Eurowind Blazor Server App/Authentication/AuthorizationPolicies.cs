namespace Eurowind_Blazor_Server_App.Authentication;

public static class AuthorizationPolicies
{
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
    
            options.AddPolicy("SecurityLevel2", a =>
                a.RequireAuthenticatedUser().RequireClaim("SecurityLevel", "2"));
    
            options.AddPolicy("SecurityLevel1", a =>
                a.RequireAuthenticatedUser().RequireClaim("SecurityLevel", "1", "2"));
        });
    }
}