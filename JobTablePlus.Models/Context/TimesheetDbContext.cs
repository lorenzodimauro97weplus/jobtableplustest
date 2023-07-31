using System;
using System.Collections.Generic;
using JobTablePlus.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace JobTablePlus.Models.Context;

public partial class TimesheetDbContext : DbContext
{
    public TimesheetDbContext()
    {
    }

    public TimesheetDbContext(DbContextOptions<TimesheetDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A> As { get; set; }

    public virtual DbSet<Activity> Activities { get; set; }

    public virtual DbSet<Ambito> Ambitos { get; set; }

    public virtual DbSet<AmbitoCompetenza> AmbitoCompetenzas { get; set; }

    public virtual DbSet<Assenza> Assenzas { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<B> Bs { get; set; }

    public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }

    public virtual DbSet<Claudium> Claudia { get; set; }

    public virtual DbSet<Clienti> Clientis { get; set; }

    public virtual DbSet<CodaInvioEmail> CodaInvioEmails { get; set; }

    public virtual DbSet<CodaInvioEmailAttachment> CodaInvioEmailAttachments { get; set; }

    public virtual DbSet<Commesse> Commesses { get; set; }

    public virtual DbSet<CommesseInterne> CommesseInternes { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Competenza> Competenzas { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<Contratti> Contrattis { get; set; }

    public virtual DbSet<CrmCostiAll> CrmCostiAlls { get; set; }

    public virtual DbSet<CrmCostiComm3> CrmCostiComm3s { get; set; }

    public virtual DbSet<CrmCostiCommessa> CrmCostiCommessas { get; set; }

    public virtual DbSet<CrmCostiCommessaDef> CrmCostiCommessaDefs { get; set; }

    public virtual DbSet<CrmCostiCommessaOld> CrmCostiCommessaOlds { get; set; }

    public virtual DbSet<CrmCostiRisorsa> CrmCostiRisorsas { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<ElencoAccessi> ElencoAccessis { get; set; }

    public virtual DbSet<EmailRichiesteAssenze> EmailRichiesteAssenzes { get; set; }

    public virtual DbSet<Festivitum> Festivita { get; set; }

    public virtual DbSet<Festivity> Festivities { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobActivity> JobActivities { get; set; }

    public virtual DbSet<JobOld> JobOlds { get; set; }

    public virtual DbSet<Leave> Leaves { get; set; }

    public virtual DbSet<NoteSpese> NoteSpeses { get; set; }

    public virtual DbSet<NoteSpeseAttachment> NoteSpeseAttachments { get; set; }

    public virtual DbSet<NoteSpeseTipoFatturazione> NoteSpeseTipoFatturaziones { get; set; }

    public virtual DbSet<ObiettiviAllocazione> ObiettiviAllocaziones { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<PeriodsInvoice> PeriodsInvoices { get; set; }

    public virtual DbSet<PeriodsInvoicesStatus> PeriodsInvoicesStatuses { get; set; }

    public virtual DbSet<PeriodsInvoicesWorkFlow> PeriodsInvoicesWorkFlows { get; set; }

    public virtual DbSet<PeriodsStatus> PeriodsStatuses { get; set; }

    public virtual DbSet<PeriodsWorkFlow> PeriodsWorkFlows { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportChiara> ReportChiaras { get; set; }

    public virtual DbSet<Ruoli> Ruolis { get; set; }

    public virtual DbSet<SchedaDettaglioEsperienze> SchedaDettaglioEsperienzes { get; set; }

    public virtual DbSet<SchedaEsperienze> SchedaEsperienzes { get; set; }

    public virtual DbSet<Societum> Societa { get; set; }

    public virtual DbSet<StatoAssenza> StatoAssenzas { get; set; }

    public virtual DbSet<StatoNoteSpese> StatoNoteSpeses { get; set; }

    public virtual DbSet<StatoSchedaEsperienze> StatoSchedaEsperienzes { get; set; }

    public virtual DbSet<StatusCommesse> StatusCommesses { get; set; }

    public virtual DbSet<TemplateEmail> TemplateEmails { get; set; }

    public virtual DbSet<Timesheet> Timesheets { get; set; }

    public virtual DbSet<TimesheetBackup> TimesheetBackups { get; set; }

    public virtual DbSet<TimesheetBackup04062021> TimesheetBackup04062021s { get; set; }

    public virtual DbSet<TimesheetCost> TimesheetCosts { get; set; }

    public virtual DbSet<TipoEmail> TipoEmails { get; set; }

    public virtual DbSet<TipologiaAssenza> TipologiaAssenzas { get; set; }

    public virtual DbSet<TipologiaAttivitum> TipologiaAttivita { get; set; }

    public virtual DbSet<TipologiaCommessa> TipologiaCommessas { get; set; }

    public virtual DbSet<TipologiaCommessaAttivitum> TipologiaCommessaAttivita { get; set; }

    public virtual DbSet<TipologiaConsuntivo> TipologiaConsuntivos { get; set; }

    public virtual DbSet<TipologiaFatturazione> TipologiaFatturaziones { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserLocalAdgroup> UserLocalAdgroups { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserRoleOld> UserRoleOlds { get; set; }

    public virtual DbSet<Utenti> Utentis { get; set; }

    public virtual DbSet<UtentiBackup> UtentiBackups { get; set; }

    public virtual DbSet<UtentiCommesse> UtentiCommesses { get; set; }

    public virtual DbSet<UtentiCommesseAttivitum> UtentiCommesseAttivita { get; set; }

    public virtual DbSet<UtentiCommesseBackup20201120> UtentiCommesseBackup20201120s { get; set; }

    public virtual DbSet<UtentiCommesseTipoAttivitum> UtentiCommesseTipoAttivita { get; set; }

    public virtual DbSet<UtentiCosti> UtentiCostis { get; set; }

    public virtual DbSet<UtentiCostiBackup> UtentiCostiBackups { get; set; }

    public virtual DbSet<UtentiDaCreare> UtentiDaCreares { get; set; }

    public virtual DbSet<VCc> VCcs { get; set; }

    public virtual DbSet<VColine> VColines { get; set; }

    public virtual DbSet<VCommesse> VCommesses { get; set; }

    public virtual DbSet<VCommesseFeriePermessiMutua> VCommesseFeriePermessiMutuas { get; set; }

    public virtual DbSet<VCostiRisorseGroupComm> VCostiRisorseGroupComms { get; set; }

    public virtual DbSet<VGlobalBu> VGlobalBus { get; set; }

    public virtual DbSet<VManagerBu> VManagerBus { get; set; }

    public virtual DbSet<VPaolo> VPaolos { get; set; }

    public virtual DbSet<VPartialValue> VPartialValues { get; set; }

    public virtual DbSet<VQuadratura> VQuadraturas { get; set; }

    public virtual DbSet<VSea> VSeas { get; set; }

    public virtual DbSet<VSilatech> VSilateches { get; set; }

    public virtual DbSet<VSilatech2023> VSilatech2023s { get; set; }

    public virtual DbSet<ViewBustePaga> ViewBustePagas { get; set; }

    public virtual DbSet<ViewDaysPerMonth> ViewDaysPerMonths { get; set; }

    public virtual DbSet<ViewEffortBuTot> ViewEffortBuTots { get; set; }

    public virtual DbSet<ViewEffortBuTotOld> ViewEffortBuTotOlds { get; set; }

    public virtual DbSet<ViewEffortBuTotalNewOld> ViewEffortBuTotalNewOlds { get; set; }

    public virtual DbSet<ViewEffortBuTotalNewOld2> ViewEffortBuTotalNewOld2s { get; set; }

    public virtual DbSet<ViewFeriePermessi> ViewFeriePermessis { get; set; }

    public virtual DbSet<ViewFeriePermessiForecast> ViewFeriePermessiForecasts { get; set; }

    public virtual DbSet<ViewFullPartTimeResource> ViewFullPartTimeResources { get; set; }

    public virtual DbSet<ViewGetNumDaysWorked> ViewGetNumDaysWorkeds { get; set; }

    public virtual DbSet<ViewGetNumDaysWorkedOld> ViewGetNumDaysWorkedOlds { get; set; }

    public virtual DbSet<ViewGetNumDaysWorking> ViewGetNumDaysWorkings { get; set; }

    public virtual DbSet<ViewPartialDay> ViewPartialDays { get; set; }

    public virtual DbSet<ViewUsersToBu> ViewUsersToBus { get; set; }

    public virtual DbSet<VwCompetenze> VwCompetenzes { get; set; }

    public virtual DbSet<VwEmailConfiguration> VwEmailConfigurations { get; set; }

    public virtual DbSet<VwNoteSpese> VwNoteSpeses { get; set; }

    public virtual DbSet<VwSchedeEsperienze> VwSchedeEsperienzes { get; set; }

    public virtual DbSet<WebJobLog> WebJobLogs { get; set; }

    public virtual DbSet<WebLog> WebLogs { get; set; }

    public virtual DbSet<WebLogsApi> WebLogsApis { get; set; }

    public virtual DbSet<WebLogsApiBackup> WebLogsApiBackups { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    public virtual DbSet<WorkerJob> WorkerJobs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Password=P@ssword01!;Persist Security Info=True;User ID=timesheetdbsqlsrv;Initial Catalog=TimesheetDB;Data Source=timesheetdbsqlsrv.database.windows.net,1433");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("a");

            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoTotaleStrutturaGiornaliero).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ExtraHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Valore).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<Activity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Activity");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ambito>(entity =>
        {
            entity.ToTable("Ambito", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AmbitoCompetenza>(entity =>
        {
            entity.ToTable("AmbitoCompetenza", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Idambito).HasColumnName("IDAmbito");
            entity.Property(e => e.Idcompetenza).HasColumnName("IDCompetenza");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdcompetenzaNavigation).WithMany(p => p.AmbitoCompetenzas)
                .HasForeignKey(d => d.Idcompetenza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AmbitoCompetenza_Competenza");
        });

        modelBuilder.Entity<Assenza>(entity =>
        {
            entity.ToTable("Assenza", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Idapprovatore).HasColumnName("IDApprovatore");
            entity.Property(e => e.IdtipologiaAssenza).HasColumnName("IDTipologiaAssenza");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.TimeStampApprovazione).HasColumnType("datetime");
            entity.Property(e => e.TimeStampInserimento).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.ToTable("Attachment", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.FileBase64String).IsUnicode(false);
            entity.Property(e => e.FileExtension).HasMaxLength(50);
            entity.Property(e => e.FileName).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<B>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("b");

            entity.Property(e => e.CostoTotaleGiornaliero).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CostoTotaleStrutturaGiornaliero).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.GiorniEffettivi).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.OreEffettive).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.OreStraordinario).HasColumnType("decimal(38, 2)");
        });

        modelBuilder.Entity<BusinessUnit>(entity =>
        {
            entity.ToTable("BusinessUnit", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Claudium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodiceNewJobTable)
                .HasMaxLength(255)
                .HasColumnName("CODICE NEW JOB TABLE");
            entity.Property(e => e.CodiceOldJobTable)
                .HasMaxLength(255)
                .HasColumnName("CODICE OLD JOB TABLE");
            entity.Property(e => e.DataFine)
                .HasColumnType("datetime")
                .HasColumnName("data fine");
            entity.Property(e => e.DataInizio)
                .HasColumnType("datetime")
                .HasColumnName("data inizio");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(255);
            entity.Property(e => e.Note).HasColumnType("datetime");
            entity.Property(e => e.Persone)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Clienti>(entity =>
        {
            entity.ToTable("Clienti", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdOldJobTable).HasColumnName("_idOldJobTable");
            entity.Property(e => e.Vatnumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VATNumber");
        });

        modelBuilder.Entity<CodaInvioEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QueueSendEmail");

            entity.ToTable("CodaInvioEmail", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Body).IsUnicode(false);
            entity.Property(e => e.Cc).IsUnicode(false);
            entity.Property(e => e.Ccn).IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DataDiInvio).HasColumnType("datetime");
            entity.Property(e => e.From).IsUnicode(false);
            entity.Property(e => e.Host)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IdtipoMail).HasColumnName("IDTipoMail");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Pwd)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Subject)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.To).IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdtipoMailNavigation).WithMany(p => p.CodaInvioEmails)
                .HasForeignKey(d => d.IdtipoMail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodaInvioMail_TipoMail");
        });

        modelBuilder.Entity<CodaInvioEmailAttachment>(entity =>
        {
            entity.HasKey(e => new { e.IdcodaInvioEmail, e.Idattachment });

            entity.ToTable("CodaInvioEmailAttachment", "TimesheetManagement");

            entity.Property(e => e.IdcodaInvioEmail).HasColumnName("IDCodaInvioEmail");
            entity.Property(e => e.Idattachment).HasColumnName("IDAttachment");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdattachmentNavigation).WithMany(p => p.CodaInvioEmailAttachments)
                .HasForeignKey(d => d.Idattachment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodaInvioEmailAttachment_Attachment");

            entity.HasOne(d => d.IdcodaInvioEmailNavigation).WithMany(p => p.CodaInvioEmailAttachments)
                .HasForeignKey(d => d.IdcodaInvioEmail)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CodaInvioEmailAttachment_CodaInvioEmailAttachment");
        });

        modelBuilder.Entity<Commesse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Commesse_ID");

            entity.ToTable("Commesse", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GiorniPrevisti).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IdOldJobTable).HasColumnName("_idOldJobTable");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.IdtipologiaCommessa).HasColumnName("IDTipologiaCommessa");
            entity.Property(e => e.IdtipologiaFatturazione).HasColumnName("IDTipologiaFatturazione");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RicaviPrevisti).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<CommesseInterne>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CommesseInterne");

            entity.Property(e => e.Bu).HasColumnName("BU");
            entity.Property(e => e.CodiceNew)
                .HasMaxLength(255)
                .HasColumnName("Codice NEW");
            entity.Property(e => e.CodiceOld)
                .HasMaxLength(255)
                .HasColumnName("codice OLD");
            entity.Property(e => e.NewJobTable)
                .HasMaxLength(255)
                .HasColumnName("NEW JOB TABLE");
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .HasColumnName("NOTE");
            entity.Property(e => e.OldJobTable)
                .HasMaxLength(255)
                .HasColumnName("OLD JOB TABLE");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Company");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Competenza>(entity =>
        {
            entity.ToTable("Competenza", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Key);

            entity.ToTable("Configuration", "TimesheetManagement");

            entity.Property(e => e.Key).HasMaxLength(255);
            entity.Property(e => e.Value).HasMaxLength(255);
        });

        modelBuilder.Entity<Contratti>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Contratti", "UserManagement");

            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.TipoContratto).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_Costi_All");

            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OreTotali).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaCostoTotale).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreExtra).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreOrdinarie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StatoCommessa).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiComm3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_COSTI_COMM_3");

            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OreTotali).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaCostoTotale).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreExtra).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreOrdinarie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StatoCommessa).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiCommessa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_Costi_Commessa");

            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OreTotali).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaCostoTotale).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreExtra).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreOrdinarie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StatoCommessa).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiCommessaDef>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_Costi_Commessa_DEF");

            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OreTotali).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaCostoTotale).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreExtra).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreOrdinarie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StatoCommessa).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiCommessaOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_Costi_Commessa_OLD");

            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OreTotali).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaCostoTotale).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreExtra).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SommaOreOrdinarie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.StatoCommessa).HasMaxLength(255);
        });

        modelBuilder.Entity<CrmCostiRisorsa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRM_Costi_risorsa");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NomeCommessa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Customer");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ElencoAccessi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ElencoAc__3214EC27E8784B8C");

            entity.ToTable("ElencoAccessi", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DataLogin).HasColumnType("datetime");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
        });

        modelBuilder.Entity<EmailRichiesteAssenze>(entity =>
        {
            entity.HasKey(e => e.GuidRichiesta).HasName("PK_EmailRichiestaFerie");

            entity.ToTable("EmailRichiesteAssenze", "TimesheetManagement");

            entity.Property(e => e.GuidRichiesta).ValueGeneratedNever();
            entity.Property(e => e.DataInvio).HasColumnType("datetime");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Idrichiesta).HasColumnName("IDRichiesta");
            entity.Property(e => e.OggettoMail)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TestoMail).IsUnicode(false);
        });

        modelBuilder.Entity<Festivitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Festivit__3213E83F41B4FA02");

            entity.ToTable("Festivita", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Festivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Festivity");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Worker)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HolidayName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PowerAppsId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("__PowerAppsId__");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Job");

            entity.Property(e => e.BusinessUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("businessUnit");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdOrdineCrm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idOrdineCRM");
            entity.Property(e => e.IsDescriptionMandatory).HasColumnName("isDescriptionMandatory");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.IsHolidayJob).HasColumnName("isHolidayJob");
            entity.Property(e => e.NumeroOrdineCrm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numeroOrdineCRM");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("JobActivity");

            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JobOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Job_old");

            entity.Property(e => e.BusinessUnit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("businessUnit");
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdOrdineCrm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("idOrdineCRM");
            entity.Property(e => e.IsDescriptionMandatory).HasColumnName("isDescriptionMandatory");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.IsHolidayJob).HasColumnName("isHolidayJob");
            entity.Property(e => e.NumeroOrdineCrm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("numeroOrdineCRM");
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Leave>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Leave");

            entity.Property(e => e.Approver)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Detail)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LeaveID");
            entity.Property(e => e.LeaveType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PowerAppsId)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("__PowerAppsId__");
            entity.Property(e => e.Requester)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NoteSpese>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NoteSpeseUtenti");

            entity.ToTable("NoteSpese", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnnoRiferimento).HasMaxLength(255);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idstato).HasColumnName("IDStato");
            entity.Property(e => e.IdtipoFatturazione).HasColumnName("IDTipoFatturazione");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Importo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MeseRiferimento).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdstatoNavigation).WithMany(p => p.NoteSpeses)
                .HasForeignKey(d => d.Idstato)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NoteSpeseUtenti_StatoNoteSpese");

            entity.HasOne(d => d.IdtipoFatturazioneNavigation).WithMany(p => p.NoteSpeses)
                .HasForeignKey(d => d.IdtipoFatturazione)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NoteSpese_NoteSpeseTipoFatturazione");

            entity.HasOne(d => d.IdutenteNavigation).WithMany(p => p.NoteSpeses)
                .HasForeignKey(d => d.Idutente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NoteSpeseUtenti_Utenti");
        });

        modelBuilder.Entity<NoteSpeseAttachment>(entity =>
        {
            entity.HasKey(e => new { e.AttachementId, e.NoteSpeseId });

            entity.ToTable("NoteSpeseAttachment", "TimesheetManagement");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Attachement).WithMany(p => p.NoteSpeseAttachments)
                .HasForeignKey(d => d.AttachementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NoteSpeseAttachment_Attachment");

            entity.HasOne(d => d.NoteSpese).WithMany(p => p.NoteSpeseAttachments)
                .HasForeignKey(d => d.NoteSpeseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NoteSpeseAttachment_NoteSpeseUtenti");
        });

        modelBuilder.Entity<NoteSpeseTipoFatturazione>(entity =>
        {
            entity.ToTable("NoteSpeseTipoFatturazione", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
        });

        modelBuilder.Entity<ObiettiviAllocazione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ObiettiviAllocazione");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.DatInsRec)
                .HasColumnType("datetime")
                .HasColumnName("dat_ins_rec");
            entity.Property(e => e.DatModRec)
                .HasColumnType("datetime")
                .HasColumnName("dat_mod_rec");
            entity.Property(e => e.IdObiettivo).HasColumnName("id_obiettivo");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.NumGiornateFatturabili).HasColumnName("num_giornate_fatturabili");
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods", "Invoices");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Enddate).HasColumnName("ENDDATE");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.LastPeriodIdstatus).HasColumnName("LastPeriodIDStatus");
            entity.Property(e => e.Startdate).HasColumnName("STARTDATE");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PeriodsInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods_Invoices", "Invoices");

            entity.Property(e => e.Bu)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.Cliente)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Commenti)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CrmInvoiceNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CRM_Invoice_Number");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Idperiod).HasColumnName("IDPeriod");
            entity.Property(e => e.Idrisorsa).HasColumnName("IDRisorsa");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.IdtipologiaAttivita).HasColumnName("IDTipologiaAttivita");
            entity.Property(e => e.IdtipologiaFatturazione).HasColumnName("IDTipologiaFatturazione");
            entity.Property(e => e.IdutenteCommesseAttivita).HasColumnName("IDUtenteCommesseAttivita");
            entity.Property(e => e.LastInvoiceIdstatus).HasColumnName("LastInvoiceIDStatus");
            entity.Property(e => e.NomeCommessa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("Nome_Commessa");
            entity.Property(e => e.NrCommessa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Nr_Commessa");
            entity.Property(e => e.OreOrdinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ORE_Ordinarie");
            entity.Property(e => e.OreStraordinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ORE_Straordinarie");
            entity.Property(e => e.Risorsa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TipologiaAttivita)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipologiaFatturazione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Totale).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TrueOreOrdinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("True_ORE_Ordinarie");
            entity.Property(e => e.TrueOreStraordinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("True_ORE_Straordinarie");
            entity.Property(e => e.TrueTariffaOreOrdinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("True_Tariffa_ORE_Ordinarie");
            entity.Property(e => e.TrueTariffaOreStraordinarie)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("True_Tariffa_ORE_Straordinarie");
            entity.Property(e => e.UpdateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PeriodsInvoicesStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods_Invoices_Status", "Invoices");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<PeriodsInvoicesWorkFlow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods_Invoices_WorkFlow", "Invoices");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idperiod).HasColumnName("IDPeriod");
            entity.Property(e => e.IdutenteCommesseAttivita).HasColumnName("IDUtenteCommesseAttivita");
            entity.Property(e => e.InvoiceIdstatus).HasColumnName("InvoiceIDStatus");
        });

        modelBuilder.Entity<PeriodsStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods_Status", "Invoices");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<PeriodsWorkFlow>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Periods_WorkFlow", "Invoices");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Idperiod).HasColumnName("IDPeriod");
            entity.Property(e => e.PeriodIdstatus).HasColumnName("PeriodIDStatus");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Report");

            entity.Property(e => e.AdminExtraHoursId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Text).HasColumnType("text");
            entity.Property(e => e.WorkerUsername)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ReportChiara>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("reportChiara");

            entity.Property(e => e.BuRisorsa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU Risorsa");
            entity.Property(e => e.CodiceCommessa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Codice Commessa");
            entity.Property(e => e.Consuntivo).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DataFineCommessa)
                .HasColumnType("datetime")
                .HasColumnName("Data Fine Commessa");
            entity.Property(e => e.DataInizioCommessa)
                .HasColumnType("datetime")
                .HasColumnName("Data Inizio Commessa");
            entity.Property(e => e.DescrizioneCommessa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Descrizione Commessa");
            entity.Property(e => e.Risorsa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Straordinario).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<Ruoli>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ruoli_ID");

            entity.ToTable("Ruoli", "UserManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SchedaDettaglioEsperienze>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DettaglioSchedaCompetenze");

            entity.ToTable("SchedaDettaglioEsperienze", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.IdambitoCompetenza).HasColumnName("IDAmbitoCompetenza");
            entity.Property(e => e.IdschedaEsperienza).HasColumnName("IDSchedaEsperienza");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdambitoCompetenzaNavigation).WithMany(p => p.SchedaDettaglioEsperienzes)
                .HasForeignKey(d => d.IdambitoCompetenza)
                .HasConstraintName("FK_SchedaDettaglioEsperienze_AmbitoCompetenza");

            entity.HasOne(d => d.IdschedaEsperienzaNavigation).WithMany(p => p.SchedaDettaglioEsperienzes)
                .HasForeignKey(d => d.IdschedaEsperienza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SchedaDettaglioEsperienze_SchedaEsperienze");
        });

        modelBuilder.Entity<SchedaEsperienze>(entity =>
        {
            entity.ToTable("SchedaEsperienze", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idstato).HasColumnName("IDStato");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.IdstatoNavigation).WithMany(p => p.SchedaEsperienzes)
                .HasForeignKey(d => d.Idstato)
                .HasConstraintName("FK_SchedaEsperienze_StatoSchedaEsperienze");

            entity.HasOne(d => d.IdutenteNavigation).WithMany(p => p.SchedaEsperienzes)
                .HasForeignKey(d => d.Idutente)
                .HasConstraintName("FK_SchedaEsperienze_Utenti");
        });

        modelBuilder.Entity<Societum>(entity =>
        {
            entity.ToTable("Societa", "AdminManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IdOldJobTable).HasColumnName("_idOldJobTable");
        });

        modelBuilder.Entity<StatoAssenza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("StatoAssenza", "TimesheetManagement");

            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<StatoNoteSpese>(entity =>
        {
            entity.ToTable("StatoNoteSpese", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
        });

        modelBuilder.Entity<StatoSchedaEsperienze>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_STatoSchedaEsperienze");

            entity.ToTable("StatoSchedaEsperienze", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
        });

        modelBuilder.Entity<StatusCommesse>(entity =>
        {
            entity.ToTable("StatusCommesse", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
        });

        modelBuilder.Entity<TemplateEmail>(entity =>
        {
            entity.ToTable("TemplateEmail", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdtipoEmail).HasColumnName("IDTipoEmail");

            entity.HasOne(d => d.IdtipoEmailNavigation).WithMany(p => p.TemplateEmails)
                .HasForeignKey(d => d.IdtipoEmail)
                .HasConstraintName("FK_TemplateEmail_TipoEmail");
        });

        modelBuilder.Entity<Timesheet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Timesheet_Id");

            entity.ToTable("Timesheet", "TimesheetManagement");

            entity.HasIndex(e => new { e.IdutentiCommesseAttivita, e.ShortDate }, "nci_wi_Timesheet_1620086ABFC2A4FA4638FFAD8CC57A56");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ExtraHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.IdtipologiaConsuntivo).HasColumnName("IDTipologiaConsuntivo");
            entity.Property(e => e.IdutentiCommesseAttivita).HasColumnName("IDUtentiCommesseAttivita");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.OrarioIn).HasPrecision(0);
            entity.Property(e => e.OrarioOut).HasPrecision(0);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Valore).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<TimesheetBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Timesheet_Backup", "TimesheetManagement");

            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ExtraHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdtipologiaConsuntivo).HasColumnName("IDTipologiaConsuntivo");
            entity.Property(e => e.IdutentiCommesseAttivita).HasColumnName("IDUtentiCommesseAttivita");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Valore).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<TimesheetBackup04062021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Timesheet_Backup_04062021", "TimesheetManagement");

            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ExtraHours).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdtipologiaConsuntivo).HasColumnName("IDTipologiaConsuntivo");
            entity.Property(e => e.IdutentiCommesseAttivita).HasColumnName("IDUtentiCommesseAttivita");
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Valore).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<TimesheetCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TimesheetCost_Id");

            entity.ToTable("TimesheetCost", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Costo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.IdutentiCommesse).HasColumnName("IDUtentiCommesse");
            entity.Property(e => e.Ricavo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Valore).HasColumnType("decimal(5, 2)");
        });

        modelBuilder.Entity<TipoEmail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TipoMail");

            entity.ToTable("TipoEmail", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
        });

        modelBuilder.Entity<TipologiaAssenza>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TipologiaAssenza", "TimesheetManagement");

            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
        });

        modelBuilder.Entity<TipologiaAttivitum>(entity =>
        {
            entity.ToTable("TipologiaAttivita", "TimesheetManagement");

            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipologiaCommessa>(entity =>
        {
            entity.ToTable("TipologiaCommessa", "TimesheetManagement");

            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipologiaCommessaAttivitum>(entity =>
        {
            entity.ToTable("TipologiaCommessaAttivita", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TipologiaConsuntivo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TipologiaConsuntivo_ID");

            entity.ToTable("TipologiaConsuntivo", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipologiaFatturazione>(entity =>
        {
            entity.ToTable("TipologiaFatturazione", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserLocalAdgroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("UserLocalADGroups_pk");

            entity.ToTable("UserLocalADGroups", tb => tb.HasComment("I gruppi speciali che possono essere assegnati alle utenze su AD Locale"));

            entity.HasIndex(e => e.Id, "UserLocalADGroups_ID_uindex").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Group)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRole");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRoleOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserRole_old");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Utenti>(entity =>
        {
            entity
                .ToTable("Utenti", "UserManagement")
                .ToTable(tb => tb.IsTemporal(ttb =>
                    {
                        ttb.UseHistoryTable("Utenti_HISTORY", "UserManagement");
                        ttb
                            .HasPeriodStart("SysStart")
                            .HasColumnName("SysStart");
                        ttb
                            .HasPeriodEnd("SysEnd")
                            .HasColumnName("SysEnd");
                    }));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Badge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idmanager).HasColumnName("IDManager");
            entity.Property(e => e.Idruolo).HasColumnName("IDRuolo");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.LoginName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OreGiorno).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.QtyGiorni).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<UtentiBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Utenti_backup", "UserManagement");

            entity.Property(e => e.Badge)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoStraordinario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idmanager).HasColumnName("IDManager");
            entity.Property(e => e.Idruolo).HasColumnName("IDRuolo");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.LoginName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OreGiorno).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.QtyGiorni).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<UtentiCommesse>(entity =>
        {
            entity.ToTable("UtentiCommesse", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Allocazione).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.SedeLavoro).HasMaxLength(255);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<UtentiCommesseAttivitum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UtentiCommesseAttivita_ID");

            entity.ToTable("UtentiCommesseAttivita", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdtipoAttivita).HasColumnName("IDTipoAttivita");
            entity.Property(e => e.IdutentiCommesse).HasColumnName("IDUtentiCommesse");

            entity.HasOne(d => d.IdtipoAttivitaNavigation).WithMany(p => p.UtentiCommesseAttivita)
                .HasForeignKey(d => d.IdtipoAttivita)
                .HasConstraintName("FK_UtentiCommesseAttivita_IDTipoAttivita");
        });

        modelBuilder.Entity<UtentiCommesseBackup20201120>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtentiCommesse_backup20201120", "TimesheetManagement");

            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.SedeLavoro).HasMaxLength(255);
            entity.Property(e => e.Tariffa).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<UtentiCommesseTipoAttivitum>(entity =>
        {
            entity.ToTable("UtentiCommesseTipoAttivita", "TimesheetManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdtipoAttivita).HasColumnName("IDTipoAttivita");
            entity.Property(e => e.IdutentiCommesse).HasColumnName("IDUtentiCommesse");

            entity.HasOne(d => d.IdtipoAttivitaNavigation).WithMany(p => p.UtentiCommesseTipoAttivita)
                .HasForeignKey(d => d.IdtipoAttivita)
                .HasConstraintName("FK_UtentiCommesseTipoAttivita_TipologiaAttivita");
        });

        modelBuilder.Entity<UtentiCosti>(entity =>
        {
            entity.ToTable("UtentiCosti", "UserManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CostoFeriePermessi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoMutua).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoSmartWorking).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
        });

        modelBuilder.Entity<UtentiCostiBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtentiCosti_Backup", "UserManagement");

            entity.Property(e => e.CostoFeriePermessi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoMutua).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoOrdinario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoSmartWorking).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoStruttura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
        });

        modelBuilder.Entity<UtentiDaCreare>(entity =>
        {
            entity.ToTable("UtentiDaCreare", "UserManagement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreatorEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecialGroups).IsUnicode(false);
        });

        modelBuilder.Entity<VCc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_cc", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ore");
        });

        modelBuilder.Entity<VColine>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_colines", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ore");
            entity.Property(e => e.Tariffaoraria)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("tariffaoraria");
        });

        modelBuilder.Entity<VCommesse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Commesse", "Report");

            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GiorniPrevisti).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idordine).HasColumnName("IDOrdine");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.IdtipologiaCommessa).HasColumnName("IDTipologiaCommessa");
            entity.Property(e => e.IdtipologiaFatturazione).HasColumnName("IDTipologiaFatturazione");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RateOrario)
                .HasColumnType("decimal(38, 28)")
                .HasColumnName("rateOrario");
            entity.Property(e => e.RicaviPrevisti).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<VCommesseFeriePermessiMutua>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_CommesseFeriePermessiMutua");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VCostiRisorseGroupComm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_COSTI_RISORSE_GROUP_COMM");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Costo).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CostoCompl)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("costoCompl");
            entity.Property(e => e.CostoStru)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("costoStru");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ore");
            entity.Property(e => e.Risorsa)
                .HasMaxLength(101)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VGlobalBu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_globalBU", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ore");
            entity.Property(e => e.Tariffaoraria)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("tariffaoraria");
        });

        modelBuilder.Entity<VManagerBu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_ManagerBU");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Manager)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPaolo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_paolo", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Giorni)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("giorni");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VPartialValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_PartialValues");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Gtot).HasColumnName("gtot");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.Reportdate)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("reportdate");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<VQuadratura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Quadratura", "Report");

            entity.Property(e => e.CodiceNewJobTable)
                .HasMaxLength(255)
                .HasColumnName("CODICE NEW JOB TABLE");
            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mesenew).HasColumnName("mesenew");
            entity.Property(e => e.Meseold).HasColumnName("meseold");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nr");
            entity.Property(e => e.Totaleold).HasColumnName("totaleold");
            entity.Property(e => e.Totalnew)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("totalnew");
            entity.Property(e => e.WorkerUsername)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VSea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_sea", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ore");
            entity.Property(e => e.Tariffaoraria)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("tariffaoraria");
        });

        modelBuilder.Entity<VSilatech>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_silatech", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ore");
        });

        modelBuilder.Entity<VSilatech2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_silatech2023", "Report");

            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(4000)
                .IsUnicode(false);
            entity.Property(e => e.Ore)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("ore");
            entity.Property(e => e.Tariffa)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("tariffa");
        });

        modelBuilder.Entity<ViewBustePaga>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Buste_Paga");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.Consuntivo).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Descrizione)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DescrizioneCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Giorno).HasColumnName("giorno");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewDaysPerMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_daysPerMonth");

            entity.Property(e => e.NDaysMonth).HasColumnName("nDaysMonth");
        });

        modelBuilder.Entity<ViewEffortBuTot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Effort_BU_Tot");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.BilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.BuManager)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("BU_Manager");
            entity.Property(e => e.BuName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU_Name");
            entity.Property(e => e.CodCommessa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("codCommessa");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EuropeanPrjDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FeriePermessi).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FullPartTime).HasColumnName("fullPartTime");
            entity.Property(e => e.HolidayJobDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idmanager).HasColumnName("IDManager");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.InizioMese).HasColumnType("datetime");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.Mutua).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.NomeRisorsa)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.NotBilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.PartialDays)
                .HasColumnType("numeric(21, 12)")
                .HasColumnName("partialDays");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEffortBuTotOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Effort_BU_Tot_old");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.BilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.BuManager)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("BU_Manager");
            entity.Property(e => e.BuName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU_Name");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EuropeanPrjDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FeriePermessi).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FullPartTime).HasColumnName("fullPartTime");
            entity.Property(e => e.HolidayJobDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Idbu).HasColumnName("IDBU");
            entity.Property(e => e.Idmanager).HasColumnName("IDManager");
            entity.Property(e => e.Idsocieta).HasColumnName("IDSocieta");
            entity.Property(e => e.InizioMese).HasColumnType("datetime");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.Mutua).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.NotBilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.PartialDays)
                .HasColumnType("numeric(21, 12)")
                .HasColumnName("partialDays");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEffortBuTotalNewOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Effort_BU_Total_NEW_OLD");

            entity.Property(e => e.AdminGroupUsername)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.CompanyJobName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EuropeanPrjDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FeriePermessi).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.HolidayJobDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.Mutua).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.NotBilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEffortBuTotalNewOld2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Effort_BU_Total_NEW_OLD2");

            entity.Property(e => e.AdminGroupUsername)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.CompanyJobName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Descrizione)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EuropeanPrjDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.FeriePermessi).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.HolidayJobDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.IsEuropeanPrj).HasColumnName("isEuropeanPrj");
            entity.Property(e => e.Mutua).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.NotBilledDays).HasColumnType("decimal(10, 1)");
            entity.Property(e => e.Nr)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewFeriePermessi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ferie_Permessi");

            entity.Property(e => e.AssenzaOdierna)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("assenzaOdierna");
            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Forecast).HasColumnName("forecast");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Motivorichiesta)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motivorichiesta");
            entity.Property(e => e.OreRichieste)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ore_richieste");
            entity.Property(e => e.Richiedente)
                .HasMaxLength(101)
                .IsUnicode(false);
            entity.Property(e => e.Stato)
                .HasMaxLength(255)
                .IsFixedLength();
            entity.Property(e => e.StatoRic).HasColumnName("Stato_Ric");
            entity.Property(e => e.TipoAssenza).HasColumnName("tipoAssenza");
            entity.Property(e => e.Tipologia).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewFeriePermessiForecast>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ferie_Permessi_Forecast");

            entity.Property(e => e.Ferie)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("ferie");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Permesso)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("permesso");
        });

        modelBuilder.Entity<ViewFullPartTimeResource>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Full_Part_Time_Resources");

            entity.Property(e => e.FullPartTime)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("full_part_Time");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LoginName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewGetNumDaysWorked>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_getNumDaysWorked");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkedDays).HasColumnName("workedDays");
        });

        modelBuilder.Entity<ViewGetNumDaysWorkedOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_getNumDaysWorked_old");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkedDays).HasColumnName("workedDays");
        });

        modelBuilder.Entity<ViewGetNumDaysWorking>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_getNumDaysWorking");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.NumberOfWorkingDays).HasColumnName("numberOfWorkingDays");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
        });

        modelBuilder.Entity<ViewPartialDay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_partialDays");

            entity.Property(e => e.Anno).HasColumnName("anno");
            entity.Property(e => e.Mese).HasColumnName("mese");
            entity.Property(e => e.NumberOfWorkingDays).HasColumnName("numberOfWorkingDays");
            entity.Property(e => e.PartialDays)
                .HasColumnType("numeric(21, 12)")
                .HasColumnName("partialDays");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkedDays).HasColumnName("workedDays");
        });

        modelBuilder.Entity<ViewUsersToBu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Users_to_BU");

            entity.Property(e => e.Bu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BU");
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Mail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nominativo)
                .HasMaxLength(101)
                .IsUnicode(false)
                .HasColumnName("nominativo");
        });

        modelBuilder.Entity<VwCompetenze>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwCompetenze", "AdminManagement");

            entity.Property(e => e.Ambito).HasMaxLength(255);
            entity.Property(e => e.Competenza).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idambito).HasColumnName("IDAmbito");
            entity.Property(e => e.Idcompetenza).HasColumnName("IDCompetenza");
        });

        modelBuilder.Entity<VwEmailConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwEmailConfiguration", "TimesheetManagement");

            entity.Property(e => e.SmtpDefaultCredentials).HasColumnName("SMTP_DEFAULT_CREDENTIALS");
            entity.Property(e => e.SmtpEnableSsl).HasColumnName("SMTP_ENABLE_SSL");
            entity.Property(e => e.SmtpFrom)
                .HasMaxLength(255)
                .HasColumnName("SMTP_FROM");
            entity.Property(e => e.SmtpHost)
                .HasMaxLength(255)
                .HasColumnName("SMTP_HOST");
            entity.Property(e => e.SmtpIsBodyHtml).HasColumnName("SMTP_IS_BODY_HTML");
            entity.Property(e => e.SmtpPort).HasColumnName("SMTP_PORT");
            entity.Property(e => e.SmtpPwd)
                .HasMaxLength(255)
                .HasColumnName("SMTP_PWD");
            entity.Property(e => e.SmtpTimeout).HasColumnName("SMTP_TIMEOUT");
            entity.Property(e => e.SmtpUser)
                .HasMaxLength(255)
                .HasColumnName("SMTP_USER");
        });

        modelBuilder.Entity<VwNoteSpese>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwNoteSpese", "TimesheetManagement");

            entity.Property(e => e.AnnoRiferimento).HasMaxLength(255);
            entity.Property(e => e.Cognome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commessa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Descrizione).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idstato).HasColumnName("IDStato");
            entity.Property(e => e.IdtipoFatturazione).HasColumnName("IDTipoFatturazione");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.Importo).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MeseRiferimento).HasMaxLength(255);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stato).HasMaxLength(255);
            entity.Property(e => e.TipoFatturazione)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwSchedeEsperienze>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwSchedeEsperienze", "TimesheetManagement");

            entity.Property(e => e.Cliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CognomeUtente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Commessa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DataFine).HasColumnType("datetime");
            entity.Property(e => e.DataInizio).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Idcommessa).HasColumnName("IDCommessa");
            entity.Property(e => e.Idstato).HasColumnName("IDStato");
            entity.Property(e => e.Idutente).HasColumnName("IDUtente");
            entity.Property(e => e.NomeUtente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Stato).HasMaxLength(255);
        });

        modelBuilder.Entity<WebJobLog>(entity =>
        {
            entity.HasKey(e => new { e.LogCurrentUser, e.LogDatetime });

            entity.ToTable("WebJob_Logs");

            entity.Property(e => e.LogCurrentUser)
                .HasMaxLength(255)
                .HasColumnName("LOG_CURRENT_USER");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_DATETIME");
            entity.Property(e => e.LogClass)
                .HasMaxLength(255)
                .HasColumnName("LOG_CLASS");
            entity.Property(e => e.LogMessage).HasColumnName("LOG_MESSAGE");
            entity.Property(e => e.LogMethod)
                .HasMaxLength(255)
                .HasColumnName("LOG_METHOD");
        });

        modelBuilder.Entity<WebLog>(entity =>
        {
            entity.HasKey(e => new { e.LogCurrentUser, e.LogDatetime });

            entity.ToTable("Web_Logs");

            entity.Property(e => e.LogCurrentUser)
                .HasMaxLength(255)
                .HasColumnName("LOG_CURRENT_USER");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_DATETIME");
            entity.Property(e => e.LogClass)
                .HasMaxLength(255)
                .HasColumnName("LOG_CLASS");
            entity.Property(e => e.LogMessage).HasColumnName("LOG_MESSAGE");
            entity.Property(e => e.LogMethod)
                .HasMaxLength(255)
                .HasColumnName("LOG_METHOD");
        });

        modelBuilder.Entity<WebLogsApi>(entity =>
        {
            entity.ToTable("Web_LogsApi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LogClass)
                .IsUnicode(false)
                .HasColumnName("LOG_CLASS");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_DATETIME");
            entity.Property(e => e.LogJson)
                .IsUnicode(false)
                .HasColumnName("LOG_JSON");
            entity.Property(e => e.LogMethod)
                .IsUnicode(false)
                .HasColumnName("LOG_METHOD");
        });

        modelBuilder.Entity<WebLogsApiBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Web_LogsApi_backup");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LogClass)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("LOG_CLASS");
            entity.Property(e => e.LogDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOG_DATETIME");
            entity.Property(e => e.LogJson)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("LOG_JSON");
            entity.Property(e => e.LogMethod)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("LOG_METHOD");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Worker");

            entity.Property(e => e.AdminGroupUsername)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorporatePhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.FiscalCode)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LegacyEmail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkerJob>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.JobId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkerUsername)
                .HasMaxLength(16)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
