namespace WindowsGenericPopups.CoreLibrary;
public interface IOpenSimplePopup
{
    void OpenPopup(EnumKey closeKey, string message, CancellationToken token = default, Action? onPopupClosed = null); //whoever handles opening needs to use this hotkey to show what will close it.
    //i think whoever invokes this needs to send the message as well.
}