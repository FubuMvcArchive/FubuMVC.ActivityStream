using FubuMVC.Core;

namespace FubuMVC.ActivityStream
{
    public class ActivityStreamRegistry : FubuPackageRegistry
    {
        public ActivityStreamRegistry()
        {
            IncludeDiagnostics(true);
        }
    }
}