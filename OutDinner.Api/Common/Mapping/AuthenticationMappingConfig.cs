using Mapster;
using OutDinner.Application.Authentication.Common;
using OutDinner.Contracts.Authentication;

namespace OutDinner.Api.Common.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    { config.NewConfig<AuthenticationResult, AuthenticationResponse>().Map(dest => dest, src => src.User); }
}