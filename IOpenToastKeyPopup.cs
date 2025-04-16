namespace WindowsGenericPopups.CoreLibrary;
public interface IOpenToastKeyPopup
{
    Task OpenPopupAsync(EnumKey closeKey, string message);
}