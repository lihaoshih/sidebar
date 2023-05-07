using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_collaboration.Pages.Login;

namespace TestTeam_collaboration
{
	public class TestCreate_Account
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbInputModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<Create_Account>();
			Assert.NotNull(componentUnderTest);
		}
	}
}