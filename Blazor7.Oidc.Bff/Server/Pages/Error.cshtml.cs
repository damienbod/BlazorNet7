﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Diagnostics;

namespace Blazor7.Bff.Server.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string RequestId { get; set; } = string.Empty;

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    public void OnGet() => RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
}
