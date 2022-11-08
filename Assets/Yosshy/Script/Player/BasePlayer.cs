using System.Threading.Tasks;
using UnityEngine;

public abstract class BasePlayer : MonoBehaviour
{
    void Awake()
    {
        OnInitialize();
    }


    protected abstract void OnInitialize();
}
