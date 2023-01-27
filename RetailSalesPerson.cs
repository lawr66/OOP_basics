public class RetailSalesPerson : Salesman, SelfDeveloping
{
   public RetailSalesPerson(string firstName, string lastName) : base(firstName,lastName)
   {
    
   }


    public void Develop()
    {
        Console.WriteLine("I develop myself by watching retail sales training videos");
    }

    protected override void Engage()
    {
        Console.WriteLine("Hello!");
    }

    protected override void EstablishTrust()
    {
        Console.WriteLine("I just wanted to quickly help you.");
    }

    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is 80% discounted.");
    }

    protected override void DemonstrateValue()
    {
        Console.WriteLine("Our customers love it!");
    }

    protected override void Close()
    {
        Console.WriteLine("Buy this pen!");
    }

   /* 
   public override void Sell()
    {
        this.Engage();
        this.EstablishTrust();
        this.AddressConcerns();
        this.DemonstrateValue();
        this.Close();
    }
    */
    

}