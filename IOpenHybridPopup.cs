namespace WindowsGenericPopups.CoreLibrary;
public interface IOpenHybridPopup : IOpenButtonPopup
{
    //for this one, a person has a choice to either use a key or click a button.
    //refer to the reminders for clicking the button for ideas.
    Task OpenPopupAsync(EnumKey closeKey, string message); //whoever handles opening needs to use this hotkey to show what will close it.
}