using System;
using System.Collections.Generic;
using System.Text;

namespace HotDeskBooking.Domain.Auth
{
    public class Tokens
    {
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }

        public Tokens (string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
