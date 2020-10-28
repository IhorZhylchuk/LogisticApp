using Microsoft.AspNetCore.Mvc;

namespace Logistic_2.Controllers
{
    internal class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string script)
        {
            this.Content = script;
            this.ContentType = "application/javascript";
        }
    }
}