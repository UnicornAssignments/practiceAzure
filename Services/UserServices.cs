using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace practiceAzure.Services
{
    public class UserServices : IUserServices
    {
        public UserServices()
        {

        }

        public object Decode(string inputToken)
        {
            try
            {
                var jwt = inputToken;
                var handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(jwt);

                return token;
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }
    }
}
