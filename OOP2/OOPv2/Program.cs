
using OOPv2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.Name = "Yusuf";
customer1.Surname = "Ugurlu";
customer1.TCKN = "11111111111";
customer1.CustomerNum = "123A1";

CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNum = "124A1";
customer2.TaxNum = "24567247603";
customer2.CompanyName = "Kodlama.io";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer(); //casting

CustomerManager customerManager = new CustomerManager();

customerManager.Add(customer3);
customerManager.Add(customer4);

