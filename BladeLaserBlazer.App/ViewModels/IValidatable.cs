namespace BladeLaserBlazer.App.ViewModels
{
    public interface IValidatable
    {
        bool IsValid { get; }
        string ValidationErrors { get; }
    }
}
