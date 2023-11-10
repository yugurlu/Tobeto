
using OOPv3;

ICreditManager personalCreditManager = new PersonalCreditManager();
//personalCreditManager.Calculate();

ICreditManager vehicleCreditManager = new VehicleCreditManager();
//vehicleCreditManager.Calculate();

ICreditManager housingCreditManager = new HousingCreditManager();
//housingCreditManager.Calculate();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggerServices = new List<ILoggerService>() { smsLoggerService, databaseLoggerService };

ApplicationManager applicationManager = new ApplicationManager();
applicationManager.MakeApplication(personalCreditManager, loggerServices);

List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, vehicleCreditManager };

//applicationManager.Information(credits);
