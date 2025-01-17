﻿using AutoMapper;
using E_Library.API.Services;
using E_Library.API.Services.Interface;
using E_LibraryManagementSystem.API.DataModel.Entities;
using E_LibraryManagementSystem.API.Services.Interface;
using E_LibraryManagementSystem.ServiceModel.DTO.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_LibraryManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;
        private readonly ITokenRepository _tokenRepository;
 
        public LoginController( ILoginService loginService, IMapper mapper, ITokenRepository tokenRepository)
        { 
            _loginService = loginService;
            _mapper = mapper;
            _tokenRepository = tokenRepository; 


        }

        [HttpPost]
        //[Route("loginUser")]
        public async Task<IActionResult> LoginUser([FromBody] LoginDTO loginDTO)
        {
            IActionResult response = Unauthorized();
            var libUser = new User
            {
                Name = loginDTO.Name,
                Password = loginDTO.Password
            };

            var user = await _loginService.LoginUser(libUser);
     
            if (user != null)
            {
                var token = _tokenRepository.CreateToken(user);
                response = Ok(new
                {
                    token = token,
                    userDetails = user,
                });
                //return Ok(token);
                return response;
             
                return Ok("Login successfully");
            }
            else
            {
                //var res = "Invalid Credentials";
                //return Ok(new{res });
                return NotFound();
            }

        }

    }
}
