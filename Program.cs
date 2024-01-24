// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using navapi_scaffolding.Models;

var optBuilder = new DbContextOptionsBuilder<DxpNavAtDataContainerContext>();
optBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DxpNavAtData_container;Integrated Security=SSPI;TrustServerCertificate=true;");
var ctx = new DxpNavAtDataContainerContext(optBuilder.Options);


var rechnungenQuery = ctx.Verkaufsrechnungszeilens;
var archive = ctx.NdeasyDokumentArchivs;
var orderId = "324972342";

var invoices = rechnungenQuery.AsQueryable()
    .Where(q => q.AuftragsNummer == orderId)
    .GroupBy(g => g.BelegNummer)
    .Select(group => group.FirstOrDefault())
    ;

var i1=invoices
    .Where(s => s != null)
    .Select(s => s!.BelegNummer)
    .GroupJoin(archive, o => o, archive => archive.BelegNummer, (Belegnr, archiv) => archiv)
    .SelectMany(s => s);

var i2 = i1.GroupBy(g => new { g.BelegNummer, g.Dokumentenart, g.MandantenId })
    .Select(group => group.OrderByDescending(k => k.Version).FirstOrDefault())
    .Where(s => s != null)
    ;

var i3 = i2.Select(s => new Document(s!.BelegNummer, s.Dokumentenart, s.RootIdArchiv, s.MandantenId))
    .ToList();

Console.WriteLine("done");
string x = "";
    
public sealed record Document(string BelegNummer, string DokumentenArt, string RootArchivId, string MandantenId);