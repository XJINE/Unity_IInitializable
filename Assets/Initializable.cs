using UnityEngine;

public class Initializable : MonoBehaviour, IInitializable
{
    #region Property

    public bool IsInitialized { get; protected set; }

    #endregion Property

    #region Method

    protected virtual void Awake()
    {
        Initialize();
    }

    public virtual bool Initialize()
    {
        if (this.IsInitialized)
        {
            return false;
        }

        this.IsInitialized = true;

        // NOTE:
        // Add your initialize code.

        return true;
    }

    #endregion Method
}