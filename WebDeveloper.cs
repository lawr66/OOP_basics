public class WebDeveloper : Developer, SelfDeveloping
{
    public WebDeveloper(string _mainDevLanguage) : base(_mainDevLanguage)
    {
    }

        public void Develop()
    {
        Console.WriteLine("I develop myself by watching Udemy web development courses");
    }
}