public abstract class Developer
{
    private string _mainDevLanguage;

    public Developer(string _mainDevLanguage)
    {
        this._mainDevLanguage = _mainDevLanguage;
    }

    public virtual void Code()
    {
        Console.WriteLine(string.Format("I am coding using my main dev lagnuage, {0}", this._mainDevLanguage));

    }
        public virtual void Code(string extraaDevLanguage)
    {
        Console.WriteLine(string.Format("I am coding using my main dev lagnuage, {0}. Additionaly, I am using {1} as extra dev language", this._mainDevLanguage, extraaDevLanguage));
    }
    public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLagnuage)
    {
        Console.WriteLine(string.Format("I am coding using my main dev lagnuage, {0}. Additionaly, I am using {1} and {2} as extra dev languages", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLagnuage));
    }

}