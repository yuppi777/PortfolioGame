using UnityEngine;

public abstract class BasePlayer : MonoBehaviour
{
    private void Awake()
    {
        OnInitialize();
    }

    protected abstract void OnInitialize();
}
