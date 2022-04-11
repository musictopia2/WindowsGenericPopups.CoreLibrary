namespace WindowsGenericPopups.CoreLibrary;
public interface IAfterCloseSimplePopup
{
    //does not need to be async because the window can close.  does not care what else happens.
    void FinishProcess();
}