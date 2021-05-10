using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weelo.Application.DTOs.Account;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Interfaces
{
    //Interface Segregation
    public interface IAccountService: IAccountManagment,IAccountRecover
    {
        
    }
    public interface IAccountManagment
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
    }
    public interface IAccountRegister
    {
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
    }
    public interface IAccountValidate
    {
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
    }
    public interface IAccountRecover
    {
        Task ForgotPassword(ForgotPasswordRequest model, string origin);
    }
    public interface IAccountReset
    {
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);
    }
}
