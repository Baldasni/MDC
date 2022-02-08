using System.Web;
using System.Web.Optimization;

namespace MDC
{
    public class BundleConfig
    {
        // Per altre informazioni sulla creazione di bundle, vedere https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilizzare la versione di sviluppo di Modernizr per eseguire attività di sviluppo e formazione. Successivamente, quando si è
            // pronti per passare alla produzione, usare lo strumento di compilazione disponibile all'indirizzo https://modernizr.com per selezionare solo i test necessari.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/MdcSite.css"));

            bundles.Add(new StyleBundle("~/bundles/css/MdcSubMenu").Include(
                      "~/Content/MdcSubMenu.css"));

            bundles.Add(new ScriptBundle("~/bundles/js/MdcSubMenu").Include(
                      "~/Scripts/MdcSubMenu.js"));


            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
          "~/Scripts/popper.js"));

            bundles.Add(new ScriptBundle("~/bundles/ListaUtenti/js").Include(
          "~/DataTables/datatables.min.js",
          "~/Scripts/ListaUtenti.js"));

            bundles.Add(new ScriptBundle("~/bundles/js/bootstrap.table").Include(
   "~/Scripts/bootstrap-table.js",
   "~/Scripts/moment.min.js"
   ));

            bundles.Add(new StyleBundle("~/Content/css/bootstrap.table").Include(
               "~/Content/bootstrap-table.css"));

        }
    }
}
