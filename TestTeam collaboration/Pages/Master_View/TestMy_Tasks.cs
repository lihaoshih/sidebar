using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Team_collaboration.Pages.Master_View;

namespace TestTeam_collaboration
{
	public class TestMy_Tasks
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbBadgeModule),
				typeof(IgbListModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbIconButtonModule),
				typeof(IgbAvatarModule),
				typeof(IgbCalendarModule),
				typeof(IgbInputModule),
				typeof(IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<My_Tasks>();
			Assert.NotNull(componentUnderTest);
		}
	}
}