using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.ApplicationInsights;

namespace markharrisonweb.Pages
{
    public class ColorModel : PageModel
    {
        public TelemetryClient telemetryClient;

        public ColorModel(TelemetryClient telemetry)
        {
            this.telemetryClient = telemetry;
        }

        public void OnGet()
        {

        }
    }
}