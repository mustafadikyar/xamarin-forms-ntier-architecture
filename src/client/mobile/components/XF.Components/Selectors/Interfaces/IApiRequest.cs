namespace XF.Components.Selectors.Interfaces
{
    public interface IApiRequest<out T>
    {
        string BaseApiAddress { get; set; }
        T Speculative { get; }
        T UserInitiated { get; }
        T Background { get; }
    }
}