using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UI.Services;

namespace UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyDataClientService _myDataClientService;

        public IndexModel(MyDataClientService myDataClientService, ILogger<IndexModel> logger)
        {
            _myDataClientService = myDataClientService;
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            var data = await _myDataClientService.GetMyData();
        }
    }
}
