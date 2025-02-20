﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    
    public string ClientCertificate { get { return HttpUtility.UrlDecode(_contextAccessor.HttpContext.Request.Headers["Client-Certificate"]); } }
    
    public string ClientCertificateFingerprint { get { return HttpUtility.UrlDecode(_contextAccessor.HttpContext.Request.Headers["Client-Certificate-Fingerprint"]); } }
    
    private readonly ILogger<IndexModel> _logger;
    
    private readonly IHttpContextAccessor _contextAccessor;

    public IndexModel(ILogger<IndexModel> logger, IHttpContextAccessor contextAccessor)
    {
        _logger = logger;
        _contextAccessor = contextAccessor;
    }

    public void OnGet()
    {        
    }
}
