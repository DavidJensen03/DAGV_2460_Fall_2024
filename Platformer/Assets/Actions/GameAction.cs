using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Actions/Game Action")]
public class GameAction : ScriptableObject
{
    public UnityAction raise;
    public void RaiseAction()
    {
        raise?.Invoke();
    }
}