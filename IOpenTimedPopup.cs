namespace WindowsGenericPopups.CoreLibrary;
public interface IOpenTimedPopup
{
    Task OpenPopupAsync(string message, int milliseconds, EnumTimePopupDisplayMode mode = EnumTimePopupDisplayMode.Toast);
}