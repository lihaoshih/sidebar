using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_collaboration.Pages.Master_View;

namespace TestTeam_collaboration
{
	public class TestDashboards
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbListModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Dashboards>();
			Assert.NotNull(componentUnderTest);
		}
	}
}