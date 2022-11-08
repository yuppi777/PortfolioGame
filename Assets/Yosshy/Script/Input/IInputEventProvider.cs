using UniRx;
using UnityEngine;

public interface IInputEventProvider
{
    IReactiveProperty<bool> Jump { get; }
    IReactiveProperty<bool> Action { get; }
    IReactiveProperty<bool> IsMove { get; }
    IReactiveProperty<Vector3> MoveDirection { get; }
    void OnInitialize();

}
