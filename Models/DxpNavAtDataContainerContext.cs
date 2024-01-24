using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace navapi_scaffolding.Models;

public partial class DxpNavAtDataContainerContext : DbContext
{
    public DxpNavAtDataContainerContext()
    {
    }

    public DxpNavAtDataContainerContext(DbContextOptions<DxpNavAtDataContainerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DataLoadHistory> DataLoadHistories { get; set; }

    public virtual DbSet<DataLoadSource> DataLoadSources { get; set; }

    public virtual DbSet<DataLoadStatus> DataLoadStatuses { get; set; }

    public virtual DbSet<Debitor> Debitors { get; set; }

    public virtual DbSet<EfmigrationsHistory202401231810Csv> EfmigrationsHistory202401231810Csvs { get; set; }

    public virtual DbSet<Hersteller> Herstellers { get; set; }

    public virtual DbSet<Interessent> Interessents { get; set; }

    public virtual DbSet<InteressentStatus> InteressentStatuses { get; set; }

    public virtual DbSet<KbcTestGeschäftsfall> KbcTestGeschäftsfalls { get; set; }

    public virtual DbSet<KbcTestKundenbenachrichtEinrichtung> KbcTestKundenbenachrichtEinrichtungs { get; set; }

    public virtual DbSet<KbcTestScPunkteposten> KbcTestScPunktepostens { get; set; }

    public virtual DbSet<KbcTestVertragSlm> KbcTestVertragSlms { get; set; }

    public virtual DbSet<KbcTestZeiterfassungsposten> KbcTestZeiterfassungspostens { get; set; }

    public virtual DbSet<Kontaktperson> Kontaktpeople { get; set; }

    public virtual DbSet<Kreditor> Kreditors { get; set; }

    public virtual DbSet<NdeasyDokumentArchiv> NdeasyDokumentArchivs { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Order1> Orders1 { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Resource> Resources { get; set; }

    public virtual DbSet<Verkaufsgutschriftszeilen> Verkaufsgutschriftszeilens { get; set; }

    public virtual DbSet<Verkaufslieferzeilen> Verkaufslieferzeilens { get; set; }

    public virtual DbSet<Verkaufsrechnungszeilen> Verkaufsrechnungszeilens { get; set; }

    public virtual DbSet<VerkäuferEinkäufer> VerkäuferEinkäufers { get; set; }

    public virtual DbSet<Versanddaten> Versanddatens { get; set; }

    public virtual DbSet<Währungswechselkur> Währungswechselkurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DxpNavAtData_container;Integrated Security=SSPI;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DataLoadHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId);

            entity.ToTable("DataLoadHistory");

            entity.Property(e => e.NavTimeStampLast).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.DataHistoryStatusNavigation).WithMany(p => p.DataLoadHistories).HasForeignKey(d => d.DataHistoryStatus);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.DataLoadHistories).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<DataLoadSource>(entity =>
        {
            entity.HasKey(e => e.DataSourceId);

            entity.ToTable("DataLoadSource");

            entity.Property(e => e.DataSourceName).HasMaxLength(100);
        });

