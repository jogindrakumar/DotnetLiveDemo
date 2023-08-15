using Microsoft.AspNetCore.Components;
using DotnetLiveDemo.Application.Models;
using DotnetLiveDemo.Pages.Shared;

namespace DotnetLiveDemo.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout.User;
}
