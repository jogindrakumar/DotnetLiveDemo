using Microsoft.AspNetCore.Components;
using DotnetLiveDemo.Application.Models;

namespace DotnetLiveDemo.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout?.User;
}
