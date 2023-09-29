using Microsoft.AspNetCore.Mvc;

namespace DemoServer.Controllers; 
[ApiController]
[Route( "/api/[controller]")]
public class DemoController  : ControllerBase {

	private readonly IConfiguration _configuration;

	public DemoController(IConfiguration configuration) {
		this._configuration = configuration;
	}

	[HttpGet]
	[Route("config")]
	public IActionResult GetConfig() {
		// Create a dynamic configuration object
		var config = new {
			SomeName = this._configuration.GetValue<string>( "SomeKey" )
		};
		// Return it as JSON
		return new JsonResult( config );
	}
}
