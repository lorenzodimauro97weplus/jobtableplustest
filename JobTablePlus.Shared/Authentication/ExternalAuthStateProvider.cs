using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace JobTablePlus.Shared.Authentication;

public class ExternalAuthStateProvider : AuthenticationStateProvider
{
    private readonly Task<AuthenticationState> authenticationState;

    public ExternalAuthStateProvider(AuthenticatedUser user) =>
        authenticationState = Task.FromResult(new AuthenticationState(user.Principal));

    public override Task<AuthenticationState> GetAuthenticationStateAsync() =>
        authenticationState;

    public void AuthenticateUser()
    {
        // If AuthorizedModel model contains a Jwt token or whatever which you 
        // save in the 
        // local storage, then add it back as a parameter to the AuthenticateUser
        // and place here the logic to save it in the local storage
        // After which call NotifyAuthenticationStateChanged method like this.

        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}

public class AuthenticatedUser
{
    public ClaimsPrincipal Principal { get; set; } = new();
}
