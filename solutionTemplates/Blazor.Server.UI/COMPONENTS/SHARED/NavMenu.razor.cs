using Microsoft.AspNetCore.Components;
using CleanArchitecture.Blazor.Application.Common.Models;
using Microsoft.AspNetCore.Components.Web;

namespace $safeprojectname$.Components.Shared;

public partial class NavMenu
{
 

  

    [EditorRequired] [Parameter] public bool IsDarkMode { get; set; }
    [EditorRequired] [Parameter] public bool SideMenuDrawerOpen { get; set; }
    [EditorRequired] [Parameter] public EventCallback ToggleSideMenuDrawer { get; set; }
    [EditorRequired] [Parameter] public EventCallback OpenCommandPalette { get; set; }
    [EditorRequired] [Parameter] public UserProfile UserProfile { get; set; } = default!;

    [EditorRequired] [Parameter] public bool RightToLeft { get; set; }
    [EditorRequired] [Parameter] public EventCallback RightToLeftToggle { get; set; }

    [Parameter] public EventCallback<MouseEventArgs> OnSettingClick { get; set; }

}