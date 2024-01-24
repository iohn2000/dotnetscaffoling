// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using navapi_scaffolding.Models;

var optBuilder = new DbContextOptionsBuilder<DxpNavAtDataContainerContext>();
optBuilder.UseSqlServer(
    "Data Source=.\\SQLEXPRESS;Initial Catalog=DxpNavAtData_container;Integrated Security=SSPI;TrustServerCertificate=true;");
var ctx = new DxpNavAtDataContainerContext(optBuilder.Options);


var rechnungenQuery = ctx.Verkaufsrechnungszeilens;
var archive = ctx.NdeasyDokumentArchivs;
var orderId = "324972342";


var queryable = rechnungenQuery
    .Where(q => q.AuftragsNummer == orderId)
    .Select(x => x.BelegNummer)
    .Distinct()
    .Join(archive, o => o, archive => archive.BelegNummer, (Belegnr, archiv) => archiv)
    .Where(w => w.Webdarstellung)
    .OrderBy(x => x.BelegNummer)
    .ThenBy(x => x.Dokumentenart)
    .ThenBy(x => x.MandantenId)
    .ThenByDescending(x => x.Version)
    .GroupBy(x => new { x.BelegNummer, x.Dokumentenart, x.MandantenId })
    .Select(g => new
    {
        g.Key.BelegNummer,
        g.Key.Dokumentenart,
        g.Key.MandantenId,
        MaxVersion = g.Select(x => x.Version).Max()
    });

var invoices = queryable
    .ToList();
// .Select(s => new Document(s.BelegNummer, s.Dokumentenart, s.RootIdArchiv, s.MandantenId))
// .ToList();

var option2 = ctx.Database.SqlQuery<Document>($@"
        SELECT DISTINCT [n].[BelegNummer], [n].[Dokumentenart], [n].[RootIdArchiv], [n].[MandantenId]
        FROM [Verkaufsrechnungszeilen] [v] 
        INNER JOIN [NdeasyDokumentArchiv] AS [n] ON [v].[BelegNummer] = [n].[BelegNummer]
        JOIN (
	        SELECT [n].[BelegNummer], [n].[Dokumentenart], [n].[MandantenId], MAX([n].[Version]) as MaxVersion
	        FROM [NdeasyDokumentArchiv] [n]
	        GROUP BY [n].[BelegNummer], [n].[Dokumentenart], [n].[MandantenId]
        ) AS [n2]
          ON n.BelegNummer = n2.BelegNummer
            AND n.[Dokumentenart] = n2.[Dokumentenart]
	        AND n.[MandantenId] = n2.[MandantenId]
	        AND n.[Version] = n2.[MaxVersion]
        WHERE [v].[AuftragsNummer] = {@orderId}
          AND [n].[Webdarstellung] = CAST(1 AS bit)")
        .ToList()

// .GroupBy(g => g.BelegNummer)
// .Select(group => group.First())
;

/*var i1=invoices
    .Where(s => s != null)
    .Select(s => s!.BelegNummer)
    .GroupJoin(archive, o => o, archive => archive.BelegNummer, (Belegnr, archiv) => archiv)
    .SelectMany(s => s);

var i2 = i1.GroupBy(g => new { g.BelegNummer, g.Dokumentenart, g.MandantenId })
    .Select(group => group.OrderByDescending(k => k.Version).First())
    ;

var i3 = i2.Select(s => new Document(s!.BelegNummer, s.Dokumentenart, s.RootIdArchiv, s.MandantenId))
    .ToList();*/

Console.WriteLine("done");
string x = "";

public sealed record Document(string BelegNummer, string DokumentenArt, string RootIdArchiv, string MandantenId);