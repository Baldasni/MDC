using System.Web;
using System.Web.Optimization;

namespace MDC
{
    public class BundleConfig
    {
        // Per altre informazioni sulla creazione di bundle, vedere https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //script
            bundles.Add(new ScriptBundle("~/bundles/js/Mdc").Include(
                        "~/Scripts/Mdc*"));

            bundles.Add(new ScriptBundle("~/bundles/js/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilizzare la versione di sviluppo di Modernizr per eseguire attività di sviluppo e formazione. Successivamente, quando si è
            // pronti per passare alla produzione, usare lo strumento di compilazione disponibile all'indirizzo https://modernizr.com per selezionare solo i test necessari.
            bundles.Add(new ScriptBundle("~/bundles/js/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/popper").Include(
                        "~/Scripts/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap.table").Include(
                       "~/Scripts/bootstrap-table.js",
                       "~/Scripts/moment.min.js"
                       ));

            //css
            bundles.Add(new StyleBundle("~/bundles/css/Mdc").Include(
                      "~/Content/Mdc*"));

            bundles.Add(new StyleBundle("~/bundles/css/bootstrap").Include(
                      "~/Content/bootstrap-table.css"));

            bundles.Add(new StyleBundle("~/bundles/css/bootstrap-table").Include(
                      "~/Content/bootstrap.css"));
        }
    }
}
