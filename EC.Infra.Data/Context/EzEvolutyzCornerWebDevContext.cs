using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EC.Infra.Data.Context
{
    public partial class EzEvolutyzCornerWebDevContext : DbContext
    {
        public EzEvolutyzCornerWebDevContext()
        {
        }

        public EzEvolutyzCornerWebDevContext(DbContextOptions<EzEvolutyzCornerWebDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccSpecOptionalHolidays> AccSpecOptionalHolidays { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountClients> AccountClients { get; set; }
        public virtual DbSet<AccountDepartments> AccountDepartments { get; set; }
        public virtual DbSet<AccountSocialMediaProfiles> AccountSocialMediaProfiles { get; set; }
        public virtual DbSet<AccountSpecificTasks> AccountSpecificTasks { get; set; }
        public virtual DbSet<AlexaDevices> AlexaDevices { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<AssessmentForPosition> AssessmentForPosition { get; set; }
        public virtual DbSet<AttachmentsinTimesheets> AttachmentsinTimesheets { get; set; }
        public virtual DbSet<CandidateInterviewResult> CandidateInterviewResult { get; set; }
        public virtual DbSet<ClientProjects> ClientProjects { get; set; }
        public virtual DbSet<ClientProjectsTasks> ClientProjectsTasks { get; set; }
        public virtual DbSet<ClientsBusiness> ClientsBusiness { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<ComponentType> ComponentType { get; set; }
        public virtual DbSet<ContentType> ContentType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Devices> Devices { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<EmployeeBankDetails> EmployeeBankDetails { get; set; }
        public virtual DbSet<EmployeeSalaryComponent> EmployeeSalaryComponent { get; set; }
        public virtual DbSet<EmployeeSalarySlips> EmployeeSalarySlips { get; set; }
        public virtual DbSet<EmployeeSalaryStructure> EmployeeSalaryStructure { get; set; }
        public virtual DbSet<EmployeeSalaryStructureDetails> EmployeeSalaryStructureDetails { get; set; }
        public virtual DbSet<ErrorLogs> ErrorLogs { get; set; }
        public virtual DbSet<FinancialYear> FinancialYear { get; set; }
        public virtual DbSet<GenericRoles> GenericRoles { get; set; }
        public virtual DbSet<GenericTasks> GenericTasks { get; set; }
        public virtual DbSet<HireType> HireType { get; set; }
        public virtual DbSet<HistoryAccount> HistoryAccount { get; set; }
        public virtual DbSet<HistoryLeaveComments> HistoryLeaveComments { get; set; }
        public virtual DbSet<HistoryLeaveScheme> HistoryLeaveScheme { get; set; }
        public virtual DbSet<HistoryLeaveType> HistoryLeaveType { get; set; }
        public virtual DbSet<HistoryProjects> HistoryProjects { get; set; }
        public virtual DbSet<HistoryRole> HistoryRole { get; set; }
        public virtual DbSet<HistoryUserProjects> HistoryUserProjects { get; set; }
        public virtual DbSet<HistoryUserType> HistoryUserType { get; set; }
        public virtual DbSet<HistoryUsers> HistoryUsers { get; set; }
        public virtual DbSet<HistoryWfhcomments> HistoryWfhcomments { get; set; }
        public virtual DbSet<HolidayCalendar> HolidayCalendar { get; set; }
        public virtual DbSet<InterviewCandidate> InterviewCandidate { get; set; }
        public virtual DbSet<InterviewPositionTechnologyStack> InterviewPositionTechnologyStack { get; set; }
        public virtual DbSet<Issuetypes> Issuetypes { get; set; }
        public virtual DbSet<LeaveScheme> LeaveScheme { get; set; }
        public virtual DbSet<LeaveStatus> LeaveStatus { get; set; }
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<MasterModule> MasterModule { get; set; }
        public virtual DbSet<MasterSubModule> MasterSubModule { get; set; }
        public virtual DbSet<MasterTimesheetMode> MasterTimesheetMode { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<MobileNotificationTemplate> MobileNotificationTemplate { get; set; }
        public virtual DbSet<ModuleAccessType> ModuleAccessType { get; set; }
        public virtual DbSet<NewsBoard> NewsBoard { get; set; }
        public virtual DbSet<NobleLeadDataAiu> NobleLeadDataAiu { get; set; }
        public virtual DbSet<NobleLeadDataCtu> NobleLeadDataCtu { get; set; }
        public virtual DbSet<PayMode> PayMode { get; set; }
        public virtual DbSet<Phases> Phases { get; set; }
        public virtual DbSet<Policies> Policies { get; set; }
        public virtual DbSet<ProjectPhases> ProjectPhases { get; set; }
        public virtual DbSet<ProjectSpecificTasks> ProjectSpecificTasks { get; set; }
        public virtual DbSet<ProjectWorkstatus> ProjectWorkstatus { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<QuestionBank> QuestionBank { get; set; }
        public virtual DbSet<RequestMessages> RequestMessages { get; set; }
        public virtual DbSet<RoleModules> RoleModules { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SalarySlipDetails> SalarySlipDetails { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SocialMedia> SocialMedia { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Step1> Step1 { get; set; }
        public virtual DbSet<SubPolicy> SubPolicy { get; set; }
        public virtual DbSet<SubPolicyDocument> SubPolicyDocument { get; set; }
        public virtual DbSet<TaskDetails> TaskDetails { get; set; }
        public virtual DbSet<TechnologyStack> TechnologyStack { get; set; }
        public virtual DbSet<TicketImages> TicketImages { get; set; }
        public virtual DbSet<TicketPriority> TicketPriority { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<TicketsAuthority> TicketsAuthority { get; set; }
        public virtual DbSet<Timesheet> Timesheet { get; set; }
        public virtual DbSet<TimesheetComments> TimesheetComments { get; set; }
        public virtual DbSet<UserDevicesToken> UserDevicesToken { get; set; }
        public virtual DbSet<UserGender> UserGender { get; set; }
        public virtual DbSet<UserLeaveTypeConsumed> UserLeaveTypeConsumed { get; set; }
        public virtual DbSet<UserLeaves> UserLeaves { get; set; }
        public virtual DbSet<UserProjectEngagement> UserProjectEngagement { get; set; }
        public virtual DbSet<UserProjects> UserProjects { get; set; }
        public virtual DbSet<UserSalaryCalculations> UserSalaryCalculations { get; set; }
        public virtual DbSet<UserSkills> UserSkills { get; set; }
        public virtual DbSet<UserSocialMediaProfiles> UserSocialMediaProfiles { get; set; }
        public virtual DbSet<UserTitle> UserTitle { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersForProjects> UsersForProjects { get; set; }
        public virtual DbSet<UsersProfile> UsersProfile { get; set; }
        public virtual DbSet<UserworkfromHome> UserworkfromHome { get; set; }
        public virtual DbSet<UssalaryComponents> UssalaryComponents { get; set; }
        public virtual DbSet<VisaType> VisaType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:evolutyzcornerwebdev.database.windows.net;Database=Ez-EvolutyzCornerWebDev;UID=dbadmin;PWD=March@2019;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccSpecOptionalHolidays>(entity =>
            {
                entity.HasKey(e => e.FinancialYearId)
                    .HasName("PK__Acc_Spec__6ECE4C913118C8A0");

                entity.ToTable("Acc_Spec_OptionalHolidays");

                entity.Property(e => e.FinancialYearId).ValueGeneratedNever();

                entity.Property(e => e.AccSpecOptionalHolidayId)
                    .HasColumnName("Acc_Spec_OptionalHolidayId")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccoutId).HasColumnName("AccoutID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccAccountId)
                    .HasName("PK_Company");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.AccAccountCode)
                    .IsRequired()
                    .HasColumnName("Acc_AccountCode")
                    .HasMaxLength(50);

                entity.Property(e => e.AccAccountDescription).HasColumnName("Acc_AccountDescription");

                entity.Property(e => e.AccAccountName)
                    .IsRequired()
                    .HasColumnName("Acc_AccountName")
                    .HasMaxLength(100);

                entity.Property(e => e.AccActiveStatus)
                    .IsRequired()
                    .HasColumnName("Acc_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AccCompanyLogo)
                    .HasColumnName("Acc_CompanyLogo")
                    .HasMaxLength(200);

                entity.Property(e => e.AccCreatedBy).HasColumnName("Acc_CreatedBy");

                entity.Property(e => e.AccCreatedDate)
                    .HasColumnName("Acc_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AccEmailId)
                    .HasColumnName("Acc_EmailID")
                    .HasMaxLength(100);

                entity.Property(e => e.AccIsDeleted).HasColumnName("Acc_isDeleted");

                entity.Property(e => e.AccMobileNumber)
                    .HasColumnName("Acc_MobileNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.AccModifiedBy).HasColumnName("Acc_ModifiedBy");

                entity.Property(e => e.AccModifiedDate)
                    .HasColumnName("Acc_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AccPhoneNumber)
                    .HasColumnName("Acc_PhoneNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.AccVersion).HasColumnName("Acc_Version");

                entity.Property(e => e.IsPreRequisite).HasColumnName("is_pre_requisite");

                entity.Property(e => e.IsUsAccount).HasColumnName("is_UsAccount");

                entity.HasOne(d => d.AccCreatedByNavigation)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AccCreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Acc_CreatedBy");
            });

            modelBuilder.Entity<AccountClients>(entity =>
            {
                entity.HasKey(e => e.AccClientId)
                    .HasName("PK__AccountC__20F03F6DC26D585C");

                entity.Property(e => e.AccClientId).HasColumnName("Acc_ClientID");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndustryId)
                    .HasColumnName("IndustryID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WebsiteUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountDepartments>(entity =>
            {
                entity.HasKey(e => e.AccountDepartmentId)
                    .HasName("PK__AccountD__7D5BB9ED47E49C53");

                entity.Property(e => e.AccountDepartmentId).HasColumnName("AccountDepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptActiveStatus).HasColumnName("Dept_ActiveStatus");

                entity.Property(e => e.DeptCreatedBy).HasColumnName("Dept_CreatedBy");

                entity.Property(e => e.DeptCreatedDate)
                    .HasColumnName("Dept_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeptDescription)
                    .HasColumnName("Dept_Description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeptIsDeleted).HasColumnName("Dept_isDeleted");

                entity.Property(e => e.DeptModifiedBy).HasColumnName("Dept_ModifiedBy");

                entity.Property(e => e.DeptModifiedDate)
                    .HasColumnName("Dept_ModifiedDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AccountSocialMediaProfiles>(entity =>
            {
                entity.HasKey(e => e.AccSocialMediaProfileId)
                    .HasName("PK__AccountS__6C99D9572888619E");

                entity.Property(e => e.AccSocialMediaProfileId).HasColumnName("Acc_SocialMediaProfileId");

                entity.Property(e => e.AsmpAccountId).HasColumnName("Asmp_AccountId");

                entity.Property(e => e.AsmpCreatedDate)
                    .HasColumnName("Asmp_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AsmpModifiedDate)
                    .HasColumnName("Asmp_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AsmpSocialMediaId).HasColumnName("Asmp_SocialMediaId");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccountSpecificTasks>(entity =>
            {
                entity.HasKey(e => e.AccSpecificTaskId)
                    .HasName("PK__AccountS__8E18E0FC9103E344");

                entity.Property(e => e.AccSpecificTaskId).HasColumnName("Acc_SpecificTaskId");

                entity.Property(e => e.AccSpecificTaskName)
                    .HasColumnName("Acc_SpecificTaskName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TskTaskId).HasColumnName("tsk_TaskID");
            });

            modelBuilder.Entity<AlexaDevices>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.UsrPEmployeeId)
                    .HasColumnName("UsrP_EmployeeID")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AssessmentForPosition>(entity =>
            {
                entity.HasKey(e => e.Apid)
                    .HasName("PK__Assessme__4C29F36F06DB4275");

                entity.ToTable("Assessment_For_Position");

                entity.Property(e => e.Apid).HasColumnName("APID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewForPositionname).HasMaxLength(300);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(300);
            });

            modelBuilder.Entity<AttachmentsinTimesheets>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK__Attachme__442C64BEAE69C5B7");

                entity.Property(e => e.TimeSheetId).HasColumnName("TimeSheetID");

                entity.Property(e => e.UploadedImages)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.TimeSheet)
                    .WithMany(p => p.AttachmentsinTimesheets)
                    .HasForeignKey(d => d.TimeSheetId)
                    .HasConstraintName("FK__Attachmen__TimeS__06ED0088");
            });

            modelBuilder.Entity<CandidateInterviewResult>(entity =>
            {
                entity.HasKey(e => e.Cirid)
                    .HasName("PK__Candidat__A365994851A9DF71");

                entity.Property(e => e.Cirid).HasColumnName("CIRID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Candidate)
                    .WithMany(p => p.CandidateInterviewResult)
                    .HasForeignKey(d => d.Candidateid)
                    .HasConstraintName("FK__Candidate__Candi__469D7149");
            });

            modelBuilder.Entity<ClientProjects>(entity =>
            {
                entity.HasKey(e => e.ClProjectId)
                    .HasName("PK__ClientPr__E0AE9254C5F91DFC");

                entity.Property(e => e.ClProjectId).HasColumnName("CL_ProjectID");

                entity.Property(e => e.ClientProjDesc).IsUnicode(false);

                entity.Property(e => e.ClientProjTitle)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjProjectId).HasColumnName("Proj_ProjectID");

                entity.HasOne(d => d.ProjProject)
                    .WithMany(p => p.ClientProjects)
                    .HasForeignKey(d => d.ProjProjectId)
                    .HasConstraintName("FK_ClientProjects_Projects");
            });

            modelBuilder.Entity<ClientProjectsTasks>(entity =>
            {
                entity.HasKey(e => e.ClProjectsTasksId)
                    .HasName("PK__ClientPr__ClientProjectsTasks");

                entity.Property(e => e.ClProjectsTasksId).HasColumnName("CL_ProjectsTasksID");

                entity.Property(e => e.AccSpecifictaskid).HasColumnName("acc_specifictaskid");

                entity.Property(e => e.RolRoleid).HasColumnName("rol_roleid");
            });

            modelBuilder.Entity<ClientsBusiness>(entity =>
            {
                entity.HasKey(e => e.BusinessId)
                    .HasName("PK__ClientsB__F1EAA36EEC470BE4");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.BusinessTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .HasName("PK__comments__CDDE919D6653514E");

                entity.ToTable("comments");

                entity.Property(e => e.CommentId).HasColumnName("commentId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Timstamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ComponentType>(entity =>
            {
                entity.Property(e => e.ComActiveStatus).HasColumnName("Com_ActiveStatus");

                entity.Property(e => e.ComCreatedBy).HasColumnName("Com_CreatedBy");

                entity.Property(e => e.ComCreatedDate)
                    .HasColumnName("Com_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComIsDeleted).HasColumnName("Com_isDeleted");

                entity.Property(e => e.ComModifiedBy).HasColumnName("Com_ModifiedBy");

                entity.Property(e => e.ComModifiedDate)
                    .HasColumnName("Com_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComponentType1)
                    .HasColumnName("ComponentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContentType>(entity =>
            {
                entity.Property(e => e.ConActiveStatus).HasColumnName("Con_ActiveStatus");

                entity.Property(e => e.ConCreatedBy).HasColumnName("Con_CreatedBy");

                entity.Property(e => e.ConCreatedDate)
                    .HasColumnName("Con_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ConIsDeleted).HasColumnName("Con_isDeleted");

                entity.Property(e => e.ConModifiedBy).HasColumnName("Con_ModifiedBy");

                entity.Property(e => e.ConModifiedDate)
                    .HasColumnName("Con_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContentTitle).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Departme__C0312218E015C032");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Devices>(entity =>
            {
                entity.Property(e => e.DeviceId).IsUnicode(false);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DocActiveStatus).HasColumnName("Doc_ActiveStatus");

                entity.Property(e => e.DocCreatedBy).HasColumnName("Doc_CreatedBy");

                entity.Property(e => e.DocCreatedDate)
                    .HasColumnName("Doc_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocIsDeleted).HasColumnName("Doc_isDeleted");

                entity.Property(e => e.DocModifiedBy).HasColumnName("Doc_ModifiedBy");

                entity.Property(e => e.DocModifiedDate)
                    .HasColumnName("Doc_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentTitle).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeBankDetails>(entity =>
            {
                entity.HasKey(e => e.EmpBankId)
                    .HasName("PK__Employee__6A76EDD193A76714");

                entity.Property(e => e.EmpBankId).HasColumnName("EmpBankID");

                entity.Property(e => e.BankNo).HasColumnName("BANK_No");

                entity.Property(e => e.EmpBUserId).HasColumnName("EmpB_UserID");

                entity.Property(e => e.EsiNo)
                    .HasColumnName("ESI_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasColumnName("PAN_No")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayModeId).HasColumnName("PayModeID");

                entity.Property(e => e.PfNo)
                    .HasColumnName("PF_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UanNo).HasColumnName("UAN_No");
            });

            modelBuilder.Entity<EmployeeSalaryComponent>(entity =>
            {
                entity.HasKey(e => e.EmpSalCompId)
                    .HasName("PK__Employee__D754E4733063685A");

                entity.Property(e => e.ComponentDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpScAccountId).HasColumnName("EmpSC_AccountID");

                entity.Property(e => e.EmpScActiveStatus).HasColumnName("EmpSC_ActiveStatus");

                entity.Property(e => e.EmpScCreatedBy).HasColumnName("EmpSC_CreatedBy");

                entity.Property(e => e.EmpScCreatedDate)
                    .HasColumnName("EmpSC_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpScIsDeleted).HasColumnName("EmpSC_isDeleted");

                entity.Property(e => e.EmpScModifiedBy).HasColumnName("EmpSC_ModifiedBy");

                entity.Property(e => e.EmpScModifiedDate)
                    .HasColumnName("EmpSC_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpScVersion).HasColumnName("EmpSC_Version");
            });

            modelBuilder.Entity<EmployeeSalarySlips>(entity =>
            {
                entity.HasKey(e => e.EmpSalarySlipId)
                    .HasName("PK__Employee__E1895488E987072A");

                entity.Property(e => e.EmpSalarySlipId).HasColumnName("EmpSalarySlipID");

                entity.Property(e => e.EpmssUserId).HasColumnName("Epmss_UserID");

                entity.Property(e => e.Year).HasColumnName("YEAR");
            });

            modelBuilder.Entity<EmployeeSalaryStructure>(entity =>
            {
                entity.HasKey(e => e.EmpsStructureId)
                    .HasName("PK__Employee__6DF8601300D16DE3");

                entity.Property(e => e.EmpsStructureId).HasColumnName("Emps_StructureID");

                entity.Property(e => e.Ctc)
                    .HasColumnName("CTC")
                    .HasColumnType("money");

                entity.Property(e => e.EmpsUserId).HasColumnName("Emps_UserID");

                entity.Property(e => e.EssActiveStatus).HasColumnName("Ess_ActiveStatus");

                entity.Property(e => e.EssCreatedBy).HasColumnName("Ess_CreatedBy");

                entity.Property(e => e.EssCreatedDate)
                    .HasColumnName("Ess_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssIsDeleted).HasColumnName("Ess_isDeleted");

                entity.Property(e => e.EssModifiedBy).HasColumnName("Ess_ModifiedBy");

                entity.Property(e => e.EssModifiedDate)
                    .HasColumnName("Ess_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssVersion).HasColumnName("Ess_Version");

                entity.Property(e => e.SalaryMonth).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeSalaryStructureDetails>(entity =>
            {
                entity.HasKey(e => e.EmpssdetailId)
                    .HasName("PK__Employee__34451075A3A937AD");

                entity.Property(e => e.EmpsStructureId).HasColumnName("Emps_StructureId");

                entity.Property(e => e.EssDActiveStatus).HasColumnName("EssD_ActiveStatus");

                entity.Property(e => e.EssDCreatedBy).HasColumnName("EssD_CreatedBy");

                entity.Property(e => e.EssDCreatedDate)
                    .HasColumnName("EssD_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssDIsDeleted).HasColumnName("EssD_isDeleted");

                entity.Property(e => e.EssDModifiedBy).HasColumnName("EssD_ModifiedBy");

                entity.Property(e => e.EssDModifiedDate)
                    .HasColumnName("EssD_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EssDVersion).HasColumnName("EssD_Version");
            });

            modelBuilder.Entity<ErrorLogs>(entity =>
            {
                entity.HasKey(e => e.ErrorlogId)
                    .HasName("PK__ErrorLog__4F9BF6F2AB599A44");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialYear>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GenericRoles>(entity =>
            {
                entity.HasKey(e => e.GenericRoleId)
                    .HasName("PK__GenericR__3E5CEFF6288AEB01");

                entity.Property(e => e.GenericRoleId).HasColumnName("GenericRoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GenericTasks>(entity =>
            {
                entity.HasKey(e => e.TskTaskId)
                    .HasName("PK_TaskLookup");

                entity.Property(e => e.TskTaskId).HasColumnName("tsk_TaskID");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.TskActiveStatus).HasColumnName("tsk_ActiveStatus");

                entity.Property(e => e.TskCreatedBy).HasColumnName("tsk_CreatedBy");

                entity.Property(e => e.TskCreatedDate)
                    .HasColumnName("tsk_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TskIsDeleted)
                    .IsRequired()
                    .HasColumnName("tsk_isDeleted")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TskModifiedBy).HasColumnName("tsk_ModifiedBy");

                entity.Property(e => e.TskModifiedDate)
                    .HasColumnName("tsk_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TskTaskDescription)
                    .HasColumnName("tsk_TaskDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TskTaskName)
                    .IsRequired()
                    .HasColumnName("tsk_TaskName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TskVersion).HasColumnName("tsk_Version");
            });

            modelBuilder.Entity<HireType>(entity =>
            {
                entity.Property(e => e.HireTypeId).HasColumnName("HireTypeID");

                entity.Property(e => e.HireType1)
                    .HasColumnName("HireType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireTypeShortForm)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<HistoryAccount>(entity =>
            {
                entity.HasKey(e => e.HistoryAccountAccountId);

                entity.ToTable("History_Account");

                entity.Property(e => e.HistoryAccountAccountId).HasColumnName("History_Account_AccountID");

                entity.Property(e => e.HistoryAccAccountCode)
                    .IsRequired()
                    .HasColumnName("History_Acc_AccountCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryAccAccountDescription)
                    .HasColumnName("History_Acc_AccountDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryAccAccountId).HasColumnName("History_Acc_AccountID");

                entity.Property(e => e.HistoryAccAccountName)
                    .IsRequired()
                    .HasColumnName("History_Acc_AccountName")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryAccActiveStatus).HasColumnName("History_Acc_ActiveStatus");

                entity.Property(e => e.HistoryAccCompanyLogo)
                    .HasColumnName("History_Acc_CompanyLogo")
                    .HasMaxLength(200);

                entity.Property(e => e.HistoryAccCreatedBy).HasColumnName("History_Acc_CreatedBy");

                entity.Property(e => e.HistoryAccCreatedDate)
                    .HasColumnName("History_Acc_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryAccEmailId)
                    .HasColumnName("History_Acc_EmailID")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryAccIsDeleted).HasColumnName("History_Acc_isDeleted");

                entity.Property(e => e.HistoryAccMobileNumber)
                    .HasColumnName("History_Acc_MobileNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryAccModifiedBy).HasColumnName("History_Acc_ModifiedBy");

                entity.Property(e => e.HistoryAccModifiedDate)
                    .HasColumnName("History_Acc_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryAccPhoneNumber)
                    .HasColumnName("History_Acc_PhoneNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryAccVersion).HasColumnName("History_Acc_Version");
            });

            modelBuilder.Entity<HistoryLeaveComments>(entity =>
            {
                entity.HasKey(e => e.HistoryCommentId)
                    .HasName("PK__History___9785CB96D89435E7");

                entity.ToTable("History_LeaveComments");

                entity.Property(e => e.HistoryCommentId).HasColumnName("History_CommentId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("date");

                entity.Property(e => e.Managerid).HasColumnName("managerid");

                entity.Property(e => e.UsrlLeaveId).HasColumnName("Usrl_LeaveId");
            });

            modelBuilder.Entity<HistoryLeaveScheme>(entity =>
            {
                entity.ToTable("History_LeaveScheme");

                entity.Property(e => e.HistoryLeaveSchemeId).HasColumnName("History_LeaveScheme_ID");

                entity.Property(e => e.HistoryLschmAccountId).HasColumnName("History_LSchm_AccountID");

                entity.Property(e => e.HistoryLschmActiveStatus).HasColumnName("History_LSchm_ActiveStatus");

                entity.Property(e => e.HistoryLschmCreatedBy).HasColumnName("History_LSchm_CreatedBy");

                entity.Property(e => e.HistoryLschmCreatedDate)
                    .HasColumnName("History_LSchm_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryLschmIsDeleted).HasColumnName("History_LSchm_isDeleted");

                entity.Property(e => e.HistoryLschmLeaveCount).HasColumnName("History_LSchm_LeaveCount");

                entity.Property(e => e.HistoryLschmLeaveFrequency)
                    .IsRequired()
                    .HasColumnName("History_LSchm_LeaveFrequency")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryLschmLeaveScheme)
                    .IsRequired()
                    .HasColumnName("History_LSchm_LeaveScheme")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryLschmLeaveSchemeCode)
                    .IsRequired()
                    .HasColumnName("History_LSchm_LeaveSchemeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryLschmLeaveSchemeDescription)
                    .HasColumnName("History_LSchm_LeaveSchemeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryLschmLeaveSchemeId).HasColumnName("History_LSchm_LeaveSchemeID");

                entity.Property(e => e.HistoryLschmLeaveTypeId).HasColumnName("History_LSchm_LeaveTypeID");

                entity.Property(e => e.HistoryLschmModifiedBy).HasColumnName("History_LSchm_ModifiedBy");

                entity.Property(e => e.HistoryLschmModifiedDate)
                    .HasColumnName("History_LSchm_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryLschmUserTypeId).HasColumnName("History_LSchm_UserTypeID");

                entity.Property(e => e.HistoryLschmVersion).HasColumnName("History_LSchm_Version");
            });

            modelBuilder.Entity<HistoryLeaveType>(entity =>
            {
                entity.ToTable("History_LeaveType");

                entity.Property(e => e.HistoryLeaveTypeId).HasColumnName("History_LeaveType_ID");

                entity.Property(e => e.HistoryLtypAccountId).HasColumnName("History_LTyp_AccountID");

                entity.Property(e => e.HistoryLtypActiveStatus).HasColumnName("History_LTyp_ActiveStatus");

                entity.Property(e => e.HistoryLtypCreatedBy).HasColumnName("History_LTyp_CreatedBy");

                entity.Property(e => e.HistoryLtypCreatedDate)
                    .HasColumnName("History_LTyp_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryLtypIsDeleted).HasColumnName("History_LTyp_isDeleted");

                entity.Property(e => e.HistoryLtypLeaveType)
                    .IsRequired()
                    .HasColumnName("History_LTyp_LeaveType")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryLtypLeaveTypeDescription)
                    .HasColumnName("History_LTyp_LeaveTypeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryLtypLeaveTypeId).HasColumnName("History_LTyp_LeaveTypeID");

                entity.Property(e => e.HistoryLtypModifiedBy).HasColumnName("History_LTyp_ModifiedBy");

                entity.Property(e => e.HistoryLtypModifiedDate)
                    .HasColumnName("History_LTyp_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryLtypVersion).HasColumnName("History_LTyp_Version");
            });

            modelBuilder.Entity<HistoryProjects>(entity =>
            {
                entity.HasKey(e => e.HistoryProjectId);

                entity.ToTable("History_Projects");

                entity.Property(e => e.HistoryProjectId).HasColumnName("History_Project_ID");

                entity.Property(e => e.HistoryProjAccountId).HasColumnName("History_Proj_AccountID");

                entity.Property(e => e.HistoryProjActiveStatus).HasColumnName("History_Proj_ActiveStatus");

                entity.Property(e => e.HistoryProjCreatedBy).HasColumnName("History_Proj_CreatedBy");

                entity.Property(e => e.HistoryProjCreatedDate)
                    .HasColumnName("History_Proj_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryProjEndDate)
                    .HasColumnName("History_Proj_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryProjIsDeleted).HasColumnName("History_Proj_isDeleted");

                entity.Property(e => e.HistoryProjModifiedBy).HasColumnName("History_Proj_ModifiedBy");

                entity.Property(e => e.HistoryProjModifiedDate)
                    .HasColumnName("History_Proj_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryProjProjectCode)
                    .IsRequired()
                    .HasColumnName("History_Proj_ProjectCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryProjProjectDescription)
                    .HasColumnName("History_Proj_ProjectDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryProjProjectId).HasColumnName("History_Proj_ProjectID");

                entity.Property(e => e.HistoryProjProjectName)
                    .IsRequired()
                    .HasColumnName("History_Proj_ProjectName")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryProjStartDate)
                    .HasColumnName("History_Proj_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryProjVersion).HasColumnName("History_Proj_Version");
            });

            modelBuilder.Entity<HistoryRole>(entity =>
            {
                entity.ToTable("History_Role");

                entity.Property(e => e.HistoryRoleId).HasColumnName("History_Role_ID");

                entity.Property(e => e.HistoryRolAccountId).HasColumnName("History_Rol_AccountID");

                entity.Property(e => e.HistoryRolActiveStatus).HasColumnName("History_Rol_ActiveStatus");

                entity.Property(e => e.HistoryRolCreatedBy).HasColumnName("History_Rol_createdBy");

                entity.Property(e => e.HistoryRolCreatedDate)
                    .HasColumnName("History_Rol_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryRolIsDeleted).HasColumnName("History_Rol_isDeleted");

                entity.Property(e => e.HistoryRolModifiedBy).HasColumnName("History_Rol_ModifiedBy");

                entity.Property(e => e.HistoryRolModifiedDate)
                    .HasColumnName("History_Rol_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryRolRoleCode)
                    .IsRequired()
                    .HasColumnName("History_Rol_RoleCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryRolRoleDescription)
                    .HasColumnName("History_Rol_RoleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryRolRoleId).HasColumnName("History_Rol_RoleID");

                entity.Property(e => e.HistoryRolRoleName)
                    .IsRequired()
                    .HasColumnName("History_Rol_RoleName")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryRolVersion).HasColumnName("History_Rol_Version");
            });

            modelBuilder.Entity<HistoryUserProjects>(entity =>
            {
                entity.HasKey(e => e.HuprojUserProjectId);

                entity.ToTable("History_UserProjects");

                entity.Property(e => e.HuprojUserProjectId).HasColumnName("HUProj_UserProjectID");

                entity.Property(e => e.HuprojActiveStatus).HasColumnName("HUProj_ActiveStatus");

                entity.Property(e => e.HuprojCreatedBy).HasColumnName("HUProj_CreatedBy");

                entity.Property(e => e.HuprojCreatedDate)
                    .HasColumnName("HUProj_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HuprojEndDate)
                    .HasColumnName("HUProj_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HuprojIsDeleted).HasColumnName("HUProj_isDeleted");

                entity.Property(e => e.HuprojModifiedBy).HasColumnName("HUProj_ModifiedBy");

                entity.Property(e => e.HuprojModifiedDate)
                    .HasColumnName("HUProj_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HuprojParticipationPercentage).HasColumnName("HUProj_ParticipationPercentage");

                entity.Property(e => e.HuprojProjectId).HasColumnName("HUProj_ProjectID");

                entity.Property(e => e.HuprojStartDate)
                    .HasColumnName("HUProj_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HuprojUserId).HasColumnName("HUProj_UserID");

                entity.Property(e => e.HuprojVersion).HasColumnName("HUProj_Version");
            });

            modelBuilder.Entity<HistoryUserType>(entity =>
            {
                entity.ToTable("History_UserType");

                entity.Property(e => e.HistoryUserTypeId).HasColumnName("History_UserType_ID");

                entity.Property(e => e.HistoryAccountId).HasColumnName("History_AccountID");

                entity.Property(e => e.HistoryUsTActiveStatus).HasColumnName("History_UsT_ActiveStatus");

                entity.Property(e => e.HistoryUsTCreatedBy).HasColumnName("History_UsT_CreatedBy");

                entity.Property(e => e.HistoryUsTCreatedDate)
                    .HasColumnName("History_UsT_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryUsTIsDeleted).HasColumnName("History_UsT_isDeleted");

                entity.Property(e => e.HistoryUsTModifiedBy).HasColumnName("History_UsT_ModifiedBy");

                entity.Property(e => e.HistoryUsTModifiedDate)
                    .HasColumnName("History_UsT_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryUsTUserType)
                    .IsRequired()
                    .HasColumnName("History_UsT_UserType")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryUsTUserTypeCode)
                    .IsRequired()
                    .HasColumnName("History_UsT_UserTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryUsTUserTypeDescription)
                    .HasColumnName("History_UsT_UserTypeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.HistoryUsTUserTypeId).HasColumnName("History_UsT_UserTypeID");

                entity.Property(e => e.HistoryUsTVersion).HasColumnName("History_UsT_Version");
            });

            modelBuilder.Entity<HistoryUsers>(entity =>
            {
                entity.HasKey(e => e.HistoryUserId);

                entity.ToTable("History_Users");

                entity.Property(e => e.HistoryUserId).HasColumnName("History_User_ID");

                entity.Property(e => e.HistoryUsrAccountId).HasColumnName("History_Usr_AccountID");

                entity.Property(e => e.HistoryUsrActiveStatus).HasColumnName("History_Usr_ActiveStatus");

                entity.Property(e => e.HistoryUsrCreatedBy).HasColumnName("History_Usr_CreatedBy");

                entity.Property(e => e.HistoryUsrCreatedDate)
                    .HasColumnName("History_Usr_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryUsrIsDeleted).HasColumnName("History_Usr_isDeleted");

                entity.Property(e => e.HistoryUsrLoginId)
                    .IsRequired()
                    .HasColumnName("History_Usr_LoginId")
                    .HasMaxLength(100);

                entity.Property(e => e.HistoryUsrManager).HasColumnName("History_Usr_Manager");

                entity.Property(e => e.HistoryUsrManager2).HasColumnName("History_Usr_Manager2");

                entity.Property(e => e.HistoryUsrModifiedBy).HasColumnName("History_Usr_ModifiedBy");

                entity.Property(e => e.HistoryUsrModifiedDate)
                    .HasColumnName("History_Usr_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.HistoryUsrPassword)
                    .IsRequired()
                    .HasColumnName("History_Usr_Password")
                    .HasMaxLength(200);

                entity.Property(e => e.HistoryUsrRoleId).HasColumnName("History_Usr_RoleID");

                entity.Property(e => e.HistoryUsrTaskId).HasColumnName("History_Usr_TaskID");

                entity.Property(e => e.HistoryUsrUserId).HasColumnName("History_Usr_UserID");

                entity.Property(e => e.HistoryUsrUserTypeId).HasColumnName("History_Usr_UserTypeID");

                entity.Property(e => e.HistoryUsrUsername)
                    .HasColumnName("History_Usr_Username")
                    .HasMaxLength(50);

                entity.Property(e => e.HistoryUsrVersion).HasColumnName("History_Usr_Version");
            });

            modelBuilder.Entity<HistoryWfhcomments>(entity =>
            {
                entity.HasKey(e => e.HistoryWfhcommentId)
                    .HasName("PK__History___1F68D78137A875CF");

                entity.ToTable("History_WFHComments");

                entity.Property(e => e.HistoryWfhcommentId).HasColumnName("History_WFHCommentId");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("date");

                entity.Property(e => e.Managerid).HasColumnName("managerid");

                entity.Property(e => e.UserwfhId).HasColumnName("UserwfhID");
            });

            modelBuilder.Entity<HolidayCalendar>(entity =>
            {
                entity.Property(e => e.HolidayCalendarId).HasColumnName("HolidayCalendarID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.HolidayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsOptionalHoliday).HasColumnName("isOptionalHoliday");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.HolidayCalendar)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HolidayCa__Accou__7D439ABD");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.HolidayCalendarCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__HolidayCa__Creat__7E37BEF6");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.HolidayCalendarModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__HolidayCa__Modif__7F2BE32F");
            });

            modelBuilder.Entity<InterviewCandidate>(entity =>
            {
                entity.HasKey(e => e.Icid)
                    .HasName("PK__Intervie__B83FFBFD931BE40A");

                entity.Property(e => e.Icid).HasColumnName("ICID");

                entity.Property(e => e.AssessmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssessmentForPositionid).HasColumnName("Assessment_For_Positionid");

                entity.Property(e => e.AssessmentTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Emailid).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.AssessmentForPosition)
                    .WithMany(p => p.InterviewCandidate)
                    .HasForeignKey(d => d.AssessmentForPositionid)
                    .HasConstraintName("FK__Interview__Asses__40E497F3");
            });

            modelBuilder.Entity<InterviewPositionTechnologyStack>(entity =>
            {
                entity.HasKey(e => e.Ipid)
                    .HasName("PK__Intervie__8FB9622A822696FD");

                entity.ToTable("Interview_Position_TechnologyStack");

                entity.Property(e => e.Ipid).HasColumnName("IPID");

                entity.Property(e => e.AssessmentForPositionPositionid).HasColumnName("Assessment_For_Position_Positionid");

                entity.Property(e => e.AssessmentTimePeriodInSec).HasColumnName("Assessment_TimePeriod_in_sec");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfQuestions).HasColumnName("No_of_Questions");

                entity.Property(e => e.TechnologyStackId).HasColumnName("TechnologyStack_Id");

                entity.HasOne(d => d.AssessmentForPositionPosition)
                    .WithMany(p => p.InterviewPositionTechnologyStack)
                    .HasForeignKey(d => d.AssessmentForPositionPositionid)
                    .HasConstraintName("FK__Interview__Asses__3A379A64");

                entity.HasOne(d => d.TechnologyStack)
                    .WithMany(p => p.InterviewPositionTechnologyStack)
                    .HasForeignKey(d => d.TechnologyStackId)
                    .HasConstraintName("FK__Interview__Techn__3B2BBE9D");
            });

            modelBuilder.Entity<Issuetypes>(entity =>
            {
                entity.HasKey(e => e.Itid)
                    .HasName("PK__Issuetyp__44B161D3328D0945");

                entity.Property(e => e.Itid).HasColumnName("ITID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Issuetypes)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Issuetype__Depar__253C7D7E");
            });

            modelBuilder.Entity<LeaveScheme>(entity =>
            {
                entity.HasKey(e => e.LschmLeaveSchemeId);

                entity.Property(e => e.LschmLeaveSchemeId).HasColumnName("LSchm_LeaveSchemeID");

                entity.Property(e => e.LschmAccountId).HasColumnName("LSchm_AccountID");

                entity.Property(e => e.LschmActiveStatus).HasColumnName("LSchm_ActiveStatus");

                entity.Property(e => e.LschmCreatedBy).HasColumnName("LSchm_CreatedBy");

                entity.Property(e => e.LschmCreatedDate)
                    .HasColumnName("LSchm_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LschmIsDeleted).HasColumnName("LSchm_isDeleted");

                entity.Property(e => e.LschmLeaveCount).HasColumnName("LSchm_LeaveCount");

                entity.Property(e => e.LschmLeaveFrequency)
                    .HasColumnName("LSchm_LeaveFrequency")
                    .HasMaxLength(50);

                entity.Property(e => e.LschmLeaveScheme)
                    .HasColumnName("LSchm_LeaveScheme")
                    .HasMaxLength(100);

                entity.Property(e => e.LschmLeaveSchemeCode)
                    .HasColumnName("LSchm_LeaveSchemeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.LschmLeaveSchemeDescription)
                    .HasColumnName("LSchm_LeaveSchemeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.LschmLeaveTypeId).HasColumnName("LSchm_LeaveTypeID");

                entity.Property(e => e.LschmModifiedBy).HasColumnName("LSchm_ModifiedBy");

                entity.Property(e => e.LschmModifiedDate)
                    .HasColumnName("LSchm_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LschmUserTypeId).HasColumnName("LSchm_UserTypeID");

                entity.Property(e => e.LschmVersion).HasColumnName("LSchm_Version");
            });

            modelBuilder.Entity<LeaveStatus>(entity =>
            {
                entity.HasKey(e => e.LStatusId)
                    .HasName("PK__LeaveSta__C478A10C5EF76E46");

                entity.Property(e => e.LStatusId).HasColumnName("L_StatusId");

                entity.Property(e => e.LStatus)
                    .HasColumnName("L_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasKey(e => e.LtypLeaveTypeId);

                entity.Property(e => e.LtypLeaveTypeId).HasColumnName("LTyp_LeaveTypeID");

                entity.Property(e => e.LtypAccountId).HasColumnName("LTyp_AccountID");

                entity.Property(e => e.LtypActiveStatus)
                    .IsRequired()
                    .HasColumnName("LTyp_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LtypCreatedBy).HasColumnName("LTyp_CreatedBy");

                entity.Property(e => e.LtypCreatedDate)
                    .HasColumnName("LTyp_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LtypIsDeleted).HasColumnName("LTyp_isDeleted");

                entity.Property(e => e.LtypLeaveType)
                    .IsRequired()
                    .HasColumnName("LTyp_LeaveType")
                    .HasMaxLength(100);

                entity.Property(e => e.LtypLeaveTypeDescription)
                    .HasColumnName("LTyp_LeaveTypeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.LtypModifiedBy).HasColumnName("LTyp_ModifiedBy");

                entity.Property(e => e.LtypModifiedDate)
                    .HasColumnName("LTyp_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LtypVersion).HasColumnName("LTyp_Version");
            });

            modelBuilder.Entity<MasterModule>(entity =>
            {
                entity.HasKey(e => e.ModModuleId);

                entity.ToTable("Master_Module");

                entity.Property(e => e.ModModuleId).HasColumnName("Mod_ModuleID");

                entity.Property(e => e.ModActiveStatus)
                    .IsRequired()
                    .HasColumnName("Mod_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModCreatedBy).HasColumnName("Mod_CreatedBy");

                entity.Property(e => e.ModCreatedDate)
                    .HasColumnName("Mod_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModDescription)
                    .HasColumnName("Mod_Description")
                    .HasMaxLength(500);

                entity.Property(e => e.ModIsDeleted).HasColumnName("Mod_isDeleted");

                entity.Property(e => e.ModModifiedBy).HasColumnName("Mod_ModifiedBy");

                entity.Property(e => e.ModModifiedDate)
                    .HasColumnName("Mod_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModModuleCode)
                    .IsRequired()
                    .HasColumnName("Mod_ModuleCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ModModuleName)
                    .IsRequired()
                    .HasColumnName("Mod_ModuleName")
                    .HasMaxLength(100);

                entity.Property(e => e.ModVersion).HasColumnName("Mod_Version");
            });

            modelBuilder.Entity<MasterSubModule>(entity =>
            {
                entity.HasKey(e => e.SubModuleId)
                    .HasName("PK_Sub_Module");

                entity.ToTable("Master_Sub_Module");

                entity.Property(e => e.SubModuleId).HasColumnName("Sub_ModuleID");

                entity.Property(e => e.ModModuleId).HasColumnName("Mod_ModuleID");

                entity.Property(e => e.SubActiveStatus)
                    .IsRequired()
                    .HasColumnName("Sub_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubCreatedBy).HasColumnName("Sub_CreatedBy");

                entity.Property(e => e.SubCreatedDate)
                    .HasColumnName("Sub_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubDescription)
                    .HasColumnName("Sub_Description")
                    .HasMaxLength(500);

                entity.Property(e => e.SubIsDeleted).HasColumnName("Sub_isDeleted");

                entity.Property(e => e.SubModifiedBy).HasColumnName("Sub_ModifiedBy");

                entity.Property(e => e.SubModifiedDate)
                    .HasColumnName("Sub_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubModuleCode)
                    .IsRequired()
                    .HasColumnName("Sub_ModuleCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SubModuleName)
                    .IsRequired()
                    .HasColumnName("Sub_ModuleName")
                    .HasMaxLength(100);

                entity.Property(e => e.SubVersion).HasColumnName("Sub_Version");
            });

            modelBuilder.Entity<MasterTimesheetMode>(entity =>
            {
                entity.HasKey(e => e.TimesheetModeId)
                    .HasName("PK__Master_T__D226F810CFC74009");

                entity.ToTable("Master_TimesheetMode");

                entity.Property(e => e.TimesheetModeId)
                    .HasColumnName("TimesheetMode_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TimeModeName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MobileNotificationTemplate>(entity =>
            {
                entity.HasKey(e => e.MobileNotificationId)
                    .HasName("PK__MobileNo__DC73F57D4A71239E");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuleAccessType>(entity =>
            {
                entity.Property(e => e.ModuleAccessTypeId).HasColumnName("ModuleAccessTypeID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleAccessType1)
                    .HasColumnName("ModuleAccessType")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsBoard>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsStatus).HasColumnName("News_Status");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NobleLeadDataAiu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NobleLeadData_AIU");

                entity.Property(e => e.Amleadsrcid).HasColumnName("amleadsrcid");

                entity.Property(e => e.School).HasMaxLength(255);
            });

            modelBuilder.Entity<NobleLeadDataCtu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NobleLeadData_CTU");

                entity.Property(e => e.Amleadsrcid).HasColumnName("amleadsrcid");

                entity.Property(e => e.School).HasMaxLength(255);
            });

            modelBuilder.Entity<PayMode>(entity =>
            {
                entity.Property(e => e.PayModeId).HasColumnName("PayModeID");

                entity.Property(e => e.PayMode1)
                    .HasColumnName("PayMode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayModeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phases>(entity =>
            {
                entity.HasKey(e => e.PhaseId)
                    .HasName("PK__Phases__5BA26D62481213A5");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhaseTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Policies>(entity =>
            {
                entity.HasKey(e => e.PolicyId)
                    .HasName("PK__Policies__2E1339A4C7379F6A");

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCss).HasColumnName("Is_Css");

                entity.Property(e => e.PolActiveStatus).HasColumnName("Pol_ActiveStatus");

                entity.Property(e => e.PolCreatedBy).HasColumnName("Pol_CreatedBy");

                entity.Property(e => e.PolCreatedDate)
                    .HasColumnName("Pol_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolIsDeleted).HasColumnName("Pol_isDeleted");

                entity.Property(e => e.PolModifiedBy).HasColumnName("Pol_ModifiedBy");

                entity.Property(e => e.PolModifiedDate)
                    .HasColumnName("Pol_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PolicyDescription).IsUnicode(false);

                entity.Property(e => e.PolicyTitle).IsUnicode(false);
            });

            modelBuilder.Entity<ProjectPhases>(entity =>
            {
                entity.HasKey(e => e.ProjPhaseId)
                    .HasName("PK__ProjectP__61A6D420235416AD");

                entity.Property(e => e.ProjPhaseId).HasColumnName("Proj_PhaseId");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnName("Actual_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("Actual_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnName("Plan_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("Plan_StartDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectSpecificTasks>(entity =>
            {
                entity.HasKey(e => e.ProjSpecificTaskId)
                    .HasName("PK__ProjectS__D80A6D75D51FFB93");

                entity.Property(e => e.ProjSpecificTaskId).HasColumnName("Proj_SpecificTaskId");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnName("Actual_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("Actual_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnName("Plan_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("Plan_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjSpecificTaskName)
                    .HasColumnName("Proj_SpecificTaskName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rtmid)
                    .HasColumnName("RTMId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TskTaskId).HasColumnName("tsk_TaskID");
            });

            modelBuilder.Entity<ProjectWorkstatus>(entity =>
            {
                entity.ToTable("Project_workstatus");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromDt)
                    .HasColumnName("FromDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.PercentageCompleted)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToDt)
                    .HasColumnName("ToDT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjProjectId);

                entity.Property(e => e.ProjProjectId).HasColumnName("Proj_ProjectID");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnName("Actual_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("Actual_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.IsTimesheetProjectSpecific).HasColumnName("Is_Timesheet_ProjectSpecific");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnName("Plan_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnName("Plan_StartDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjAccountId).HasColumnName("Proj_AccountID");

                entity.Property(e => e.ProjActiveStatus)
                    .IsRequired()
                    .HasColumnName("Proj_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProjClientName)
                    .HasColumnName("Proj_ClientName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProjCreatedBy).HasColumnName("Proj_CreatedBy");

                entity.Property(e => e.ProjCreatedDate)
                    .HasColumnName("Proj_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProjIsDeleted).HasColumnName("Proj_isDeleted");

                entity.Property(e => e.ProjModifiedBy).HasColumnName("Proj_ModifiedBy");

                entity.Property(e => e.ProjModifiedDate)
                    .HasColumnName("Proj_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjProjectCode)
                    .IsRequired()
                    .HasColumnName("Proj_ProjectCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ProjProjectDescription)
                    .HasColumnName("Proj_ProjectDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ProjProjectName)
                    .IsRequired()
                    .HasColumnName("Proj_ProjectName")
                    .HasMaxLength(100);

                entity.Property(e => e.ProjVersion).HasColumnName("Proj_Version");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.WebUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestionBank>(entity =>
            {
                entity.HasKey(e => e.Qbid)
                    .HasName("PK__Question__DFE79DB903BD6685");

                entity.Property(e => e.Qbid).HasColumnName("QBID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.TechnologyStack)
                    .WithMany(p => p.QuestionBank)
                    .HasForeignKey(d => d.TechnologyStackId)
                    .HasConstraintName("FK__QuestionB__Techn__3572E547");
            });

            modelBuilder.Entity<RequestMessages>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<RoleModules>(entity =>
            {
                entity.HasKey(e => e.RmodRoleModuleId)
                    .HasName("PK_RoleModule");

                entity.Property(e => e.RmodRoleModuleId)
                    .HasColumnName("RMod_RoleModuleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModuleAccessTypeId).HasColumnName("ModuleAccessTypeID");

                entity.Property(e => e.RmodAccountId).HasColumnName("RMod_AccountID");

                entity.Property(e => e.RmodActiveStatus)
                    .IsRequired()
                    .HasColumnName("RMod_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RmodCreatedBy).HasColumnName("RMod_CreatedBy");

                entity.Property(e => e.RmodCreatedDate)
                    .HasColumnName("RMod_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RmodIsDeleted).HasColumnName("RMod_isDeleted");

                entity.Property(e => e.RmodModifiedBy).HasColumnName("RMod_ModifiedBy");

                entity.Property(e => e.RmodModifiedDate)
                    .HasColumnName("RMod_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RmodRoleId).HasColumnName("RMod_RoleID");

                entity.Property(e => e.RmodVersion)
                    .HasColumnName("RMod_Version")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubModuleId).HasColumnName("Sub_ModuleID");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RolRoleId)
                    .HasName("PK_Master_Role");

                entity.Property(e => e.RolRoleId).HasColumnName("Rol_RoleID");

                entity.Property(e => e.RolAccountId).HasColumnName("Rol_AccountID");

                entity.Property(e => e.RolActiveStatus)
                    .IsRequired()
                    .HasColumnName("Rol_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RolCreatedBy).HasColumnName("Rol_createdBy");

                entity.Property(e => e.RolCreatedDate)
                    .HasColumnName("Rol_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RolIsDeleted).HasColumnName("Rol_isDeleted");

                entity.Property(e => e.RolModifiedBy).HasColumnName("Rol_ModifiedBy");

                entity.Property(e => e.RolModifiedDate)
                    .HasColumnName("Rol_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RolRoleCode)
                    .HasColumnName("Rol_RoleCode")
                    .HasMaxLength(250);

                entity.Property(e => e.RolRoleDescription)
                    .HasColumnName("Rol_RoleDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.RolRoleName).HasColumnName("Rol_RoleName");

                entity.Property(e => e.RolVersion).HasColumnName("Rol_Version");

                entity.HasOne(d => d.RolAccount)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.RolAccountId)
                    .HasConstraintName("FK_Roles_AccountID");
            });

            modelBuilder.Entity<SalarySlipDetails>(entity =>
            {
                entity.HasKey(e => e.SalarySlipDetailId)
                    .HasName("PK__SalarySl__49008D4E33C4BC69");

                entity.Property(e => e.SalarySlipDetailId).HasColumnName("SalarySlipDetailID");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__Skills__DFA091871CA550DE");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SkCreatedBy).HasColumnName("Sk_CreatedBy");

                entity.Property(e => e.SkCreatedDate)
                    .HasColumnName("Sk_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SkIsDeleted).HasColumnName("Sk_isDeleted");

                entity.Property(e => e.SkModifiedBy).HasColumnName("Sk_ModifiedBy");

                entity.Property(e => e.SkModifiedDate)
                    .HasColumnName("Sk_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SkillTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<SocialMedia>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SmAccountId).HasColumnName("Sm_AccountID");

                entity.Property(e => e.SmActiveStatus).HasColumnName("Sm_ActiveStatus");

                entity.Property(e => e.SmCreatedBy).HasColumnName("Sm_CreatedBy");

                entity.Property(e => e.SmCreatedDate)
                    .HasColumnName("Sm_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SmIsDeleted).HasColumnName("Sm_isDeleted");

                entity.Property(e => e.SmModifiedBy).HasColumnName("Sm_ModifiedBy");

                entity.Property(e => e.SmModifiedDate)
                    .HasColumnName("Sm_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Step1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STEP1");

                entity.Property(e => e.DRecordId).HasColumnName("d_record_id");

                entity.Property(e => e.DnisPhone).HasColumnName("dnis_phone");
            });

            modelBuilder.Entity<SubPolicy>(entity =>
            {
                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsCss).HasColumnName("Is_Css");

                entity.Property(e => e.Purpose).IsUnicode(false);

                entity.Property(e => e.SpolActiveStatus).HasColumnName("SPol_ActiveStatus");

                entity.Property(e => e.SpolCreatedBy).HasColumnName("SPol_CreatedBy");

                entity.Property(e => e.SpolCreatedDate)
                    .HasColumnName("SPol_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpolIsDeleted).HasColumnName("SPol_isDeleted");

                entity.Property(e => e.SpolModifiedBy).HasColumnName("SPol_ModifiedBy");

                entity.Property(e => e.SpolModifiedDate)
                    .HasColumnName("SPol_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubPolicyTitle).IsUnicode(false);
            });

            modelBuilder.Entity<SubPolicyDocument>(entity =>
            {
                entity.Property(e => e.DocumentTitle).IsUnicode(false);

                entity.Property(e => e.SubPActiveStatus).HasColumnName("SubP_ActiveStatus");

                entity.Property(e => e.SubPCreatedBy).HasColumnName("SubP_CreatedBy");

                entity.Property(e => e.SubPCreatedDate)
                    .HasColumnName("SubP_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubPIsDeleted).HasColumnName("SubP_isDeleted");

                entity.Property(e => e.SubPModifiedBy).HasColumnName("SubP_ModifiedBy");

                entity.Property(e => e.SubPModifiedDate)
                    .HasColumnName("SubP_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubPolicyDocumenTitle).IsUnicode(false);
            });

            modelBuilder.Entity<TaskDetails>(entity =>
            {
                entity.Property(e => e.TaskDetailsId).HasColumnName("TaskDetailsID");

                entity.Property(e => e.HoursWorked).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProjSpecificTaskId).HasColumnName("Proj_SpecificTaskId");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.TaskDate).HasColumnType("date");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");
            });

            modelBuilder.Entity<TechnologyStack>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__Technolo__C456D72981C4138A");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<TicketImages>(entity =>
            {
                entity.HasKey(e => e.Tiid)
                    .HasName("PK__TicketIm__B6FF654E41036C8E");

                entity.Property(e => e.Tiid).HasColumnName("TIID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketImages)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK__TicketIma__Ticke__2CDD9F46");
            });

            modelBuilder.Entity<TicketPriority>(entity =>
            {
                entity.HasKey(e => e.Tpid)
                    .HasName("PK__TicketPr__A0726B4AD5A2F364");

                entity.Property(e => e.Tpid).HasColumnName("TPID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tickets>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK__Tickets__C456D7292D1F1771");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TicketClosedDate)
                    .HasColumnName("Ticket_Closed_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TicketForecastDate)
                    .HasColumnName("Ticket_Forecast_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TicketRaiseDate)
                    .HasColumnName("Ticket_raise_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Tickets__Departm__2A01329B");
            });

            modelBuilder.Entity<TicketsAuthority>(entity =>
            {
                entity.HasKey(e => e.Taid)
                    .HasName("PK__TicketsA__B43FE34A917C2860");

                entity.Property(e => e.Taid).HasColumnName("TAID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TicketsAuthority)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__TicketsAu__Depar__226010D3");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.ToTable("TIMESHEET");

                entity.Property(e => e.TimesheetId).HasColumnName("TimesheetID");

                entity.Property(e => e.ByWeeklyEndDate).HasColumnType("date");

                entity.Property(e => e.ByWeeklyStartDate).HasColumnType("date");

                entity.Property(e => e.Comments).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.L1ApproverDate)
                    .HasColumnName("L1_ApproverDate")
                    .HasColumnType("date");

                entity.Property(e => e.L1ApproverStatus).HasColumnName("L1_ApproverStatus");

                entity.Property(e => e.L1Manager)
                    .HasColumnName("L1_Manager")
                    .HasMaxLength(10);

                entity.Property(e => e.L1RejectedDate)
                    .HasColumnName("L1_RejectedDate")
                    .HasColumnType("date");

                entity.Property(e => e.L2ApproverDate)
                    .HasColumnName("L2_ApproverDate")
                    .HasColumnType("date");

                entity.Property(e => e.L2ApproverStatus).HasColumnName("L2_ApproverStatus");

                entity.Property(e => e.L2Manager)
                    .HasColumnName("L2_Manager")
                    .HasMaxLength(10);

                entity.Property(e => e.L2RejectedDate)
                    .HasColumnName("L2_RejectedDate")
                    .HasColumnType("date");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.TaskDate).HasColumnType("date");

                entity.Property(e => e.TaskId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimesheetMonth).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TimesheetComments>(entity =>
            {
                entity.HasKey(e => e.TimesheetCommentId)
                    .HasName("PK__Timeshee__E431A07FCFAF86B2");

                entity.ToTable("Timesheet_Comments");

                entity.Property(e => e.TimesheetCommentId).HasColumnName("Timesheet_CommentId");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("date");

                entity.Property(e => e.ManageridL1).HasColumnName("managerid_L1");

                entity.Property(e => e.ManageridL2).HasColumnName("managerid_L2");
            });

            modelBuilder.Entity<UserDevicesToken>(entity =>
            {
                entity.HasKey(e => e.UdTokenId)
                    .HasName("PK__UserDevi__6B6FB2212D9EE326");

                entity.Property(e => e.UdTokenId).HasColumnName("UdTokenID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TokenId)
                    .HasColumnName("TokenID")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserGender>(entity =>
            {
                entity.HasKey(e => e.UsrGenderId)
                    .HasName("PK__UserGend__C9C3E2128280CE81");

                entity.Property(e => e.UsrGenderId).HasColumnName("Usr_GenderId");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLeaveTypeConsumed>(entity =>
            {
                entity.HasKey(e => e.UsrltTypeConsumeId)
                    .HasName("PK__UserLeav__A289C13A74333E14");

                entity.Property(e => e.UsrltTypeConsumeId).HasColumnName("Usrlt_TypeConsumeId");

                entity.Property(e => e.LschmLeaveSchemeId).HasColumnName("LSchm_LeaveSchemeID");

                entity.Property(e => e.NoOfDays).HasColumnName("No_Of_Days");

                entity.Property(e => e.UsrlLeaveId).HasColumnName("Usrl_LeaveId");
            });

            modelBuilder.Entity<UserLeaves>(entity =>
            {
                entity.HasKey(e => e.UsrlLeaveId)
                    .HasName("PK__UserLeav__D8537A6D439D0A86");

                entity.Property(e => e.UsrlLeaveId).HasColumnName("Usrl_LeaveId");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LStatusId).HasColumnName("L_StatusId");

                entity.Property(e => e.LeaveEndDate).HasColumnType("date");

                entity.Property(e => e.LeaveStartDate).HasColumnType("date");

                entity.Property(e => e.OnHoldDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

                entity.Property(e => e.TotNoDays).HasColumnName("Tot_No_Days");

                entity.Property(e => e.UsrlUserId).HasColumnName("Usrl_UserId");
            });

            modelBuilder.Entity<UserProjectEngagement>(entity =>
            {
                entity.HasKey(e => e.UserProjEngId)
                    .HasName("PK__UserProj__60BC0C443444AD73");

                entity.Property(e => e.UserProjEngId).HasColumnName("UserProj_EngId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjSpecificTaskId).HasColumnName("Proj_SpecificTaskId");

                entity.Property(e => e.TskTaskId).HasColumnName("tsk_TaskID");
            });

            modelBuilder.Entity<UserProjects>(entity =>
            {
                entity.HasKey(e => e.UprojUserProjectId);

                entity.Property(e => e.UprojUserProjectId).HasColumnName("UProj_UserProjectID");

                entity.Property(e => e.ClientprojId).HasColumnName("ClientprojID");

                entity.Property(e => e.IsL1Manager).HasColumnName("Is_L1_Manager");

                entity.Property(e => e.IsL2Manager).HasColumnName("Is_L2_Manager");

                entity.Property(e => e.Isclientcalendar).HasColumnName("isclientcalendar");

                entity.Property(e => e.UprojActiveStatus).HasColumnName("UProj_ActiveStatus");

                entity.Property(e => e.UprojCreatedBy).HasColumnName("UProj_CreatedBy");

                entity.Property(e => e.UprojCreatedDate)
                    .HasColumnName("UProj_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UprojEndDate)
                    .HasColumnName("UProj_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UprojIsDeleted).HasColumnName("UProj_isDeleted");

                entity.Property(e => e.UprojL1ManagerId).HasColumnName("UProj_L1_ManagerId");

                entity.Property(e => e.UprojL2ManagerId).HasColumnName("UProj_L2_ManagerId");

                entity.Property(e => e.UprojModifiedBy).HasColumnName("UProj_ModifiedBy");

                entity.Property(e => e.UprojModifiedDate)
                    .HasColumnName("UProj_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UprojParticipationPercentage).HasColumnName("UProj_ParticipationPercentage");

                entity.Property(e => e.UprojProjectId).HasColumnName("UProj_ProjectID");

                entity.Property(e => e.UprojStartDate)
                    .HasColumnName("UProj_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UprojUserId).HasColumnName("UProj_UserID");

                entity.Property(e => e.UprojVersion).HasColumnName("UProj_Version");
            });

            modelBuilder.Entity<UserSalaryCalculations>(entity =>
            {
                entity.Property(e => e.AdministrativeCost).HasMaxLength(100);

                entity.Property(e => e.AdministrativeCostPerHour).HasMaxLength(100);

                entity.Property(e => e.AnnualSalary).HasMaxLength(100);

                entity.Property(e => e.AnnualSalaryPerhour).HasMaxLength(100);

                entity.Property(e => e.Bonus).HasMaxLength(100);

                entity.Property(e => e.BonusPerHour).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Gcfee)
                    .HasColumnName("GCFee")
                    .HasMaxLength(100);

                entity.Property(e => e.GcfeePerHour)
                    .HasColumnName("GCFeePerHour")
                    .HasMaxLength(100);

                entity.Property(e => e.H1bfee)
                    .HasColumnName("H1BFee")
                    .HasMaxLength(100);

                entity.Property(e => e.H1bfeePerHour)
                    .IsRequired()
                    .HasColumnName("H1BFeePerHour")
                    .HasMaxLength(100);

                entity.Property(e => e.Holidays).HasMaxLength(100);

                entity.Property(e => e.HolidaysPerHour).HasMaxLength(100);

                entity.Property(e => e.Insurance).HasMaxLength(100);

                entity.Property(e => e.InsurancePerHour).HasMaxLength(100);

                entity.Property(e => e.PaidBench).HasMaxLength(100);

                entity.Property(e => e.PaidBenchPerHour).HasMaxLength(100);

                entity.Property(e => e.PayrollTaxes).HasMaxLength(100);

                entity.Property(e => e.PayrollTaxesPerHour).HasMaxLength(100);

                entity.Property(e => e.Relocation).HasMaxLength(100);

                entity.Property(e => e.RelocationPerHour).HasMaxLength(100);

                entity.Property(e => e.Total).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e._2weeksPaidVocation)
                    .HasColumnName("2WeeksPaidVocation")
                    .HasMaxLength(100);

                entity.Property(e => e._2weeksPaidVocationPerHour)
                    .HasColumnName("2WeeksPaidVocationPerHour")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserSkills>(entity =>
            {
                entity.HasKey(e => e.UsrSkillId)
                    .HasName("PK__UserSkil__0F63F579B4A24B6C");

                entity.Property(e => e.UsrSkillId).HasColumnName("Usr_SkillId");

                entity.Property(e => e.Experience)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UskCreatedDate)
                    .HasColumnName("Usk_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UskModifiedDate)
                    .HasColumnName("Usk_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrUserId).HasColumnName("Usr_UserId");
            });

            modelBuilder.Entity<UserSocialMediaProfiles>(entity =>
            {
                entity.HasKey(e => e.SocialMediaProfileId)
                    .HasName("PK__UserSoci__8FA5D461EA07862D");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsmpCreatedDate)
                    .HasColumnName("Usmp_CreatedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsmpModifiedDate)
                    .HasColumnName("Usmp_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsmpSocialMediaId).HasColumnName("Usmp_SocialMediaId");

                entity.Property(e => e.UsmpUserId).HasColumnName("Usmp_UserID");
            });

            modelBuilder.Entity<UserTitle>(entity =>
            {
                entity.HasKey(e => e.UsrTitleid)
                    .HasName("PK__UserTitl__080E05F5480473AA");

                entity.Property(e => e.UsrTitleid).HasColumnName("Usr_Titleid");

                entity.Property(e => e.AccAccountId).HasColumnName("Acc_AccountID");

                entity.Property(e => e.TitlePrefix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasKey(e => e.UsTUserTypeId);

                entity.Property(e => e.UsTUserTypeId).HasColumnName("UsT_UserTypeID");

                entity.Property(e => e.UsTAccountId).HasColumnName("UsT_AccountID");

                entity.Property(e => e.UsTActiveStatus)
                    .IsRequired()
                    .HasColumnName("UsT_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsTCreatedBy).HasColumnName("UsT_CreatedBy");

                entity.Property(e => e.UsTCreatedDate)
                    .HasColumnName("UsT_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsTIsDeleted).HasColumnName("UsT_isDeleted");

                entity.Property(e => e.UsTModifiedBy).HasColumnName("UsT_ModifiedBy");

                entity.Property(e => e.UsTModifiedDate)
                    .HasColumnName("UsT_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsTUserType)
                    .IsRequired()
                    .HasColumnName("UsT_UserType")
                    .HasMaxLength(100);

                entity.Property(e => e.UsTUserTypeCode)
                    .IsRequired()
                    .HasColumnName("UsT_UserTypeCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UsTUserTypeDescription)
                    .HasColumnName("UsT_UserTypeDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.UsTVersion).HasColumnName("UsT_Version");

                entity.HasOne(d => d.UsTAccount)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.UsTAccountId)
                    .HasConstraintName("FK_UserType_AccountID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UsrUserId)
                    .HasName("PK_Master_User");

                entity.Property(e => e.UsrUserId).HasColumnName("Usr_UserID");

                entity.Property(e => e.UrlToken)
                    .HasColumnName("Url_token")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrAccountId).HasColumnName("Usr_AccountID");

                entity.Property(e => e.UsrActiveStatus)
                    .IsRequired()
                    .HasColumnName("Usr_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrCreatedBy).HasColumnName("Usr_CreatedBy");

                entity.Property(e => e.UsrCreatedDate)
                    .HasColumnName("Usr_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrIsDeleted).HasColumnName("Usr_isDeleted");

                entity.Property(e => e.UsrLoginId)
                    .IsRequired()
                    .HasColumnName("Usr_LoginId")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrManager).HasColumnName("Usr_Manager");

                entity.Property(e => e.UsrManager2).HasColumnName("Usr_Manager2");

                entity.Property(e => e.UsrModifiedBy).HasColumnName("Usr_ModifiedBy");

                entity.Property(e => e.UsrModifiedDate)
                    .HasColumnName("Usr_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrPassword)
                    .IsRequired()
                    .HasColumnName("Usr_Password")
                    .HasMaxLength(200);

                entity.Property(e => e.UsrRoleId).HasColumnName("Usr_RoleID");

                entity.Property(e => e.UsrSalt).HasColumnName("Usr_salt");

                entity.Property(e => e.UsrTaskId).HasColumnName("Usr_TaskID");

                entity.Property(e => e.UsrUserTypeId).HasColumnName("Usr_UserTypeID");

                entity.Property(e => e.UsrUsername)
                    .HasColumnName("Usr_Username")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrVersion).HasColumnName("Usr_Version");

                entity.HasOne(d => d.UsrAccount)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UsrAccountId)
                    .HasConstraintName("FK_Users_AccountID");

                entity.HasOne(d => d.UsrUserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UsrUserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserTypeID");
            });

            modelBuilder.Entity<UsersForProjects>(entity =>
            {
                entity.HasKey(e => e.UfpUsersForProjectsId);

                entity.Property(e => e.UfpUsersForProjectsId).HasColumnName("Ufp_UsersForProjectsID");

                entity.Property(e => e.UfpActiveStatus)
                    .IsRequired()
                    .HasColumnName("Ufp_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UfpCreatedBy).HasColumnName("Ufp_CreatedBy");

                entity.Property(e => e.UfpCreatedDate)
                    .HasColumnName("Ufp_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UfpEndDate)
                    .HasColumnName("Ufp_EndDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UfpIsDeleted).HasColumnName("Ufp_isDeleted");

                entity.Property(e => e.UfpModifiedBy).HasColumnName("Ufp_ModifiedBy");

                entity.Property(e => e.UfpModifiedDate)
                    .HasColumnName("Ufp_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UfpParticipationPercentage).HasColumnName("Ufp_ParticipationPercentage");

                entity.Property(e => e.UfpProjectId).HasColumnName("Ufp_ProjectID");

                entity.Property(e => e.UfpStartDate)
                    .HasColumnName("Ufp_StartDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UfpUserId).HasColumnName("Ufp_UserID");

                entity.Property(e => e.UfpVersion).HasColumnName("Ufp_Version");
            });

            modelBuilder.Entity<UsersProfile>(entity =>
            {
                entity.HasKey(e => e.UsrPUserProfileId);

                entity.Property(e => e.UsrPUserProfileId).HasColumnName("UsrP_UserProfileID");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Passcode)
                    .HasColumnName("passcode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TemporaryAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UsrGenderId).HasColumnName("Usr_GenderId");

                entity.Property(e => e.UsrPActiveStatus)
                    .IsRequired()
                    .HasColumnName("UsrP_ActiveStatus")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsrPCreatedBy).HasColumnName("UsrP_CreatedBy");

                entity.Property(e => e.UsrPCreatedDate)
                    .HasColumnName("UsrP_CreatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsrPDob)
                    .HasColumnName("UsrP_DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrPEmailId)
                    .HasColumnName("UsrP_EmailID")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrPEmployeeId)
                    .HasColumnName("UsrP_EmployeeID")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrPFirstName)
                    .IsRequired()
                    .HasColumnName("UsrP_FirstName")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrPIsDeleted).HasColumnName("UsrP_isDeleted");

                entity.Property(e => e.UsrPLastName)
                    .IsRequired()
                    .HasColumnName("UsrP_LastName")
                    .HasMaxLength(100);

                entity.Property(e => e.UsrPModifiedBy).HasColumnName("UsrP_ModifiedBy");

                entity.Property(e => e.UsrPModifiedDate)
                    .HasColumnName("UsrP_ModifiedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrPUserId).HasColumnName("UsrP_UserID");

                entity.Property(e => e.UsrPVersion).HasColumnName("UsrP_Version");

                entity.Property(e => e.UsrTitleid).HasColumnName("Usr_Titleid");

                entity.Property(e => e.UsrpCountryCode).HasColumnName("Usrp_CountryCode");

                entity.Property(e => e.UsrpDoj)
                    .HasColumnName("Usrp_DOJ")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrpMobileNumber)
                    .HasColumnName("Usrp_MobileNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.UsrpProfilePicture)
                    .HasColumnName("Usrp_ProfilePicture")
                    .HasMaxLength(200);

                entity.HasOne(d => d.UsrPUser)
                    .WithMany(p => p.UsersProfile)
                    .HasForeignKey(d => d.UsrPUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersProfile_Master_User1");
            });

            modelBuilder.Entity<UserworkfromHome>(entity =>
            {
                entity.HasKey(e => e.UserwfhId)
                    .HasName("PK__Userwork__54F663F2B5D9B125");

                entity.Property(e => e.UserwfhId).HasColumnName("UserwfhID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsWorkFromHome).HasColumnName("Is_WorkFromHome");

                entity.Property(e => e.LStatusId).HasColumnName("L_StatusId");

                entity.Property(e => e.OnHoldDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

                entity.Property(e => e.TotNoDays).HasColumnName("Tot_No_Days");

                entity.Property(e => e.UserwfhEndDate).HasColumnType("date");

                entity.Property(e => e.UserwfhStartDate).HasColumnType("date");

                entity.Property(e => e.UsrlUserId).HasColumnName("Usrl_UserId");
            });

            modelBuilder.Entity<UssalaryComponents>(entity =>
            {
                entity.HasKey(e => e.UssalaryComponentId)
                    .HasName("PK__USSalary__93969884811AD992");

                entity.ToTable("USSalaryComponents");

                entity.Property(e => e.UssalaryComponentId).HasColumnName("USSalaryComponentID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UssalaryComponent)
                    .HasColumnName("USSalaryComponent")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UssalaryComponentValue)
                    .HasColumnName("USSalaryComponentValue")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisaType>(entity =>
            {
                entity.Property(e => e.VisaTypeId).HasColumnName("VisaTypeID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VisaType1)
                    .HasColumnName("VisaType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VisaTypeShortForm)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence<int>("CreatePasscode")
                .StartsAt(1000)
                .HasMin(1000)
                .HasMax(9999);

            modelBuilder.HasSequence<int>("ProjectCode").StartsAt(170);

            modelBuilder.HasSequence<int>("RoleModuleID").StartsAt(750);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
