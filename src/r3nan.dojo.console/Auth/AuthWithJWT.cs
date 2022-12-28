using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace r3nan.dojo.console.Auth
{
	public class AuthWithJWT
	{
		public AuthWithJWT()
		{

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jackson triggerd"));
			//The encryption algorithm 'HS256' requires a key size of at least '128' bits (16 characters)
			var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var claims = new[]
			{
				new Claim("admin","developer"),
				new Claim("operator","seller")
			};

			var jwtToken = new JwtSecurityToken(
					"Issuer",
					"Audience",
					claims,
					expires: DateTime.Now.AddMinutes(2),
					signingCredentials: credentials
				);
			var jwt = new JwtSecurityTokenHandler().WriteToken(jwtToken);
			Console.WriteLine(jwt);
			Console.ReadKey();
		}

	}
}
