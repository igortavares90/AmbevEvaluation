using Ambev.DeveloperEvaluation.Application.Auth.AuthenticateUser;
using Ambev.DeveloperEvaluation.WebApi.Features.Auth.AuthenticateUserFeature;
using AutoMapper;

public class AuthenticateUserMappingProfile : Profile
{
    public AuthenticateUserMappingProfile()
    {
        CreateMap<AuthenticateUserRequest, AuthenticateUserCommand>();
    }
}