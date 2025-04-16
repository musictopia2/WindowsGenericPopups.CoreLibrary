namespace WindowsGenericPopups.CoreLibrary;
public partial class ButtonClosePopupComponent
{
    public static string Message { get; set; } = "";
    public static Action? OnButtonClicked { get; set; } //wpf would call into this to close whatever window it is.
    //if a hotkey does it and use the same one, then this should not care.
    private Task CloseAsync()
    {
        if (OnButtonClicked is null)
        {
            throw new CustomBasicException("No button click");
        }
        OnButtonClicked?.Invoke();
        return Task.CompletedTask;
    }
}