using Microsoft.AspNetCore.Mvc.Razor;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tasarim_Bolumu
{
    internal class CustomLocationExpander : IViewLocationExpander
    {
        private const string _CustomViewPath = "CustomViewPath";
        private const string _CustomController = "CustomController";
        public void PopulateValues(ViewLocationExpanderContext context)
        {
            Regex DefaultComponentDetector = new Regex(@"^((?:[Cc]omponents))+\/+([\w\.]+)\/+(.*)");


            /*
             * If successful, 
             * Group 0 = FullMatch (ex "Components/MyComponent/Default")
             * Group 1 = Components (ex "Component")
             * Group 2 = Component Name (ex "MyComponent")
             * Group 3 = View Name (ex "Default")
             * */
            var DefaultComponentMatch = DefaultComponentDetector.Match(context.ViewName);

            if (DefaultComponentMatch.Success)
            {
                // Will render Components/ComponentName as the new view name
                context.Values.Add(_CustomViewPath, string.Format("{0}/{1}", DefaultComponentMatch.Groups[1].Value, DefaultComponentMatch.Groups[2].Value));
                context.Values.Add(_CustomController, context.ControllerName);
            }

        }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            /* Parameters:
             * {2} - Area Name
             * {1} - Controller Name
             * {0} - View Name
             */
            List<string> Paths = new List<string> {
            
            "/Areas/Admin/Views/Shared/footer/{0}.cshtml",
            "/Areas/Admin/Views/Shared/{0}.cshtml",
            "/Areas/Admin/Views/{1}/{0}.cshtml",

            // Default View Locations to support imported / legacy paths
            "/Views/{1}/{0}.cshtml",
            "/Views/Shared/{0}.cshtml",

            // Adds Feature Folder Rendering
           

            // Handles My Custom rendered views
            "/{0}.cshtml"
            };

            // Add "Hard Coded" custom view paths to checks, along with the normal default view paths for backward compatability
            if (context.Values.ContainsKey(_CustomViewPath))
            {
                // Generate full View Paths with my custom View Name and Controller Name

                var CombinedPaths = new List<string>(Paths.Select(x => string.Format(x, context.Values[_CustomViewPath], context.Values[_CustomController], "")));
                // Add in original paths for backward compatability
                CombinedPaths.AddRange(Paths);

                return CombinedPaths;
            }

            // Returns the normal view paths
            return Paths;
        }
    }
}