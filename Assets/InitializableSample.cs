using UnityEngine;

public class InitializableSample : MonoBehaviour
{
    #region Field

    public Initializable initializable;

    #endregion Field

    #region Method

    protected virtual void Awake()
    {
        DebugLog();
        this.initializable.Initialize();
        DebugLog();
    }

    protected void DebugLog()
    {
        Debug.Log(this.initializable.IsInitialized ? "INITIALIZED" : "NOT INITIALIZED");
    }

    #endregion Method
}