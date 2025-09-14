﻿using AutoMapper;
using MEGUTube.Application.Common.Mappings;
using MEGUTube.Application.CQRS.Identity.Users.Commands.SignInUser;

namespace MEGUTube.WebApi.DTO.Auth.User {
    public class SignInUserDto : IMapWith<SignInUserCommand> { 
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SignInUserDto, SignInUserCommand>()
                .ForMember(command => command.Password, opt => opt.MapFrom(dto => dto.Password))
                .ForMember(command => command.Email, opt => opt.MapFrom(dto => dto.Email));
        }
    }
}
