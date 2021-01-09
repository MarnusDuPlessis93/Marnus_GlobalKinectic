namespace Api.Interfaces
{
    public interface ICoin
    {
        string CurrencyType { get; set; }
        decimal Amount { get; set; }
        decimal Volume { get; set; }
    }

}
