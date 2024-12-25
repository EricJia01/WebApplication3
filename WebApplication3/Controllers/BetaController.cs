using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using Microsoft.FeatureManagement;

namespace WebApplication3.Controllers
{
    public class BetaController : Controller
    {
        private readonly IFeatureManager _featureManager;

        public BetaController(IFeatureManagerSnapshot featureManager) =>
            _featureManager = featureManager;

        [FeatureGate(MyFeatureFlags.Beta)]
        public IActionResult Index() => View();
    }
}
