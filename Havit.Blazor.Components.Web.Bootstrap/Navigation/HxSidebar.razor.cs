﻿using Microsoft.AspNetCore.Components;

namespace Havit.Blazor.Components.Web.Bootstrap
{
	public partial class HxSidebar : ComponentBase
	{
		/// <summary>
		/// Brand long name (header).
		/// </summary>
		[Parameter] public string BrandName { get; set; }

		/// <summary>
		/// Brand short name (header).
		/// </summary>
		[Parameter] public string BrandNameShort { get; set; }

		/// <summary>
		/// Brand template (header).
		/// </summary>
		[Parameter] public RenderFragment BrandTemplate { get; set; }

		/// <summary>
		/// Sidebar items. Use <see cref="HxSidebarItem"/>.
		/// </summary>
		[Parameter] public RenderFragment ItemsTemplate { get; set; }

		/// <summary>
		/// Icon for expanding the desktop version.
		/// </summary>
		[Parameter] public IconBase DesktopExpandIcon { get; set; } = BootstrapIcon.ChevronBarRight;

		/// <summary>
		/// Icon for collapsing the desktop version.
		/// </summary>
		[Parameter] public IconBase DesktopCollapseIcon { get; set; } = BootstrapIcon.ChevronBarLeft;

		/// <summary>
		/// Sidebar footer (e.g. logged user, language switch, ...).
		/// </summary>
		[Parameter] public RenderFragment FooterTemplate { get; set; }

		private bool collapsedMobile = true;
		private bool collapsedDesktop = false;

		private string GetCollapsedMobileCssClass() => collapsedMobile ? "collapse" : null;

		private string GetDesktopCollapsedCssClass() => collapsedDesktop ? "desktop-collapse" : null;

		private void HandleMobileCollapseToggleClick()
		{
			collapsedMobile = !collapsedMobile;
		}

		private void HandleDesktopCollapseToggleClick()
		{
			collapsedDesktop = !collapsedDesktop;
		}
	}
}