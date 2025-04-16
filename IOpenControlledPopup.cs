namespace WindowsGenericPopups.CoreLibrary;
public interface IOpenControlledPopup
{
    /// <summary>
    /// Opens a popup with the given message and display mode.
    /// Returns a handle that the caller must use to close it.
    /// </summary>
    IControlledPopupInstance OpenPopup(string message, EnumTimePopupDisplayMode mode = EnumTimePopupDisplayMode.Toast);
}