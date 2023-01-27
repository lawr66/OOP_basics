public class OnlineMarketer : Salesman
{
   public OnlineMarketer(string firstName, string lastName) : base(firstName,lastName)
   {
    
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
        Console.WriteLine("Buy this online product!");
    }

    public void Develop()
    {
        Console.WriteLine("I develop myself by watching retail sales training videos");
    }
}