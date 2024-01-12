using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HexaReportApp.Models;

public partial class CtimeContext : DbContext
{
    public CtimeContext()
    {
    }

    public CtimeContext(DbContextOptions<CtimeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CatMast> CatMasts { get; set; }

    public virtual DbSet<CompUser> CompUsers { get; set; }

    public virtual DbSet<CompanyMast> CompanyMasts { get; set; }

    public virtual DbSet<CurrentLogin> CurrentLogins { get; set; }

    public virtual DbSet<DepartMast> DepartMasts { get; set; }

    public virtual DbSet<DesgMast> DesgMasts { get; set; }

    public virtual DbSet<EmpMast> EmpMasts { get; set; }

    public virtual DbSet<EnrollDatum> EnrollData { get; set; }

    public virtual DbSet<EnrollFacedatum> EnrollFacedata { get; set; }

    public virtual DbSet<HeadMast> HeadMasts { get; set; }

    public virtual DbSet<HolidayMast> HolidayMasts { get; set; }

    public virtual DbSet<LeaveApp> LeaveApps { get; set; }

    public virtual DbSet<LeaveBal> LeaveBals { get; set; }

    public virtual DbSet<LeaveMast> LeaveMasts { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Machine> Machines { get; set; }

    public virtual DbSet<MonthReport> MonthReports { get; set; }

    public virtual DbSet<PMail> PMails { get; set; }

    public virtual DbSet<PSm> PSms { get; set; }

    public virtual DbSet<Prcard> Prcards { get; set; }

    public virtual DbSet<Salary> Salaries { get; set; }

    public virtual DbSet<SetUp> SetUps { get; set; }

    public virtual DbSet<SfGenerator> SfGenerators { get; set; }

    public virtual DbSet<Sfgroup> Sfgroups { get; set; }

    public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }

    public virtual DbSet<ShiftPattern> ShiftPatterns { get; set; }

    public virtual DbSet<SubTime> SubTimes { get; set; }

    public virtual DbSet<TextfileDatum> TextfileData { get; set; }

    public virtual DbSet<UserRight> UserRights { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CatMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CatMast");

            entity.Property(e => e.Aiflt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AIFLT");
            entity.Property(e => e.Aifwrk)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AIFWRK");
            entity.Property(e => e.Aio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AIO");
            entity.Property(e => e.CatDesc)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CatId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EarlyAllow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Early_Allow");
            entity.Property(e => e.EarlyDepart)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Early_Depart");
            entity.Property(e => e.EarlyIgnore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Early_Ignore");
            entity.Property(e => e.Filo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILO");
            entity.Property(e => e.Hdiflt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HDIFLT");
            entity.Property(e => e.Hdifwr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HDIFWR");
            entity.Property(e => e.LateAllow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Late_Allow");
            entity.Property(e => e.LateIgnore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Late_Ignore");
            entity.Property(e => e.LateS)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("late_s");
            entity.Property(e => e.Less)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nolate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nolate");
            entity.Property(e => e.OtIgnore)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OT_Ignore");
            entity.Property(e => e.Otmul)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OTMUL");
            entity.Property(e => e.OverTimeAllow)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OverTime_Allow");
            entity.Property(e => e.Sfhrsot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SFHRSOT");
            entity.Property(e => e.Wos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WOS");
        });

        modelBuilder.Entity<CompUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompUser");

            entity.Property(e => e.Comp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Users)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CompanyMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CompanyMast");

            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email).IsUnicode(false);
            entity.Property(e => e.Fax)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Strength)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WebSite)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CurrentLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CurrentLogin");

            entity.Property(e => e.LoginName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfflineKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfflineKey1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OfflineKey2).IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Reg)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("REG");
            entity.Property(e => e.RegCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegCount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DepartMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DepartMast");

            entity.Property(e => e.DepartId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DepartName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DesgMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DesgMast");

            entity.Property(e => e.DesgId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmpMast>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EmpMast__3214EC07A4550417");

            entity.ToTable("EmpMast");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.Ah1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AH1");
            entity.Property(e => e.Ah2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AH2");
            entity.Property(e => e.Ah3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AH3");
            entity.Property(e => e.Ah4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AH4");
            entity.Property(e => e.Ah5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("AH5");
            entity.Property(e => e.Bank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("bank");
            entity.Property(e => e.Blood)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("blood");
            entity.Property(e => e.Cardno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cardstatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CatName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Catid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Col)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("col");
            entity.Property(e => e.CompName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Compid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Crim)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("crim");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Deptid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DesgName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Desgid)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dh1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DH1");
            entity.Property(e => e.Dh2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DH2");
            entity.Property(e => e.Dh3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DH3");
            entity.Property(e => e.Dh4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DH4");
            entity.Property(e => e.Dh5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DH5");
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Doj)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOJ");
            entity.Property(e => e.Dt1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DT1");
            entity.Property(e => e.Dw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DW");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ENT");
            entity.Property(e => e.Esino)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESINO");
            entity.Property(e => e.Ext1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ext1");
            entity.Property(e => e.Ext2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ext2");
            entity.Property(e => e.Father)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fathersmo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fathersmo");
            entity.Property(e => e.Height)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("height");
            entity.Property(e => e.Hw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HW");
            entity.Property(e => e.LShift)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("L_shift");
            entity.Property(e => e.Mw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MW");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pfno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PFNO");
            entity.Property(e => e.Pin)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quali)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("quali");
            entity.Property(e => e.SatHalf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sat_half");
            entity.Property(e => e.SatOff)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Sat_Off");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SfPattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sf_Pattern");
            entity.Property(e => e.SfPatternCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sf_Pattern_Code");
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StartingSf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Starting_Sf");
            entity.Property(e => e.StartingSfDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Starting_Sf_Date");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusE)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("STATUS_E");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Weight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("weight");
            entity.Property(e => e.Woff1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("woff1");
            entity.Property(e => e.Woff2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("woff2");
        });

        modelBuilder.Entity<EnrollDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.F0).IsUnicode(false);
            entity.Property(e => e.F1).IsUnicode(false);
            entity.Property(e => e.F2).IsUnicode(false);
            entity.Property(e => e.F3).IsUnicode(false);
            entity.Property(e => e.F4).IsUnicode(false);
            entity.Property(e => e.F5).IsUnicode(false);
            entity.Property(e => e.F6).IsUnicode(false);
            entity.Property(e => e.F7).IsUnicode(false);
            entity.Property(e => e.F8).IsUnicode(false);
            entity.Property(e => e.F9).IsUnicode(false);
            entity.Property(e => e.Pwdata).HasColumnName("PWData");
        });

        modelBuilder.Entity<EnrollFacedatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EnrollFACEData");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Face).HasColumnName("FACE");
            entity.Property(e => e.Pwdata).HasColumnName("PWData");
        });

        modelBuilder.Entity<HeadMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HeadMast");

            entity.Property(e => e.Ah1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AH1");
            entity.Property(e => e.Ah2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AH2");
            entity.Property(e => e.Ah3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AH3");
            entity.Property(e => e.Ah4)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AH4");
            entity.Property(e => e.Ah5)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("AH5");
            entity.Property(e => e.An1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN1");
            entity.Property(e => e.An2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN2");
            entity.Property(e => e.An3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN3");
            entity.Property(e => e.An4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN4");
            entity.Property(e => e.An5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AN5");
            entity.Property(e => e.Dh1)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DH1");
            entity.Property(e => e.Dh2)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DH2");
            entity.Property(e => e.Dh3)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DH3");
            entity.Property(e => e.Dh4)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DH4");
            entity.Property(e => e.Dh5)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("DH5");
            entity.Property(e => e.Dn1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DN1");
            entity.Property(e => e.Dn2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DN2");
            entity.Property(e => e.Dn3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DN3");
            entity.Property(e => e.Dn4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DN4");
            entity.Property(e => e.Dn5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DN5");
            entity.Property(e => e.Esi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESI");
            entity.Property(e => e.Fpf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FPF");
            entity.Property(e => e.Pf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PF");
            entity.Property(e => e.Prf1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf1");
            entity.Property(e => e.Prf11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf11");
            entity.Property(e => e.Prf2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf2");
            entity.Property(e => e.Prf22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf22");
            entity.Property(e => e.Prf3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf3");
            entity.Property(e => e.Prf33)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf33");
            entity.Property(e => e.Prf4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf4");
            entity.Property(e => e.Prf44)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf44");
            entity.Property(e => e.Prf5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf5");
            entity.Property(e => e.Prf55)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf55");
            entity.Property(e => e.PrfR1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf_r1");
            entity.Property(e => e.PrfR2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf_r2");
            entity.Property(e => e.PrfR3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf_r3");
            entity.Property(e => e.PrfR4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf_r4");
            entity.Property(e => e.PrfR5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("prf_r5");
            entity.Property(e => e.Test)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TEST");
        });

        modelBuilder.Entity<HolidayMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HolidayMast");

            entity.Property(e => e.Hldate)
                .HasColumnType("datetime")
                .HasColumnName("HLDate");
            entity.Property(e => e.Hlname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HLName");
            entity.Property(e => e.Hltype)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("HLType");
        });

        modelBuilder.Entity<LeaveApp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LeaveApp");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Optype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OPType");
            entity.Property(e => e.Sr)
                .ValueGeneratedOnAdd()
                .HasColumnName("sr");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveBal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LeaveBal");

            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sr)
                .ValueGeneratedOnAdd()
                .HasColumnName("sr");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeaveMast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LeaveMast");

            entity.Property(e => e.AnnualQ)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CF");
            entity.Property(e => e.Dis)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Encash)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LeaveCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Leave_Code");
            entity.Property(e => e.MaxAcc)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Login");

            entity.Property(e => e.LoginName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Machine>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("con_status");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachineType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.P2pid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P2PID");
            entity.Property(e => e.P2pip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P2PIP");
            entity.Property(e => e.P2pport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P2PPORT");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PortNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<MonthReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MonthRep__3214EC075213B273");

            entity.ToTable("MonthReport");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BreakTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.DateString)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ei)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EI");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("EO");
            entity.Property(e => e.ErlIn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Erl_In");
            entity.Property(e => e.ErlOut)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Erl_Out");
            entity.Property(e => e.In2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.In8)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Intime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INTime");
            entity.Property(e => e.LateIn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Late_In");
            entity.Property(e => e.Lesswrk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Lin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LIN");
            entity.Property(e => e.Lout)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LOUT");
            entity.Property(e => e.Lt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("LT");
            entity.Property(e => e.MonthName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("OT");
            entity.Property(e => e.Otm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("OTM");
            entity.Property(e => e.Out1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Out7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Outtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTTime");
            entity.Property(e => e.OverTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Remark2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Shift)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalAbsent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalOverTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalPresent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TotalWork)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Wo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WO");
            entity.Property(e => e.Woff1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Woff2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PMail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("P_Mail");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Mailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAILID");
            entity.Property(e => e.SendMail)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SEND_Mail");
        });

        modelBuilder.Entity<PSm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("P_SMS");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Io)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IO");
            entity.Property(e => e.SmsSend)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SMS_SEND");
        });

        modelBuilder.Entity<Prcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PRCARD");

            entity.Property(e => e.PrCardNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_CARD_NO");
            entity.Property(e => e.PrDetail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_DETAIL");
            entity.Property(e => e.RCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("R_CODE");
        });

        modelBuilder.Entity<Salary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Salary");

            entity.Property(e => e.Absent)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ah1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AH1");
            entity.Property(e => e.Ah2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AH2");
            entity.Property(e => e.Ah3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AH3");
            entity.Property(e => e.Ah4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AH4");
            entity.Property(e => e.Ah5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AH5");
            entity.Property(e => e.Ann1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANN1");
            entity.Property(e => e.Ann2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANN2");
            entity.Property(e => e.Ann3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANN3");
            entity.Property(e => e.Ann4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANN4");
            entity.Property(e => e.Ann5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANN5");
            entity.Property(e => e.Deduction)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dh1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DH1");
            entity.Property(e => e.Dh2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DH2");
            entity.Property(e => e.Dh3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DH3");
            entity.Property(e => e.Dh4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DH4");
            entity.Property(e => e.Dh5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DH5");
            entity.Property(e => e.Dnn1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNN1");
            entity.Property(e => e.Dnn2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNN2");
            entity.Property(e => e.Dnn3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNN3");
            entity.Property(e => e.Dnn4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNN4");
            entity.Property(e => e.Dnn5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DNN5");
            entity.Property(e => e.Earning)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Esi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESI");
            entity.Property(e => e.Esin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ESIN");
            entity.Property(e => e.Fpf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FPF");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NetTotal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Net_Total");
            entity.Property(e => e.Ot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OT_");
            entity.Property(e => e.OtHour)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OT_hour");
            entity.Property(e => e.Pf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PF");
            entity.Property(e => e.Pfn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PFN");
            entity.Property(e => e.Present)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PT");
            entity.Property(e => e.Whour)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("whour");
            entity.Property(e => e.Wo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("WO");
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SetUp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SetUp");

            entity.Property(e => e.Add)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADD_");
            entity.Property(e => e.Adp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADP");
            entity.Property(e => e.Aio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AIO");
            entity.Property(e => e.Auto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("auto");
            entity.Property(e => e.Dtime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DTime");
            entity.Property(e => e.DuplicateTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fdate).HasColumnType("datetime");
            entity.Property(e => e.Filo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILO");
            entity.Property(e => e.Filowl)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FILOWL");
            entity.Property(e => e.Inf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INF");
            entity.Property(e => e.Int)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("INT");
            entity.Property(e => e.OnA)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("on_a");
            entity.Property(e => e.OnL)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("on_l");
            entity.Property(e => e.OnP)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("on_p");
            entity.Property(e => e.Outf)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTF");
            entity.Property(e => e.Outt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OUTT");
            entity.Property(e => e.PrCardNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_CARD_NO");
            entity.Property(e => e.PrDetail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PR_DETAIL");
            entity.Property(e => e.SMailid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_MAILID");
            entity.Property(e => e.SPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_PASS");
            entity.Property(e => e.SPort)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_PORT");
            entity.Property(e => e.Sm)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SM");
            entity.Property(e => e.Smtp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SMTP");
            entity.Property(e => e.Ss)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SS");
            entity.Property(e => e.Test)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("test");
            entity.Property(e => e.Uno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("uno");
            entity.Property(e => e.Wos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("wos");
        });

        modelBuilder.Entity<SfGenerator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sf_Generator");

            entity.Property(e => e.D1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D10)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D11)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D12)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D13)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D14)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D15)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D16)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D17)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D18)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D19)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D20)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D21)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D22)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D23)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D24)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D25)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D26)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D27)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D28)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D29)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D30)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D31)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D8)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.D9)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sfgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SFGroup");

            entity.Property(e => e.EmpFull)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GN");
            entity.Property(e => e.Srno)
                .ValueGeneratedOnAdd()
                .HasColumnName("SRNO");
        });

        modelBuilder.Entity<ShiftMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ShiftMaster");

            entity.Property(e => e.BreakInTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BreakOutTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftHrs)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftInTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShiftOutTime)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Shiftname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Ssd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSD");
        });

        modelBuilder.Entity<ShiftPattern>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Shift_Pattern");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SfChange)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sf_Change");
            entity.Property(e => e.SfChangeDay)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sf_Change_Day");
            entity.Property(e => e.SfPattern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Sf_Pattern");
        });

        modelBuilder.Entity<SubTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sub_time");

            entity.Property(e => e.P10i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P10I");
            entity.Property(e => e.P10o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P10O");
            entity.Property(e => e.P1i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P1I");
            entity.Property(e => e.P1o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P1O");
            entity.Property(e => e.P2i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P2I");
            entity.Property(e => e.P2o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P2O");
            entity.Property(e => e.P3i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P3I");
            entity.Property(e => e.P3o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P3O");
            entity.Property(e => e.P4i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P4I");
            entity.Property(e => e.P4o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P4O");
            entity.Property(e => e.P5i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P5I");
            entity.Property(e => e.P5o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P5O");
            entity.Property(e => e.P6i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P6I");
            entity.Property(e => e.P6o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P6O");
            entity.Property(e => e.P7i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P7I");
            entity.Property(e => e.P7o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P7O");
            entity.Property(e => e.P8i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P8I");
            entity.Property(e => e.P8o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P8O");
            entity.Property(e => e.P9i)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P9I");
            entity.Property(e => e.P9o)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("P9O");
            entity.Property(e => e.Test)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("test");
        });

        modelBuilder.Entity<TextfileDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Day)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Empcardno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Flag)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MachineNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Mflag)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MFLAG");
            entity.Property(e => e.Month)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("R_CODE");
            entity.Property(e => e.Temperature)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Time)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Year)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserRight>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Add)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Add_");
            entity.Property(e => e.Allow)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Delete)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Delete_");
            entity.Property(e => e.MasterName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modify)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Modify_");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.View)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("View_");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
