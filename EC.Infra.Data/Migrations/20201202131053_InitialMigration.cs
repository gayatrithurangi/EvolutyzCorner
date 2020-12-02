using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Infra.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "CreatePasscode",
                startValue: 1000L,
                minValue: 1000L,
                maxValue: 9999L);

            migrationBuilder.CreateSequence<int>(
                name: "ProjectCode",
                startValue: 170L);

            migrationBuilder.CreateSequence<int>(
                name: "RoleModuleID",
                startValue: 750L);

            migrationBuilder.CreateTable(
                name: "__MigrationHistory",
                columns: table => new
                {
                    MigrationId = table.Column<string>(maxLength: 150, nullable: false),
                    ContextKey = table.Column<string>(maxLength: 300, nullable: false),
                    Model = table.Column<byte[]>(nullable: false),
                    ProductVersion = table.Column<string>(maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.__MigrationHistory", x => new { x.MigrationId, x.ContextKey });
                });

            migrationBuilder.CreateTable(
                name: "Acc_Spec_OptionalHolidays",
                columns: table => new
                {
                    FinancialYearId = table.Column<int>(nullable: false),
                    Acc_Spec_OptionalHolidayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccoutID = table.Column<int>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    NoofOptionalHolidays = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Acc_Spec__6ECE4C913118C8A0", x => x.FinancialYearId);
                });

            migrationBuilder.CreateTable(
                name: "AccountClients",
                columns: table => new
                {
                    Acc_ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    WebsiteUrl = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IndustryID = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Fax = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    PostalCode = table.Column<string>(unicode: false, maxLength: 6, nullable: true),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AccountC__20F03F6DC26D585C", x => x.Acc_ClientID);
                });

            migrationBuilder.CreateTable(
                name: "AccountDepartments",
                columns: table => new
                {
                    AccountDepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Dept_Description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Dept_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Dept_CreatedBy = table.Column<int>(nullable: true),
                    Dept_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Dept_ModifiedBy = table.Column<int>(nullable: true),
                    Dept_isDeleted = table.Column<bool>(nullable: true),
                    Dept_ActiveStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AccountD__7D5BB9ED47E49C53", x => x.AccountDepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "AccountSocialMediaProfiles",
                columns: table => new
                {
                    Acc_SocialMediaProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asmp_AccountId = table.Column<int>(nullable: true),
                    Asmp_SocialMediaId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Asmp_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Asmp_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AccountS__6C99D9572888619E", x => x.Acc_SocialMediaProfileId);
                });

            migrationBuilder.CreateTable(
                name: "AccountSpecificTasks",
                columns: table => new
                {
                    Acc_SpecificTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(nullable: true),
                    Acc_SpecificTaskName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: true),
                    StatusId = table.Column<bool>(nullable: true),
                    tsk_TaskID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AccountS__8E18E0FC9103E344", x => x.Acc_SpecificTaskId);
                });

            migrationBuilder.CreateTable(
                name: "AlexaDevices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceID = table.Column<string>(nullable: true),
                    UsrP_EmployeeID = table.Column<string>(maxLength: 8, nullable: true),
                    IsAuthenticated = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlexaDevices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    UserId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 128, nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assessment_For_Position",
                columns: table => new
                {
                    APID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewForPositionname = table.Column<string>(maxLength: 300, nullable: true),
                    Title = table.Column<string>(maxLength: 300, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Assessme__4C29F36F06DB4275", x => x.APID);
                });

            migrationBuilder.CreateTable(
                name: "ClientProjectsTasks",
                columns: table => new
                {
                    CL_ProjectsTasksID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accountid = table.Column<int>(nullable: true),
                    rol_roleid = table.Column<int>(nullable: true),
                    acc_specifictaskid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClientPr__ClientProjectsTasks", x => x.CL_ProjectsTasksID);
                });

            migrationBuilder.CreateTable(
                name: "ClientsBusiness",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClientsB__F1EAA36EEC470BE4", x => x.BusinessId);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TicketId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Timstamp = table.Column<byte[]>(rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__comments__CDDE919D6653514E", x => x.commentId);
                });

            migrationBuilder.CreateTable(
                name: "ComponentType",
                columns: table => new
                {
                    ComponentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Com_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Com_CreatedBy = table.Column<int>(nullable: true),
                    Com_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Com_ModifiedBy = table.Column<int>(nullable: true),
                    Com_isDeleted = table.Column<bool>(nullable: true),
                    Com_ActiveStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentType", x => x.ComponentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ContentType",
                columns: table => new
                {
                    ContentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentTitle = table.Column<string>(unicode: false, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    Con_ActiveStatus = table.Column<bool>(nullable: true),
                    Con_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Con_CreatedBy = table.Column<int>(nullable: true),
                    Con_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Con_ModifiedBy = table.Column<int>(nullable: true),
                    Con_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentType", x => x.ContentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CountryName = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    PhoneCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    StatusId = table.Column<bool>(nullable: true),
                    IsActive = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Did = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(maxLength: 200, nullable: true),
                    DepartmentDescription = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__C0312218E015C032", x => x.Did);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceId = table.Column<string>(unicode: false, nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    DocumentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTitle = table.Column<string>(unicode: false, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    Doc_ActiveStatus = table.Column<bool>(nullable: true),
                    Doc_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Doc_CreatedBy = table.Column<int>(nullable: true),
                    Doc_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Doc_ModifiedBy = table.Column<int>(nullable: true),
                    Doc_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBankDetails",
                columns: table => new
                {
                    EmpBankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpB_UserID = table.Column<int>(nullable: true),
                    BANK_No = table.Column<long>(nullable: true),
                    PAN_No = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    UAN_No = table.Column<long>(nullable: true),
                    PF_No = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ESI_No = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PayModeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__6A76EDD193A76714", x => x.EmpBankID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaryComponent",
                columns: table => new
                {
                    EmpSalCompId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpSC_AccountID = table.Column<int>(nullable: true),
                    ComponentTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ComponentDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ComponentTypeId = table.Column<int>(nullable: true),
                    EmpSC_ActiveStatus = table.Column<bool>(nullable: true),
                    EmpSC_Version = table.Column<int>(nullable: true),
                    EmpSC_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpSC_CreatedBy = table.Column<int>(nullable: true),
                    EmpSC_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmpSC_ModifiedBy = table.Column<int>(nullable: true),
                    EmpSC_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__D754E4733063685A", x => x.EmpSalCompId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalarySlips",
                columns: table => new
                {
                    EmpSalarySlipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Epmss_UserID = table.Column<int>(nullable: true),
                    Month = table.Column<int>(nullable: true),
                    YEAR = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__E1895488E987072A", x => x.EmpSalarySlipID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaryStructure",
                columns: table => new
                {
                    Emps_StructureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emps_UserID = table.Column<int>(nullable: true),
                    WorkingDays = table.Column<int>(nullable: true),
                    WorkedDays = table.Column<int>(nullable: true),
                    Payable = table.Column<int>(nullable: true),
                    SalaryMonth = table.Column<DateTime>(type: "datetime", nullable: true),
                    FinancialYearId = table.Column<int>(nullable: true),
                    CTC = table.Column<decimal>(type: "money", nullable: true),
                    Ess_ActiveStatus = table.Column<bool>(nullable: true),
                    Ess_Version = table.Column<int>(nullable: true),
                    Ess_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ess_CreatedBy = table.Column<int>(nullable: true),
                    Ess_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ess_ModifiedBy = table.Column<int>(nullable: true),
                    Ess_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__6DF8601300D16DE3", x => x.Emps_StructureID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalaryStructureDetails",
                columns: table => new
                {
                    EmpssdetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpSalCompId = table.Column<int>(nullable: true),
                    Emps_StructureId = table.Column<int>(nullable: true),
                    EssD_ActiveStatus = table.Column<bool>(nullable: true),
                    EssD_Version = table.Column<int>(nullable: true),
                    EssD_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EssD_CreatedBy = table.Column<int>(nullable: true),
                    EssD_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EssD_ModifiedBy = table.Column<int>(nullable: true),
                    EssD_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__34451075A3A937AD", x => x.EmpssdetailId);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    ErrorlogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    MethodName = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    ErrorMessage = table.Column<string>(unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ErrorLog__4F9BF6F2AB599A44", x => x.ErrorlogId);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYear",
                columns: table => new
                {
                    FinancialYearId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<int>(nullable: true),
                    EndDate = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYear", x => x.FinancialYearId);
                });

            migrationBuilder.CreateTable(
                name: "GenericRoles",
                columns: table => new
                {
                    GenericRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    StatusID = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GenericR__3E5CEFF6288AEB01", x => x.GenericRoleID);
                });

            migrationBuilder.CreateTable(
                name: "GenericTasks",
                columns: table => new
                {
                    tsk_TaskID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tsk_TaskName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    tsk_TaskDescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    tsk_ActiveStatus = table.Column<bool>(nullable: false),
                    tsk_Version = table.Column<short>(nullable: false),
                    tsk_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    tsk_CreatedBy = table.Column<int>(nullable: false),
                    tsk_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    tsk_ModifiedBy = table.Column<int>(nullable: true),
                    tsk_isDeleted = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskLookup", x => x.tsk_TaskID);
                });

            migrationBuilder.CreateTable(
                name: "HireType",
                columns: table => new
                {
                    HireTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HireType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HireTypeShortForm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    StatusID = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HireType", x => x.HireTypeID);
                });

            migrationBuilder.CreateTable(
                name: "History_Account",
                columns: table => new
                {
                    History_Account_AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_Acc_AccountID = table.Column<int>(nullable: false),
                    History_Acc_AccountCode = table.Column<string>(maxLength: 50, nullable: false),
                    History_Acc_AccountName = table.Column<string>(maxLength: 100, nullable: false),
                    History_Acc_AccountDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_Acc_EmailID = table.Column<string>(maxLength: 100, nullable: true),
                    History_Acc_MobileNumber = table.Column<string>(maxLength: 100, nullable: true),
                    History_Acc_PhoneNumber = table.Column<string>(maxLength: 100, nullable: true),
                    History_Acc_CompanyLogo = table.Column<string>(maxLength: 200, nullable: true),
                    History_Acc_ActiveStatus = table.Column<bool>(nullable: false),
                    History_Acc_Version = table.Column<short>(nullable: false),
                    History_Acc_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_Acc_CreatedBy = table.Column<int>(nullable: false),
                    History_Acc_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_Acc_ModifiedBy = table.Column<int>(nullable: true),
                    History_Acc_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_Account", x => x.History_Account_AccountID);
                });

            migrationBuilder.CreateTable(
                name: "History_LeaveComments",
                columns: table => new
                {
                    History_CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usrl_LeaveId = table.Column<int>(nullable: false),
                    Userid = table.Column<int>(nullable: false),
                    createdDate = table.Column<DateTime>(type: "date", nullable: false),
                    Action = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    managerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__History___9785CB96D89435E7", x => x.History_CommentId);
                });

            migrationBuilder.CreateTable(
                name: "History_LeaveScheme",
                columns: table => new
                {
                    History_LeaveScheme_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_LSchm_LeaveSchemeID = table.Column<int>(nullable: false),
                    History_LSchm_LeaveTypeID = table.Column<int>(nullable: false),
                    History_LSchm_UserTypeID = table.Column<int>(nullable: false),
                    History_LSchm_LeaveFrequency = table.Column<string>(maxLength: 50, nullable: false),
                    History_LSchm_AccountID = table.Column<int>(nullable: false),
                    History_LSchm_LeaveSchemeCode = table.Column<string>(maxLength: 50, nullable: false),
                    History_LSchm_LeaveScheme = table.Column<string>(maxLength: 100, nullable: false),
                    History_LSchm_LeaveSchemeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_LSchm_LeaveCount = table.Column<short>(nullable: false),
                    History_LSchm_ActiveStatus = table.Column<bool>(nullable: false),
                    History_LSchm_Version = table.Column<short>(nullable: false),
                    History_LSchm_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_LSchm_CreatedBy = table.Column<int>(nullable: false),
                    History_LSchm_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_LSchm_ModifiedBy = table.Column<int>(nullable: true),
                    History_LSchm_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_LeaveScheme", x => x.History_LeaveScheme_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_LeaveType",
                columns: table => new
                {
                    History_LeaveType_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_LTyp_LeaveTypeID = table.Column<int>(nullable: false),
                    History_LTyp_AccountID = table.Column<int>(nullable: false),
                    History_LTyp_LeaveType = table.Column<string>(maxLength: 100, nullable: false),
                    History_LTyp_LeaveTypeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_LTyp_ActiveStatus = table.Column<bool>(nullable: false),
                    History_LTyp_Version = table.Column<short>(nullable: false),
                    History_LTyp_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_LTyp_CreatedBy = table.Column<int>(nullable: false),
                    History_LTyp_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_LTyp_ModifiedBy = table.Column<int>(nullable: true),
                    History_LTyp_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_LeaveType", x => x.History_LeaveType_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_Projects",
                columns: table => new
                {
                    History_Project_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_Proj_ProjectID = table.Column<int>(nullable: false),
                    History_Proj_AccountID = table.Column<int>(nullable: false),
                    History_Proj_ProjectCode = table.Column<string>(maxLength: 50, nullable: false),
                    History_Proj_ProjectName = table.Column<string>(maxLength: 100, nullable: false),
                    History_Proj_ProjectDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_Proj_StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_Proj_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_Proj_ActiveStatus = table.Column<bool>(nullable: false),
                    History_Proj_Version = table.Column<short>(nullable: false),
                    History_Proj_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_Proj_CreatedBy = table.Column<int>(nullable: false),
                    History_Proj_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_Proj_ModifiedBy = table.Column<int>(nullable: true),
                    History_Proj_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_Projects", x => x.History_Project_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_Role",
                columns: table => new
                {
                    History_Role_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_Rol_RoleID = table.Column<int>(nullable: false),
                    History_Rol_AccountID = table.Column<int>(nullable: false),
                    History_Rol_RoleCode = table.Column<string>(maxLength: 50, nullable: false),
                    History_Rol_RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    History_Rol_RoleDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_Rol_ActiveStatus = table.Column<bool>(nullable: false),
                    History_Rol_Version = table.Column<int>(nullable: false),
                    History_Rol_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_Rol_createdBy = table.Column<int>(nullable: false),
                    History_Rol_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_Rol_ModifiedBy = table.Column<int>(nullable: true),
                    History_Rol_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_Role", x => x.History_Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_UserProjects",
                columns: table => new
                {
                    HUProj_UserProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HUProj_ProjectID = table.Column<int>(nullable: false),
                    HUProj_UserID = table.Column<int>(nullable: false),
                    HUProj_StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    HUProj_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HUProj_ParticipationPercentage = table.Column<byte>(nullable: false),
                    HUProj_ActiveStatus = table.Column<bool>(nullable: false),
                    HUProj_Version = table.Column<short>(nullable: false),
                    HUProj_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    HUProj_CreatedBy = table.Column<int>(nullable: false),
                    HUProj_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HUProj_ModifiedBy = table.Column<int>(nullable: true),
                    HUProj_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_UserProjects", x => x.HUProj_UserProjectID);
                });

            migrationBuilder.CreateTable(
                name: "History_Users",
                columns: table => new
                {
                    History_User_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_Usr_UserID = table.Column<int>(nullable: false),
                    History_Usr_AccountID = table.Column<int>(nullable: false),
                    History_Usr_UserTypeID = table.Column<int>(nullable: false),
                    History_Usr_RoleID = table.Column<int>(nullable: false),
                    History_Usr_Manager = table.Column<int>(nullable: true),
                    History_Usr_Manager2 = table.Column<int>(nullable: true),
                    History_Usr_Username = table.Column<string>(maxLength: 50, nullable: true),
                    History_Usr_LoginId = table.Column<string>(maxLength: 100, nullable: false),
                    History_Usr_Password = table.Column<string>(maxLength: 200, nullable: false),
                    History_Usr_ActiveStatus = table.Column<bool>(nullable: false),
                    History_Usr_TaskID = table.Column<int>(nullable: true),
                    History_Usr_Version = table.Column<short>(nullable: false),
                    History_Usr_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_Usr_CreatedBy = table.Column<int>(nullable: true),
                    History_Usr_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_Usr_ModifiedBy = table.Column<int>(nullable: true),
                    History_Usr_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_Users", x => x.History_User_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_UserType",
                columns: table => new
                {
                    History_UserType_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    History_UsT_UserTypeID = table.Column<int>(nullable: false),
                    History_AccountID = table.Column<int>(nullable: false),
                    History_UsT_UserTypeCode = table.Column<string>(maxLength: 50, nullable: false),
                    History_UsT_UserType = table.Column<string>(maxLength: 100, nullable: false),
                    History_UsT_UserTypeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    History_UsT_ActiveStatus = table.Column<bool>(nullable: false),
                    History_UsT_Version = table.Column<int>(nullable: false),
                    History_UsT_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    History_UsT_CreatedBy = table.Column<int>(nullable: false),
                    History_UsT_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    History_UsT_ModifiedBy = table.Column<int>(nullable: true),
                    History_UsT_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History_UserType", x => x.History_UserType_ID);
                });

            migrationBuilder.CreateTable(
                name: "History_WFHComments",
                columns: table => new
                {
                    History_WFHCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserwfhID = table.Column<int>(nullable: false),
                    Userid = table.Column<int>(nullable: false),
                    createdDate = table.Column<DateTime>(type: "date", nullable: false),
                    Action = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    managerid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__History___1F68D78137A875CF", x => x.History_WFHCommentId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveScheme",
                columns: table => new
                {
                    LSchm_LeaveSchemeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LSchm_LeaveTypeID = table.Column<int>(nullable: false),
                    LSchm_UserTypeID = table.Column<int>(nullable: false),
                    LSchm_LeaveFrequency = table.Column<string>(maxLength: 50, nullable: true),
                    LSchm_AccountID = table.Column<int>(nullable: false),
                    LSchm_LeaveSchemeCode = table.Column<string>(maxLength: 50, nullable: true),
                    LSchm_LeaveScheme = table.Column<string>(maxLength: 100, nullable: true),
                    LSchm_LeaveSchemeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    LSchm_LeaveCount = table.Column<double>(nullable: true),
                    LSchm_ActiveStatus = table.Column<bool>(nullable: false),
                    LSchm_Version = table.Column<short>(nullable: true),
                    LSchm_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LSchm_CreatedBy = table.Column<int>(nullable: false),
                    LSchm_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LSchm_ModifiedBy = table.Column<int>(nullable: true),
                    LSchm_isDeleted = table.Column<bool>(nullable: false),
                    FinancialYearId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveScheme", x => x.LSchm_LeaveSchemeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveStatus",
                columns: table => new
                {
                    L_StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    L_Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LeaveSta__C478A10C5EF76E46", x => x.L_StatusId);
                });

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    LTyp_LeaveTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LTyp_AccountID = table.Column<int>(nullable: false),
                    LTyp_LeaveType = table.Column<string>(maxLength: 100, nullable: false),
                    LTyp_LeaveTypeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    LTyp_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    LTyp_Version = table.Column<short>(nullable: false),
                    LTyp_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LTyp_CreatedBy = table.Column<int>(nullable: false),
                    LTyp_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LTyp_ModifiedBy = table.Column<int>(nullable: true),
                    LTyp_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.LTyp_LeaveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Master_Module",
                columns: table => new
                {
                    Mod_ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mod_ModuleCode = table.Column<string>(maxLength: 50, nullable: false),
                    Mod_ModuleName = table.Column<string>(maxLength: 100, nullable: false),
                    Mod_Description = table.Column<string>(maxLength: 500, nullable: true),
                    Mod_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Mod_Version = table.Column<short>(nullable: false),
                    Mod_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Mod_CreatedBy = table.Column<int>(nullable: false),
                    Mod_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mod_ModifiedBy = table.Column<int>(nullable: true),
                    Mod_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master_Module", x => x.Mod_ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Master_Sub_Module",
                columns: table => new
                {
                    Sub_ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mod_ModuleID = table.Column<int>(nullable: false),
                    Sub_ModuleCode = table.Column<string>(maxLength: 50, nullable: false),
                    Sub_ModuleName = table.Column<string>(maxLength: 100, nullable: false),
                    Sub_Description = table.Column<string>(maxLength: 500, nullable: true),
                    Sub_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Sub_Version = table.Column<short>(nullable: false),
                    Sub_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Sub_CreatedBy = table.Column<int>(nullable: false),
                    Sub_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sub_ModifiedBy = table.Column<int>(nullable: true),
                    Sub_isDeleted = table.Column<bool>(nullable: false),
                    Orderby = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Module", x => x.Sub_ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "Master_TimesheetMode",
                columns: table => new
                {
                    TimesheetMode_id = table.Column<int>(nullable: false),
                    TimeModeName = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Master_T__D226F810CFC74009", x => x.TimesheetMode_id);
                });

            migrationBuilder.CreateTable(
                name: "MobileNotificationTemplate",
                columns: table => new
                {
                    MobileNotificationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MobileNo__DC73F57D4A71239E", x => x.MobileNotificationId);
                });

            migrationBuilder.CreateTable(
                name: "ModuleAccessType",
                columns: table => new
                {
                    ModuleAccessTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleAccessType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    StatusId = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuleAccessType", x => x.ModuleAccessTypeID);
                });

            migrationBuilder.CreateTable(
                name: "NewsBoard",
                columns: table => new
                {
                    NewsBoardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    Image = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    News_Status = table.Column<bool>(nullable: true),
                    AccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsBoard", x => x.NewsBoardId);
                });

            migrationBuilder.CreateTable(
                name: "NobleLeadData_AIU",
                columns: table => new
                {
                    SyStudentId = table.Column<double>(nullable: true),
                    Phone = table.Column<double>(nullable: true),
                    School = table.Column<string>(maxLength: 255, nullable: true),
                    amleadsrcid = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NobleLeadData_CTU",
                columns: table => new
                {
                    SyStudentId = table.Column<double>(nullable: true),
                    Phone = table.Column<double>(nullable: true),
                    School = table.Column<string>(maxLength: 255, nullable: true),
                    amleadsrcid = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PayMode",
                columns: table => new
                {
                    PayModeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayMode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PayModeDescription = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayMode", x => x.PayModeID);
                });

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    PhaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseTitle = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    ShortDescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Phases__5BA26D62481213A5", x => x.PhaseId);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    PolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyTitle = table.Column<string>(unicode: false, nullable: true),
                    Icon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Is_Css = table.Column<bool>(nullable: true),
                    PolicyDescription = table.Column<string>(unicode: false, nullable: true),
                    Pol_ActiveStatus = table.Column<bool>(nullable: true),
                    Pol_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Pol_CreatedBy = table.Column<int>(nullable: true),
                    Pol_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Pol_ModifiedBy = table.Column<int>(nullable: true),
                    Pol_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Policies__2E1339A4C7379F6A", x => x.PolicyId);
                });

            migrationBuilder.CreateTable(
                name: "Project_workstatus",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UserName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    FromDT = table.Column<DateTime>(type: "datetime", nullable: true),
                    ToDT = table.Column<DateTime>(type: "datetime", nullable: true),
                    PercentageCompleted = table.Column<string>(unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project_workstatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectPhases",
                columns: table => new
                {
                    Proj_PhaseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseId = table.Column<int>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    Actual_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Actual_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plan_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plan_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectP__61A6D420235416AD", x => x.Proj_PhaseId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Proj_ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proj_AccountID = table.Column<int>(nullable: false),
                    Proj_ClientName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Proj_ProjectCode = table.Column<string>(maxLength: 50, nullable: false),
                    Proj_ProjectName = table.Column<string>(maxLength: 100, nullable: false),
                    Proj_ProjectDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Plan_StartDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Plan_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Proj_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Proj_Version = table.Column<short>(nullable: false),
                    Proj_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Proj_CreatedBy = table.Column<int>(nullable: false),
                    Proj_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Proj_ModifiedBy = table.Column<int>(nullable: true),
                    Proj_isDeleted = table.Column<bool>(nullable: false),
                    Actual_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Actual_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Timesheet_ProjectSpecific = table.Column<bool>(nullable: true),
                    CountryID = table.Column<int>(nullable: true),
                    StateID = table.Column<int>(nullable: true),
                    WebUrl = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Proj_ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSpecificTasks",
                columns: table => new
                {
                    Proj_SpecificTaskId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(nullable: true),
                    Proj_SpecificTaskName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    RTMId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Actual_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Actual_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plan_StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Plan_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: true),
                    StatusId = table.Column<bool>(nullable: true),
                    tsk_TaskID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProjectS__D80A6D75D51FFB93", x => x.Proj_SpecificTaskId);
                });

            migrationBuilder.CreateTable(
                name: "RequestMessages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RoleModules",
                columns: table => new
                {
                    RMod_RoleModuleID = table.Column<int>(nullable: false),
                    RMod_AccountID = table.Column<int>(nullable: false),
                    RMod_RoleID = table.Column<int>(nullable: false),
                    Sub_ModuleID = table.Column<int>(nullable: false),
                    ModuleAccessTypeID = table.Column<int>(nullable: true),
                    RMod_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    RMod_Version = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RMod_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    RMod_CreatedBy = table.Column<int>(nullable: false),
                    RMod_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RMod_ModifiedBy = table.Column<int>(nullable: true),
                    RMod_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleModule", x => x.RMod_RoleModuleID);
                });

            migrationBuilder.CreateTable(
                name: "SalarySlipDetails",
                columns: table => new
                {
                    SalarySlipDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpssdetailId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SalarySl__49008D4E33C4BC69", x => x.SalarySlipDetailID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ShortDescription = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    Sk_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sk_CreatedBy = table.Column<int>(nullable: true),
                    Sk_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sk_ModifiedBy = table.Column<int>(nullable: true),
                    Sk_isDeleted = table.Column<bool>(nullable: true),
                    Acc_AccountID = table.Column<int>(nullable: true),
                    StatusID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Skills__DFA091871CA550DE", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sm_AccountID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Url = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Description = table.Column<string>(unicode: false, nullable: true),
                    Icon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Sm_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sm_CreatedBy = table.Column<int>(nullable: true),
                    Sm_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Sm_ModifiedBy = table.Column<int>(nullable: true),
                    Sm_isDeleted = table.Column<bool>(nullable: true),
                    Sm_ActiveStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Countryid = table.Column<int>(nullable: false),
                    StateCode = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    StateName = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    StatusId = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "STEP1",
                columns: table => new
                {
                    d_record_id = table.Column<double>(nullable: true),
                    dnis_phone = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SubPolicy",
                columns: table => new
                {
                    SubPolicyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyId = table.Column<int>(nullable: true),
                    SubPolicyTitle = table.Column<string>(unicode: false, nullable: true),
                    Icon = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Is_Css = table.Column<bool>(nullable: true),
                    Purpose = table.Column<string>(unicode: false, nullable: true),
                    SPol_ActiveStatus = table.Column<bool>(nullable: true),
                    SPol_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SPol_CreatedBy = table.Column<int>(nullable: true),
                    SPol_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SPol_ModifiedBy = table.Column<int>(nullable: true),
                    SPol_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPolicy", x => x.SubPolicyId);
                });

            migrationBuilder.CreateTable(
                name: "SubPolicyDocument",
                columns: table => new
                {
                    SubPolicyDocumentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubPolicyId = table.Column<int>(nullable: true),
                    SubPolicyDocumenTitle = table.Column<string>(unicode: false, nullable: true),
                    DocumentTypeId = table.Column<int>(nullable: true),
                    ContentTypeId = table.Column<int>(nullable: true),
                    DocumentTitle = table.Column<string>(unicode: false, nullable: true),
                    DocumentFile = table.Column<byte[]>(nullable: true),
                    SubP_ActiveStatus = table.Column<bool>(nullable: true),
                    SubP_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubP_CreatedBy = table.Column<int>(nullable: true),
                    SubP_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubP_ModifiedBy = table.Column<int>(nullable: true),
                    SubP_isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubPolicyDocument", x => x.SubPolicyDocumentId);
                });

            migrationBuilder.CreateTable(
                name: "TaskDetails",
                columns: table => new
                {
                    TaskDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimesheetID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    HoursWorked = table.Column<decimal>(type: "decimal(5, 2)", nullable: true),
                    TaskDate = table.Column<DateTime>(type: "date", nullable: true),
                    Proj_SpecificTaskId = table.Column<int>(nullable: true),
                    projectid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskDetails", x => x.TaskDetailsID);
                });

            migrationBuilder.CreateTable(
                name: "TechnologyStack",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Technolo__C456D72981C4138A", x => x.TID);
                });

            migrationBuilder.CreateTable(
                name: "TicketPriority",
                columns: table => new
                {
                    TPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TicketPr__A0726B4AD5A2F364", x => x.TPID);
                });

            migrationBuilder.CreateTable(
                name: "TIMESHEET",
                columns: table => new
                {
                    TimesheetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    TaskDate = table.Column<DateTime>(type: "date", nullable: true),
                    TimesheetMonth = table.Column<DateTime>(type: "date", nullable: false),
                    Comments = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    TaskId = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    SubmittedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SubmittedType = table.Column<bool>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    L1_Manager = table.Column<string>(maxLength: 10, nullable: true),
                    L1_ApproverStatus = table.Column<int>(nullable: true),
                    L1_ApproverDate = table.Column<DateTime>(type: "date", nullable: true),
                    L1_RejectedDate = table.Column<DateTime>(type: "date", nullable: true),
                    L2_Manager = table.Column<string>(maxLength: 10, nullable: true),
                    L2_ApproverStatus = table.Column<int>(nullable: true),
                    L2_ApproverDate = table.Column<DateTime>(type: "date", nullable: true),
                    L2_RejectedDate = table.Column<DateTime>(type: "date", nullable: true),
                    DeviceTypeId = table.Column<int>(nullable: true),
                    ByWeeklyStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    ByWeeklyEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    ClientProjtId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIMESHEET", x => x.TimesheetID);
                });

            migrationBuilder.CreateTable(
                name: "Timesheet_Comments",
                columns: table => new
                {
                    Timesheet_CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timesheetid = table.Column<int>(nullable: false),
                    Userid = table.Column<int>(nullable: false),
                    createdDate = table.Column<DateTime>(type: "date", nullable: false),
                    Action = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    managerid_L1 = table.Column<int>(nullable: true),
                    managerid_L2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Timeshee__E431A07FCFAF86B2", x => x.Timesheet_CommentId);
                });

            migrationBuilder.CreateTable(
                name: "UserDevicesToken",
                columns: table => new
                {
                    UdTokenID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    TokenID = table.Column<string>(unicode: false, maxLength: 300, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserDevi__6B6FB2212D9EE326", x => x.UdTokenID);
                });

            migrationBuilder.CreateTable(
                name: "UserGender",
                columns: table => new
                {
                    Usr_GenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserGend__C9C3E2128280CE81", x => x.Usr_GenderId);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaves",
                columns: table => new
                {
                    Usrl_LeaveId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usrl_UserId = table.Column<int>(nullable: true),
                    LeaveStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Tot_No_Days = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    L_StatusId = table.Column<int>(nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejectedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<int>(nullable: true),
                    RejectedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    OnHoldDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OnHoldBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserLeav__D8537A6D439D0A86", x => x.Usrl_LeaveId);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaveTypeConsumed",
                columns: table => new
                {
                    Usrlt_TypeConsumeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usrl_LeaveId = table.Column<int>(nullable: true),
                    LSchm_LeaveSchemeID = table.Column<int>(nullable: true),
                    No_Of_Days = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserLeav__A289C13A74333E14", x => x.Usrlt_TypeConsumeId);
                });

            migrationBuilder.CreateTable(
                name: "UserProjectEngagement",
                columns: table => new
                {
                    UserProj_EngId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: true),
                    ProjectId = table.Column<int>(nullable: true),
                    tsk_TaskID = table.Column<int>(nullable: true),
                    Proj_SpecificTaskId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserProj__60BC0C443444AD73", x => x.UserProj_EngId);
                });

            migrationBuilder.CreateTable(
                name: "UserProjects",
                columns: table => new
                {
                    UProj_UserProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UProj_ProjectID = table.Column<int>(nullable: false),
                    UProj_UserID = table.Column<int>(nullable: false),
                    UProj_StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UProj_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UProj_ParticipationPercentage = table.Column<byte>(nullable: false),
                    UProj_ActiveStatus = table.Column<bool>(nullable: false),
                    UProj_Version = table.Column<short>(nullable: false),
                    UProj_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    UProj_CreatedBy = table.Column<int>(nullable: false),
                    UProj_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UProj_ModifiedBy = table.Column<int>(nullable: true),
                    UProj_isDeleted = table.Column<bool>(nullable: false),
                    UProj_L1_ManagerId = table.Column<int>(nullable: true),
                    UProj_L2_ManagerId = table.Column<int>(nullable: true),
                    Is_L1_Manager = table.Column<bool>(nullable: true),
                    Is_L2_Manager = table.Column<bool>(nullable: true),
                    ClientprojID = table.Column<int>(nullable: true),
                    TimesheetMode = table.Column<int>(nullable: true),
                    IsDirectManager = table.Column<bool>(nullable: true),
                    isclientcalendar = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProjects", x => x.UProj_UserProjectID);
                });

            migrationBuilder.CreateTable(
                name: "UserSalaryCalculations",
                columns: table => new
                {
                    UserSalaryCalculationsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    HireType = table.Column<int>(nullable: false),
                    VisaType = table.Column<int>(nullable: true),
                    AnnualSalary = table.Column<string>(maxLength: 100, nullable: true),
                    AnnualSalaryPerhour = table.Column<string>(maxLength: 100, nullable: true),
                    PayrollTaxes = table.Column<string>(maxLength: 100, nullable: true),
                    PayrollTaxesPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    H1BFee = table.Column<string>(maxLength: 100, nullable: true),
                    H1BFeePerHour = table.Column<string>(maxLength: 100, nullable: false),
                    GCFee = table.Column<string>(maxLength: 100, nullable: true),
                    GCFeePerHour = table.Column<string>(maxLength: 100, nullable: true),
                    Insurance = table.Column<string>(maxLength: 100, nullable: true),
                    InsurancePerHour = table.Column<string>(maxLength: 100, nullable: true),
                    _2WeeksPaidVocation = table.Column<string>(name: "2WeeksPaidVocation", maxLength: 100, nullable: true),
                    _2WeeksPaidVocationPerHour = table.Column<string>(name: "2WeeksPaidVocationPerHour", maxLength: 100, nullable: true),
                    Holidays = table.Column<string>(maxLength: 100, nullable: true),
                    HolidaysPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    AdministrativeCost = table.Column<string>(maxLength: 100, nullable: true),
                    AdministrativeCostPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    Relocation = table.Column<string>(maxLength: 100, nullable: true),
                    RelocationPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    PaidBench = table.Column<string>(maxLength: 100, nullable: true),
                    PaidBenchPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    Bonus = table.Column<string>(maxLength: 100, nullable: true),
                    BonusPerHour = table.Column<string>(maxLength: 100, nullable: true),
                    Total = table.Column<string>(maxLength: 100, nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSalaryCalculations", x => x.UserSalaryCalculationsId);
                });

            migrationBuilder.CreateTable(
                name: "UsersForProjects",
                columns: table => new
                {
                    Ufp_UsersForProjectsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ufp_ProjectID = table.Column<int>(nullable: false),
                    Ufp_UserID = table.Column<int>(nullable: false),
                    Ufp_StartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ufp_EndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ufp_ParticipationPercentage = table.Column<int>(nullable: true),
                    Ufp_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Ufp_Version = table.Column<short>(nullable: false),
                    Ufp_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Ufp_CreatedBy = table.Column<int>(nullable: false),
                    Ufp_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ufp_ModifiedBy = table.Column<int>(nullable: true),
                    Ufp_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersForProjects", x => x.Ufp_UsersForProjectsID);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Usr_SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usr_UserId = table.Column<int>(nullable: true),
                    SkillId = table.Column<int>(nullable: true),
                    Experience = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Usk_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Usk_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(nullable: true),
                    StatusID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserSkil__0F63F579B4A24B6C", x => x.Usr_SkillId);
                });

            migrationBuilder.CreateTable(
                name: "UserSocialMediaProfiles",
                columns: table => new
                {
                    SocialMediaProfileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usmp_UserID = table.Column<int>(nullable: true),
                    Usmp_SocialMediaId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Usmp_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Usmp_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserSoci__8FA5D461EA07862D", x => x.SocialMediaProfileId);
                });

            migrationBuilder.CreateTable(
                name: "UserTitle",
                columns: table => new
                {
                    Usr_Titleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitlePrefix = table.Column<string>(unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    Acc_AccountID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserTitl__080E05F5480473AA", x => x.Usr_Titleid);
                });

            migrationBuilder.CreateTable(
                name: "UserworkfromHome",
                columns: table => new
                {
                    UserwfhID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usrl_UserId = table.Column<int>(nullable: true),
                    UserwfhStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    UserwfhEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    Tot_No_Days = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(unicode: false, maxLength: 500, nullable: true),
                    L_StatusId = table.Column<int>(nullable: true),
                    ApprovedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RejectedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ApprovedBy = table.Column<int>(nullable: true),
                    RejectedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Is_WorkFromHome = table.Column<bool>(nullable: true),
                    OnHoldDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    OnHoldBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Userwork__54F663F2B5D9B125", x => x.UserwfhID);
                });

            migrationBuilder.CreateTable(
                name: "USSalaryComponents",
                columns: table => new
                {
                    USSalaryComponentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USSalaryComponent = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    USSalaryComponentValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    StatusID = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USSalary__93969884811AD992", x => x.USSalaryComponentID);
                });

            migrationBuilder.CreateTable(
                name: "VisaType",
                columns: table => new
                {
                    VisaTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisaType = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    VisaTypeShortForm = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    StatusID = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisaType", x => x.VisaTypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbo.AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewCandidate",
                columns: table => new
                {
                    ICID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    Emailid = table.Column<string>(maxLength: 200, nullable: true),
                    MobileNo = table.Column<string>(maxLength: 100, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    Assessment_For_Positionid = table.Column<int>(nullable: true),
                    RecrutementUserid = table.Column<int>(nullable: true),
                    AssessmentDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    status = table.Column<bool>(nullable: true),
                    AssessmentTime = table.Column<string>(unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Intervie__B83FFBFD931BE40A", x => x.ICID);
                    table.ForeignKey(
                        name: "FK__Interview__Asses__40E497F3",
                        column: x => x.Assessment_For_Positionid,
                        principalTable: "Assessment_For_Position",
                        principalColumn: "APID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Issuetypes",
                columns: table => new
                {
                    ITID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Issuetyp__44B161D3328D0945", x => x.ITID);
                    table.ForeignKey(
                        name: "FK__Issuetype__Depar__253C7D7E",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TypeOfIssue = table.Column<int>(nullable: true),
                    Ticket_raise_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ticket_Forecast_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Ticket_Closed_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    ClosedBy = table.Column<int>(nullable: true),
                    Priority = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tickets__C456D7292D1F1771", x => x.TID);
                    table.ForeignKey(
                        name: "FK__Tickets__Departm__2A01329B",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketsAuthority",
                columns: table => new
                {
                    TAID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentID = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TicketsA__B43FE34A917C2860", x => x.TAID);
                    table.ForeignKey(
                        name: "FK__TicketsAu__Depar__226010D3",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "Did",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientProjects",
                columns: table => new
                {
                    CL_ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proj_ProjectID = table.Column<int>(nullable: true),
                    Accountid = table.Column<int>(nullable: true),
                    ClientProjTitle = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    ClientProjDesc = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ClientPr__E0AE9254C5F91DFC", x => x.CL_ProjectID);
                    table.ForeignKey(
                        name: "FK_ClientProjects_Projects",
                        column: x => x.Proj_ProjectID,
                        principalTable: "Projects",
                        principalColumn: "Proj_ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interview_Position_TechnologyStack",
                columns: table => new
                {
                    IPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyStack_Id = table.Column<int>(nullable: true),
                    Assessment_For_Position_Positionid = table.Column<int>(nullable: true),
                    No_of_Questions = table.Column<int>(nullable: true),
                    Assessment_TimePeriod_in_sec = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Intervie__8FB9622A822696FD", x => x.IPID);
                    table.ForeignKey(
                        name: "FK__Interview__Asses__3A379A64",
                        column: x => x.Assessment_For_Position_Positionid,
                        principalTable: "Assessment_For_Position",
                        principalColumn: "APID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Interview__Techn__3B2BBE9D",
                        column: x => x.TechnologyStack_Id,
                        principalTable: "TechnologyStack",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionBank",
                columns: table => new
                {
                    QBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TechnologyStackId = table.Column<int>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Option1 = table.Column<string>(nullable: true),
                    Option2 = table.Column<string>(nullable: true),
                    Option3 = table.Column<string>(nullable: true),
                    Option4 = table.Column<string>(nullable: true),
                    Answer = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Question__DFE79DB903BD6685", x => x.QBID);
                    table.ForeignKey(
                        name: "FK__QuestionB__Techn__3572E547",
                        column: x => x.TechnologyStackId,
                        principalTable: "TechnologyStack",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttachmentsinTimesheets",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeSheetID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    UploadedImages = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Attachme__442C64BEAE69C5B7", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK__Attachmen__TimeS__06ED0088",
                        column: x => x.TimeSheetID,
                        principalTable: "TIMESHEET",
                        principalColumn: "TimesheetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CandidateInterviewResult",
                columns: table => new
                {
                    CIRID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Candidateid = table.Column<int>(nullable: true),
                    Questionid = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    SelectedOption = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true),
                    Descriptionforoptionchoosen = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Candidat__A365994851A9DF71", x => x.CIRID);
                    table.ForeignKey(
                        name: "FK__Candidate__Candi__469D7149",
                        column: x => x.Candidateid,
                        principalTable: "InterviewCandidate",
                        principalColumn: "ICID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TicketImages",
                columns: table => new
                {
                    TIID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(maxLength: 200, nullable: true),
                    TicketId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TicketIm__B6FF654E41036C8E", x => x.TIID);
                    table.ForeignKey(
                        name: "FK__TicketIma__Ticke__2CDD9F46",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HolidayCalendar",
                columns: table => new
                {
                    HolidayCalendarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(nullable: false),
                    HolidayName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    HolidayDate = table.Column<DateTime>(type: "date", nullable: false),
                    isOptionalHoliday = table.Column<bool>(nullable: false),
                    isActive = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    ModifiedBy = table.Column<int>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "date", nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    ProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HolidayCalendar", x => x.HolidayCalendarID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Rol_RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol_AccountID = table.Column<int>(nullable: false),
                    Rol_RoleCode = table.Column<string>(maxLength: 250, nullable: true),
                    Rol_RoleName = table.Column<int>(nullable: true),
                    Rol_RoleDescription = table.Column<string>(maxLength: 500, nullable: true),
                    Rol_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Rol_Version = table.Column<int>(nullable: false),
                    Rol_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Rol_createdBy = table.Column<int>(nullable: false),
                    Rol_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Rol_ModifiedBy = table.Column<int>(nullable: true),
                    Rol_isDeleted = table.Column<bool>(nullable: false),
                    IsManagerRole = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master_Role", x => x.Rol_RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Usr_UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usr_AccountID = table.Column<int>(nullable: false),
                    Usr_UserTypeID = table.Column<int>(nullable: false),
                    Usr_RoleID = table.Column<int>(nullable: false),
                    Usr_Username = table.Column<string>(maxLength: 50, nullable: true),
                    Usr_LoginId = table.Column<string>(maxLength: 100, nullable: false),
                    Usr_Password = table.Column<string>(maxLength: 200, nullable: false),
                    Usr_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Usr_TaskID = table.Column<int>(nullable: true),
                    Usr_Version = table.Column<short>(nullable: false),
                    Usr_salt = table.Column<string>(nullable: true),
                    Usr_Manager = table.Column<int>(nullable: true),
                    Usr_Manager2 = table.Column<int>(nullable: true),
                    Usr_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Usr_CreatedBy = table.Column<int>(nullable: true),
                    Usr_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Usr_ModifiedBy = table.Column<int>(nullable: true),
                    Usr_isDeleted = table.Column<bool>(nullable: false),
                    Url_token = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master_User", x => x.Usr_UserID);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Acc_AccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acc_AccountCode = table.Column<string>(maxLength: 50, nullable: false),
                    Acc_AccountName = table.Column<string>(maxLength: 100, nullable: false),
                    Acc_AccountDescription = table.Column<string>(nullable: true),
                    Acc_EmailID = table.Column<string>(maxLength: 100, nullable: true),
                    Acc_MobileNumber = table.Column<string>(maxLength: 100, nullable: true),
                    Acc_PhoneNumber = table.Column<string>(maxLength: 100, nullable: true),
                    Acc_CompanyLogo = table.Column<string>(maxLength: 200, nullable: true),
                    Acc_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    Acc_Version = table.Column<short>(nullable: false),
                    Acc_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    Acc_CreatedBy = table.Column<int>(nullable: false),
                    Acc_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Acc_ModifiedBy = table.Column<int>(nullable: true),
                    Acc_isDeleted = table.Column<bool>(nullable: false),
                    is_UsAccount = table.Column<bool>(nullable: false),
                    is_pre_requisite = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Acc_AccountID);
                    table.ForeignKey(
                        name: "FK_Account_Acc_CreatedBy",
                        column: x => x.Acc_CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Usr_UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersProfile",
                columns: table => new
                {
                    UsrP_UserProfileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsrP_UserID = table.Column<int>(nullable: false),
                    UsrP_FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    UsrP_LastName = table.Column<string>(maxLength: 100, nullable: false),
                    UsrP_EmployeeID = table.Column<string>(maxLength: 100, nullable: true),
                    UsrP_EmailID = table.Column<string>(maxLength: 100, nullable: true),
                    Usrp_MobileNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Usrp_CountryCode = table.Column<int>(nullable: true),
                    Usrp_ProfilePicture = table.Column<string>(maxLength: 200, nullable: true),
                    UsrP_DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsrP_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    UsrP_Version = table.Column<short>(nullable: false),
                    UsrP_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UsrP_CreatedBy = table.Column<int>(nullable: false),
                    UsrP_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsrP_ModifiedBy = table.Column<int>(nullable: true),
                    UsrP_isDeleted = table.Column<bool>(nullable: false),
                    Usr_Titleid = table.Column<int>(nullable: true),
                    Usr_GenderId = table.Column<int>(nullable: true),
                    Marital_Status = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    PermanentAddress = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    TemporaryAddress = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    passcode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Usrp_DOJ = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProfile", x => x.UsrP_UserProfileID);
                    table.ForeignKey(
                        name: "FK_UsersProfile_Master_User1",
                        column: x => x.UsrP_UserID,
                        principalTable: "Users",
                        principalColumn: "Usr_UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UsT_UserTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsT_AccountID = table.Column<int>(nullable: false),
                    UsT_UserTypeCode = table.Column<string>(maxLength: 50, nullable: false),
                    UsT_UserType = table.Column<string>(maxLength: 100, nullable: false),
                    UsT_UserTypeDescription = table.Column<string>(maxLength: 500, nullable: true),
                    UsT_ActiveStatus = table.Column<bool>(nullable: false, defaultValueSql: "((1))"),
                    UsT_Version = table.Column<int>(nullable: false),
                    UsT_CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    UsT_CreatedBy = table.Column<int>(nullable: false),
                    UsT_ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsT_ModifiedBy = table.Column<int>(nullable: true),
                    UsT_isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UsT_UserTypeID);
                    table.ForeignKey(
                        name: "FK_UserType_AccountID",
                        column: x => x.UsT_AccountID,
                        principalTable: "Account",
                        principalColumn: "Acc_AccountID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_Acc_CreatedBy",
                table: "Account",
                column: "Acc_CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AttachmentsinTimesheets_TimeSheetID",
                table: "AttachmentsinTimesheets",
                column: "TimeSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateInterviewResult_Candidateid",
                table: "CandidateInterviewResult",
                column: "Candidateid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientProjects_Proj_ProjectID",
                table: "ClientProjects",
                column: "Proj_ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayCalendar_AccountID",
                table: "HolidayCalendar",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayCalendar_CreatedBy",
                table: "HolidayCalendar",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_HolidayCalendar_ModifiedBy",
                table: "HolidayCalendar",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_Position_TechnologyStack_Assessment_For_Position_Positionid",
                table: "Interview_Position_TechnologyStack",
                column: "Assessment_For_Position_Positionid");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_Position_TechnologyStack_TechnologyStack_Id",
                table: "Interview_Position_TechnologyStack",
                column: "TechnologyStack_Id");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewCandidate_Assessment_For_Positionid",
                table: "InterviewCandidate",
                column: "Assessment_For_Positionid");

            migrationBuilder.CreateIndex(
                name: "IX_Issuetypes_DepartmentID",
                table: "Issuetypes",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionBank_TechnologyStackId",
                table: "QuestionBank",
                column: "TechnologyStackId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Rol_AccountID",
                table: "Roles",
                column: "Rol_AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketImages_TicketId",
                table: "TicketImages",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DepartmentID",
                table: "Tickets",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketsAuthority_DepartmentID",
                table: "TicketsAuthority",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Usr_AccountID",
                table: "Users",
                column: "Usr_AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Usr_UserTypeID",
                table: "Users",
                column: "Usr_UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProfile_UsrP_UserID",
                table: "UsersProfile",
                column: "UsrP_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserType_UsT_AccountID",
                table: "UserType",
                column: "UsT_AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK__HolidayCa__Creat__7E37BEF6",
                table: "HolidayCalendar",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Usr_UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__HolidayCa__Modif__7F2BE32F",
                table: "HolidayCalendar",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Usr_UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__HolidayCa__Accou__7D439ABD",
                table: "HolidayCalendar",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "Acc_AccountID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_AccountID",
                table: "Roles",
                column: "Rol_AccountID",
                principalTable: "Account",
                principalColumn: "Acc_AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AccountID",
                table: "Users",
                column: "Usr_AccountID",
                principalTable: "Account",
                principalColumn: "Acc_AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypeID",
                table: "Users",
                column: "Usr_UserTypeID",
                principalTable: "UserType",
                principalColumn: "UsT_UserTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Acc_CreatedBy",
                table: "Account");

            migrationBuilder.DropTable(
                name: "__MigrationHistory");

            migrationBuilder.DropTable(
                name: "Acc_Spec_OptionalHolidays");

            migrationBuilder.DropTable(
                name: "AccountClients");

            migrationBuilder.DropTable(
                name: "AccountDepartments");

            migrationBuilder.DropTable(
                name: "AccountSocialMediaProfiles");

            migrationBuilder.DropTable(
                name: "AccountSpecificTasks");

            migrationBuilder.DropTable(
                name: "AlexaDevices");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AttachmentsinTimesheets");

            migrationBuilder.DropTable(
                name: "CandidateInterviewResult");

            migrationBuilder.DropTable(
                name: "ClientProjects");

            migrationBuilder.DropTable(
                name: "ClientProjectsTasks");

            migrationBuilder.DropTable(
                name: "ClientsBusiness");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "ComponentType");

            migrationBuilder.DropTable(
                name: "ContentType");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "EmployeeBankDetails");

            migrationBuilder.DropTable(
                name: "EmployeeSalaryComponent");

            migrationBuilder.DropTable(
                name: "EmployeeSalarySlips");

            migrationBuilder.DropTable(
                name: "EmployeeSalaryStructure");

            migrationBuilder.DropTable(
                name: "EmployeeSalaryStructureDetails");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "FinancialYear");

            migrationBuilder.DropTable(
                name: "GenericRoles");

            migrationBuilder.DropTable(
                name: "GenericTasks");

            migrationBuilder.DropTable(
                name: "HireType");

            migrationBuilder.DropTable(
                name: "History_Account");

            migrationBuilder.DropTable(
                name: "History_LeaveComments");

            migrationBuilder.DropTable(
                name: "History_LeaveScheme");

            migrationBuilder.DropTable(
                name: "History_LeaveType");

            migrationBuilder.DropTable(
                name: "History_Projects");

            migrationBuilder.DropTable(
                name: "History_Role");

            migrationBuilder.DropTable(
                name: "History_UserProjects");

            migrationBuilder.DropTable(
                name: "History_Users");

            migrationBuilder.DropTable(
                name: "History_UserType");

            migrationBuilder.DropTable(
                name: "History_WFHComments");

            migrationBuilder.DropTable(
                name: "HolidayCalendar");

            migrationBuilder.DropTable(
                name: "Interview_Position_TechnologyStack");

            migrationBuilder.DropTable(
                name: "Issuetypes");

            migrationBuilder.DropTable(
                name: "LeaveScheme");

            migrationBuilder.DropTable(
                name: "LeaveStatus");

            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.DropTable(
                name: "Master_Module");

            migrationBuilder.DropTable(
                name: "Master_Sub_Module");

            migrationBuilder.DropTable(
                name: "Master_TimesheetMode");

            migrationBuilder.DropTable(
                name: "MobileNotificationTemplate");

            migrationBuilder.DropTable(
                name: "ModuleAccessType");

            migrationBuilder.DropTable(
                name: "NewsBoard");

            migrationBuilder.DropTable(
                name: "NobleLeadData_AIU");

            migrationBuilder.DropTable(
                name: "NobleLeadData_CTU");

            migrationBuilder.DropTable(
                name: "PayMode");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Project_workstatus");

            migrationBuilder.DropTable(
                name: "ProjectPhases");

            migrationBuilder.DropTable(
                name: "ProjectSpecificTasks");

            migrationBuilder.DropTable(
                name: "QuestionBank");

            migrationBuilder.DropTable(
                name: "RequestMessages");

            migrationBuilder.DropTable(
                name: "RoleModules");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SalarySlipDetails");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "STEP1");

            migrationBuilder.DropTable(
                name: "SubPolicy");

            migrationBuilder.DropTable(
                name: "SubPolicyDocument");

            migrationBuilder.DropTable(
                name: "TaskDetails");

            migrationBuilder.DropTable(
                name: "TicketImages");

            migrationBuilder.DropTable(
                name: "TicketPriority");

            migrationBuilder.DropTable(
                name: "TicketsAuthority");

            migrationBuilder.DropTable(
                name: "Timesheet_Comments");

            migrationBuilder.DropTable(
                name: "UserDevicesToken");

            migrationBuilder.DropTable(
                name: "UserGender");

            migrationBuilder.DropTable(
                name: "UserLeaves");

            migrationBuilder.DropTable(
                name: "UserLeaveTypeConsumed");

            migrationBuilder.DropTable(
                name: "UserProjectEngagement");

            migrationBuilder.DropTable(
                name: "UserProjects");

            migrationBuilder.DropTable(
                name: "UserSalaryCalculations");

            migrationBuilder.DropTable(
                name: "UsersForProjects");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "UserSocialMediaProfiles");

            migrationBuilder.DropTable(
                name: "UsersProfile");

            migrationBuilder.DropTable(
                name: "UserTitle");

            migrationBuilder.DropTable(
                name: "UserworkfromHome");

            migrationBuilder.DropTable(
                name: "USSalaryComponents");

            migrationBuilder.DropTable(
                name: "VisaType");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TIMESHEET");

            migrationBuilder.DropTable(
                name: "InterviewCandidate");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "TechnologyStack");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Assessment_For_Position");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropSequence(
                name: "CreatePasscode");

            migrationBuilder.DropSequence(
                name: "ProjectCode");

            migrationBuilder.DropSequence(
                name: "RoleModuleID");
        }
    }
}
