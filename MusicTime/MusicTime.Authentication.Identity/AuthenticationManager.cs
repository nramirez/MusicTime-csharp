using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security;

namespace MusicTime.Authentication.Identity
{
    public class AuthenticationManager : IAuthenticationManager
    {
        public IEnumerable<AuthenticationDescription> GetAuthenticationTypes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthenticationDescription> GetAuthenticationTypes(Func<AuthenticationDescription, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticateResult> AuthenticateAsync(string authenticationType)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AuthenticateResult>> AuthenticateAsync(string[] authenticationTypes)
        {
            throw new NotImplementedException();
        }

        public void Challenge(AuthenticationProperties properties, params string[] authenticationTypes)
        {
            throw new NotImplementedException();
        }

        public void Challenge(params string[] authenticationTypes)
        {
            throw new NotImplementedException();
        }

        public void SignIn(AuthenticationProperties properties, params ClaimsIdentity[] identities)
        {
            throw new NotImplementedException();
        }

        public void SignIn(params ClaimsIdentity[] identities)
        {
            throw new NotImplementedException();
        }

        public void SignOut(params string[] authenticationTypes)
        {
            //TODO: IMPLEMENT THIS!!!
            throw new NotImplementedException();
        }

        public ClaimsPrincipal User
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public AuthenticationResponseChallenge AuthenticationResponseChallenge
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public AuthenticationResponseGrant AuthenticationResponseGrant
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public AuthenticationResponseRevoke AuthenticationResponseRevoke
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}