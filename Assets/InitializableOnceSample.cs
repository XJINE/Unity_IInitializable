using UnityEngine;

public class InitializableOnceSample : MonoBehaviour
{
    #region Field

    public InitializableOnce initializableOnce;

    #endregion Field

    #region Method

    protected virtual void Awake()
    {
        DebugLog();
        this.initializableOnce.Initialize();
        DebugLog();
    }

    protected void DebugLog()
    {
        Debug.Log(this.initializableOnce.IsInitialized ? "INITIALIZED" : "NOT INITIALIZED");
    }

    #endregion Method
}