// See https://aka.ms/new-console-template for more information
RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Steve","Rogers");
retailSalesPerson.Sell();

CarSalesman carSalesman = new CarSalesman("Mike","Rogers");
carSalesman.Sell();









/*
CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
Console.WriteLine(steveTheSalesman.FullName);
steveTheSalesman.Sell();
*/
/*RetailSalesPerson erikTheSalesDude = new RetailSalesPerson("Erik", "Erikson");
Console.WriteLine(erikTheSalesDude.FullName);
erikTheSalesDude.Sell();
erikTheSalesDude.Develop();
*/


/*
CarSalesman johnTheSalesman = new CarSalesman("John", "Doe");
Console.WriteLine(johnTheSalesman.FullName);
johnTheSalesman.Sell();
*/

/*
WebDeveloper mike = new WebDeveloper("Angular6");
mike.Code();
mike.Code("C#");
mike.Code("C#","HTML");
mike.Code(null,"HTML");
//mike.Develop();
*/

/*
List<Salesman> salesmen = new List<Salesman>() {new CarSalesman("James", "Weaver"), new CarSalesman("Sue", "McGregor"), new RetailSalesPerson("Delores", "Kirby"), new InsuranceBroker("Josh","Kennedy"), new OnlineMarketer("Robert", "Stone")};

foreach(var item in salesmen)
{
    ShowMeHowToSell(item);
}

List<SelfDeveloping> selfDeveloping = new List<SelfDeveloping>() {new WebDeveloper("C#"), new RetailSalesPerson("Delores", "Kirby")};

foreach(var item in selfDeveloping)
{
    ShowMeHowYouSelfDevelop(item);
}



static void ShowMeHowToSell(Salesman salesman)
{
    /*
    if(salesman is CarSalesman)
    {
        CarSalesman carSalesman = (CarSalesman) salesman;
        carSalesman.Sell();
    }
    else if(salesman is InsuranceBroker)
    {
        InsuranceBroker insuranceBroker = (InsuranceBroker) salesman;
        insuranceBroker.Sell();
    }
    else
    {
        RetailSalesPerson retailSalesPerson = (RetailSalesPerson) salesman;
        retailSalesPerson.Sell();
    }
    */
/*
    salesman.Sell();
}

static void ShowMeHowYouSelfDevelop(SelfDeveloping selfDeveloping)
{
    selfDeveloping.Develop();
}
*/