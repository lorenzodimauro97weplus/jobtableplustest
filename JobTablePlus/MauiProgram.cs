﻿using JobTablePlus.Services.Test;
using Microsoft.Extensions.Logging;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection.Extensions;
using JobTablePlus.Shared.Authentication;

namespace JobTablePlus;

public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

			//builder.Services.AddHttpClient();
#if DEBUG
			HttpClientHandler clientHandler = new HttpClientHandler();
			clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

			builder.Services.AddSingleton(sp => new HttpClient(clientHandler) { });

#else
			builder.Services.AddSingleton(sp => new HttpClient() { });
#endif


			builder.Services.AddSingleton<WeatherForecastService>();
			//builder.Services.AddSingleton<ITestService, TestService>();
			builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);


        builder.Services.AddOptions();
        builder.Services.AddAuthorizationCore();
        builder.Services.TryAddScoped<AuthenticationStateProvider, ExternalAuthStateProvider>();
        builder.Services.AddSingleton<AuthenticatedUser>();
        var host = builder.Build();

        var authenticatedUser = host.Services.GetRequiredService<AuthenticatedUser>();

        /*
        Provide OpenID/MSAL code to authenticate the user. See your identity provider's 
        documentation for details.

        The user is represented by a new ClaimsPrincipal based on a new ClaimsIdentity.
        */
        var user = new ClaimsPrincipal(new ClaimsIdentity());

        authenticatedUser.Principal = user;

        return host;

        //return builder.Build();
    }
	}