        modelBuilder.Entity<DataLoadStatus>(entity =>
        {
            entity.ToTable("DataLoadStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Debitor>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Debitor");

            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.Address).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Name2).HasMaxLength(30);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Ort).HasMaxLength(30);
            entity.Property(e => e.Postalcode).HasMaxLength(20);
            entity.Property(e => e.UstIdNr)
                .HasMaxLength(20)
                .HasDefaultValue("")
                .HasColumnName("UStIdNr");
            entity.Property(e => e.VerkaeuferCode)
                .HasMaxLength(20)
                .HasDefaultValue("");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Debitors).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<EfmigrationsHistory202401231810Csv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("___EFMigrationsHistory__202401231810.csv");

            entity.Property(e => e.MigrationId)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.ProductVersion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hersteller>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Hersteller");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Artikelpräfix).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
        });

        modelBuilder.Entity<Interessent>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Interessent");

            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.Adresse).HasMaxLength(50);
            entity.Property(e => e.Adresse2).HasMaxLength(50);
            entity.Property(e => e.Debitorennr)
                .HasMaxLength(20)
                .HasColumnName("Debitorennr_");
            entity.Property(e => e.Kategorie).HasMaxLength(20);
            entity.Property(e => e.Ländercode).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Name2).HasMaxLength(30);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Ort).HasMaxLength(30);
            entity.Property(e => e.PlzCode).HasMaxLength(20);
            entity.Property(e => e.SapaccountId).HasMaxLength(10);
            entity.Property(e => e.Verkäufercode).HasMaxLength(10);
            entity.Property(e => e.Vertriebsbereich).HasMaxLength(10);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Interessents).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<InteressentStatus>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("InteressentStatus");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.Beschreibung).HasMaxLength(30);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.InteressentStatuses).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<KbcTestGeschäftsfall>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("KbcTestGeschäftsfall");

            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.Beschreibung).HasMaxLength(250);
            entity.Property(e => e.EinmelderAnsprechpartner).HasMaxLength(95);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Verantwortlicher).HasMaxLength(20);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.KbcTestGeschäftsfalls).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<KbcTestKundenbenachrichtEinrichtung>(entity =>
        {
            entity.HasKey(e => e.LfdNr);

            entity.ToTable("KbcTestKundenbenachrichtEinrichtung");

            entity.Property(e => e.LfdNr).ValueGeneratedNever();
            entity.Property(e => e.Herkunftsnr)
                .HasMaxLength(20)
                .HasColumnName("Herkunftsnr_");
            entity.Property(e => e.KontaktpersonenNr).HasMaxLength(20);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Rollencode).HasMaxLength(20);
            entity.Property(e => e.VertragsnrSlm)
                .HasMaxLength(20)
                .HasColumnName("Vertragsnr_SLM");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.KbcTestKundenbenachrichtEinrichtungs).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<KbcTestScPunkteposten>(entity =>
        {
            entity.HasKey(e => e.LfdNr);

            entity.ToTable("KbcTestScPunkteposten");

            entity.Property(e => e.LfdNr)
                .ValueGeneratedNever()
                .HasColumnName("LfdNr_");
            entity.Property(e => e.Belegnr)
                .HasMaxLength(20)
                .HasColumnName("Belegnr_");
            entity.Property(e => e.Beschreibung).HasMaxLength(50);
            entity.Property(e => e.Beschreibung2).HasMaxLength(250);
            entity.Property(e => e.Betrag).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.GeschäftsfallNr)
                .HasMaxLength(20)
                .HasColumnName("GeschäftsfallNr_");
            entity.Property(e => e.Herkunftsnr)
                .HasMaxLength(20)
                .HasColumnName("Herkunftsnr_");
            entity.Property(e => e.LeistungsartRessource).HasMaxLength(20);
            entity.Property(e => e.NameRessourceBenutzer).HasMaxLength(105);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.RechAnDebNr)
                .HasMaxLength(20)
                .HasColumnName("RechAnDebNr_");
            entity.Property(e => e.ScPunkteBetrag).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteBetragNaz).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteBetragPauschalen).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteBetragÜst).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteBetragÜst2Nsf).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteRestbetrag).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScVertragsNrSlm).HasMaxLength(20);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.KbcTestScPunktepostens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<KbcTestVertragSlm>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("KbcTestVertragSlm");

            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.Beschreibung).HasMaxLength(80);
            entity.Property(e => e.Herkunftsnr)
                .HasMaxLength(20)
                .HasColumnName("Herkunftsnr_");
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.PreisgruppencodeTechnologie).HasMaxLength(10);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.KbcTestVertragSlms).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<KbcTestZeiterfassungsposten>(entity =>
        {
            entity.HasKey(e => e.Nummer);

            entity.ToTable("KbcTestZeiterfassungsposten");

            entity.Property(e => e.Nummer).ValueGeneratedNever();
            entity.Property(e => e.Beschreibung).HasMaxLength(50);
            entity.Property(e => e.GeschäftsfallNr)
                .HasMaxLength(20)
                .HasColumnName("GeschäftsfallNr_");
            entity.Property(e => e.KundenverrNazH)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("KundenverrNaz_h");
            entity.Property(e => e.KundenverrÜ1H)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("KundenverrÜ1_h");
            entity.Property(e => e.KundenverrÜ2H)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("KundenverrÜ2_h");
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.NazDec).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScPunkteBetrag).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ScVertragsNrSlm).HasMaxLength(20);
            entity.Property(e => e.Technikercode).HasMaxLength(20);
            entity.Property(e => e.Üstd2NsfDec).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.ÜstdDec).HasColumnType("decimal(38, 20)");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.KbcTestZeiterfassungspostens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Kontaktperson>(entity =>
        {
            entity.HasKey(e => new { e.InteressentenNr, e.Nr });

            entity.ToTable("Kontaktperson");

            entity.Property(e => e.InteressentenNr).HasMaxLength(20);
            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.AkademischerTitelcode).HasMaxLength(20);
            entity.Property(e => e.EindeutigeNummer).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FaxGeschäftlich).HasMaxLength(30);
            entity.Property(e => e.FullName).HasMaxLength(95);
            entity.Property(e => e.MobileTelefonNr).HasMaxLength(30);
            entity.Property(e => e.Nachname).HasMaxLength(30);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.PositionLtVisitenkarte).HasMaxLength(250);
            entity.Property(e => e.Suchbegriff).HasMaxLength(95);
            entity.Property(e => e.TelefonNrGeschäftlich).HasMaxLength(30);
            entity.Property(e => e.Vorname).HasMaxLength(30);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Kontaktpeople).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Kreditor>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Kreditor");

            entity.Property(e => e.Nr).HasMaxLength(20);
            entity.Property(e => e.Adresse).HasMaxLength(30);
            entity.Property(e => e.Adresse2).HasMaxLength(30);
            entity.Property(e => e.Ländercode).HasMaxLength(10);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Name2).HasMaxLength(30);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.Ort).HasMaxLength(30);
            entity.Property(e => e.Plzcode)
                .HasMaxLength(20)
                .HasColumnName("PLZCode");
            entity.Property(e => e.Währungscode).HasMaxLength(10);
        });

        modelBuilder.Entity<NdeasyDokumentArchiv>(entity =>
        {
            entity.HasKey(e => new { e.MandantenId, e.Dokumentenart, e.BelegNummer, e.Version });

            entity.ToTable("NdeasyDokumentArchiv");

            entity.Property(e => e.MandantenId).HasMaxLength(10);
            entity.Property(e => e.Dokumentenart).HasMaxLength(20);
            entity.Property(e => e.BelegNummer).HasMaxLength(20);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.RootIdArchiv).HasMaxLength(20);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.NdeasyDokumentArchivs).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_Order");

            entity.Property(e => e.DebtorContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_ContactPerson");
            entity.Property(e => e.DebtorDeliveryInfoAddressCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_DeliveryInfo_Address_City");
            entity.Property(e => e.DebtorDeliveryInfoAddressCountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_DeliveryInfo_Address_CountryCode");
            entity.Property(e => e.DebtorDeliveryInfoAddressPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_DeliveryInfo_Address_PostalCode");
            entity.Property(e => e.DebtorDeliveryInfoAddressStreet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_DeliveryInfo_Address_Street");
            entity.Property(e => e.DebtorDeliveryInfoContactPerson)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_DeliveryInfo_ContactPerson");
            entity.Property(e => e.DebtorInvoiceAddressCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_InvoiceAddress_City");
            entity.Property(e => e.DebtorInvoiceAddressCountryCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_InvoiceAddress_CountryCode");
            entity.Property(e => e.DebtorInvoiceAddressPostalCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_InvoiceAddress_PostalCode");
            entity.Property(e => e.DebtorInvoiceAddressStreet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_InvoiceAddress_Street");
            entity.Property(e => e.DebtorName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_Name");
            entity.Property(e => e.DebtorPhone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Debtor_Phone");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IssueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OrderReference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectManagerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_Email");
            entity.Property(e => e.ProjectManagerFirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_FirstName");
            entity.Property(e => e.ProjectManagerKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProjectManagerLastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_LastName");
            entity.Property(e => e.ProjectManagerLocked)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_Locked");
            entity.Property(e => e.ProjectManagerTelephoneBusiness)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_TelephoneBusiness");
            entity.Property(e => e.ProjectManagerTelephoneMobile)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_TelephoneMobile");
            entity.Property(e => e.ProjectManagerTitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_Title");
            entity.Property(e => e.ProjectManagerUserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProjectManager_UserId");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order1>(entity =>
        {
            entity.ToTable("Order");

            entity.Property(e => e.Id).HasMaxLength(20);
            entity.Property(e => e.DebtorContactPerson)
                .HasMaxLength(30)
                .HasColumnName("Debtor_ContactPerson");
            entity.Property(e => e.DebtorDeliveryInfoAddressCity)
                .HasMaxLength(30)
                .HasColumnName("Debtor_DeliveryInfo_Address_City");
            entity.Property(e => e.DebtorDeliveryInfoAddressCountryCode)
                .HasMaxLength(10)
                .HasColumnName("Debtor_DeliveryInfo_Address_CountryCode");
            entity.Property(e => e.DebtorDeliveryInfoAddressPostalCode)
                .HasMaxLength(20)
                .HasColumnName("Debtor_DeliveryInfo_Address_PostalCode");
            entity.Property(e => e.DebtorDeliveryInfoAddressStreet)
                .HasMaxLength(30)
                .HasColumnName("Debtor_DeliveryInfo_Address_Street");
            entity.Property(e => e.DebtorDeliveryInfoContactPerson)
                .HasMaxLength(30)
                .HasColumnName("Debtor_DeliveryInfo_ContactPerson");
            entity.Property(e => e.DebtorId).HasMaxLength(20);
            entity.Property(e => e.DebtorInvoiceAddressCity)
                .HasMaxLength(30)
                .HasColumnName("Debtor_InvoiceAddress_City");
            entity.Property(e => e.DebtorInvoiceAddressCountryCode)
                .HasMaxLength(10)
                .HasColumnName("Debtor_InvoiceAddress_CountryCode");
            entity.Property(e => e.DebtorInvoiceAddressPostalCode)
                .HasMaxLength(20)
                .HasColumnName("Debtor_InvoiceAddress_PostalCode");
            entity.Property(e => e.DebtorInvoiceAddressStreet)
                .HasMaxLength(30)
                .HasColumnName("Debtor_InvoiceAddress_Street");
            entity.Property(e => e.DebtorName)
                .HasMaxLength(60)
                .HasColumnName("Debtor_Name");
            entity.Property(e => e.DebtorPhone)
                .HasMaxLength(30)
                .HasColumnName("Debtor_Phone");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.OpenQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderReference).HasMaxLength(30);
            entity.Property(e => e.OrderedQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProjectManagerEmail)
                .HasMaxLength(100)
                .HasColumnName("ProjectManager_Email");
            entity.Property(e => e.ProjectManagerFirstName)
                .HasMaxLength(30)
                .HasColumnName("ProjectManager_FirstName");
            entity.Property(e => e.ProjectManagerKey).HasMaxLength(50);
            entity.Property(e => e.ProjectManagerLastName)
                .HasMaxLength(30)
                .HasColumnName("ProjectManager_LastName");
            entity.Property(e => e.ProjectManagerLocked).HasColumnName("ProjectManager_Locked");
            entity.Property(e => e.ProjectManagerTelephoneBusiness)
                .HasMaxLength(30)
                .HasColumnName("ProjectManager_TelephoneBusiness");
            entity.Property(e => e.ProjectManagerTelephoneMobile)
                .HasMaxLength(30)
                .HasColumnName("ProjectManager_TelephoneMobile");
            entity.Property(e => e.ProjectManagerTitle)
                .HasMaxLength(20)
                .HasColumnName("ProjectManager_Title");
            entity.Property(e => e.ProjectManagerUserId)
                .HasMaxLength(50)
                .HasColumnName("ProjectManager_UserId");
            entity.Property(e => e.State).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.ToTable("OrderItem");

            entity.Property(e => e.Id).HasMaxLength(50);
            entity.Property(e => e.DeliveredQuantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.Number).HasMaxLength(60);
            entity.Property(e => e.OrderId).HasMaxLength(20);
            entity.Property(e => e.OrderedQuantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasKey(e => e.Nr);

            entity.ToTable("Resource");

            entity.Property(e => e.Nr)
                .HasMaxLength(20)
                .HasColumnName("Nr_");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Name2).HasMaxLength(50);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Resources).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Verkaufsgutschriftszeilen>(entity =>
        {
            entity.HasKey(e => new { e.BelegNummer, e.ZeilenNummer });

            entity.ToTable("Verkaufsgutschriftszeilen");

            entity.Property(e => e.BelegNummer).HasMaxLength(20);
            entity.Property(e => e.AuftragsNummer).HasMaxLength(20);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Verkaufsgutschriftszeilens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Verkaufslieferzeilen>(entity =>
        {
            entity.HasKey(e => new { e.BelegNummer, e.ZeilenNummer });

            entity.ToTable("Verkaufslieferzeilen");

            entity.Property(e => e.BelegNummer).HasMaxLength(20);
            entity.Property(e => e.ArtikelNummer).HasMaxLength(60);
            entity.Property(e => e.AuftragsNummer).HasMaxLength(20);
            entity.Property(e => e.Hauptaktivitaetscode).HasMaxLength(10);
            entity.Property(e => e.Menge).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Unteraktivitaetscode).HasMaxLength(10);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Verkaufslieferzeilens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Verkaufsrechnungszeilen>(entity =>
        {
            entity.HasKey(e => new { e.BelegNummer, e.ZeilenNummer });

            entity.ToTable("Verkaufsrechnungszeilen");

            entity.Property(e => e.BelegNummer).HasMaxLength(20);
            entity.Property(e => e.AuftragsNummer).HasMaxLength(20);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Verkaufsrechnungszeilens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<VerkäuferEinkäufer>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VerkäuferEinkäufer");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.AdUser).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(80);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Telefon).HasMaxLength(30);
            entity.Property(e => e.Vertriebsbereich)
                .HasMaxLength(20)
                .HasDefaultValue("");

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.VerkäuferEinkäufers).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Versanddaten>(entity =>
        {
            entity.HasKey(e => e.LaufendeNr);

            entity.ToTable("Versanddaten");

            entity.Property(e => e.LaufendeNr).ValueGeneratedNever();
            entity.Property(e => e.LieferscheinNummer).HasMaxLength(20);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.TrackingId).HasMaxLength(20);
            entity.Property(e => e.TrackingLink).HasMaxLength(250);

            entity.HasOne(d => d.DxpDataLoadSourceDataSource).WithMany(p => p.Versanddatens).HasForeignKey(d => d.DxpDataLoadSourceDataSourceId);
        });

        modelBuilder.Entity<Währungswechselkur>(entity =>
        {
            entity.HasKey(e => new { e.Währungscode, e.Startdatum });

            entity.Property(e => e.Währungscode).HasMaxLength(10);
            entity.Property(e => e.NavTimestamp).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.Wechselkursbetrag).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.Zollwertkurs).HasColumnType("decimal(38, 20)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
