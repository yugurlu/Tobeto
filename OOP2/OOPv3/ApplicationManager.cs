using System;
namespace OOPv3
{
	class ApplicationManager
	{
		public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
		{
			creditManager.Calculate();
			foreach (var service in loggerServices)
			{
				service.Log();
			}
		}

		public void Information(List<ICreditManager> credits)
		{
			foreach (var credit in credits)
			{
				credit.Calculate();
			}
		}
	}
}

