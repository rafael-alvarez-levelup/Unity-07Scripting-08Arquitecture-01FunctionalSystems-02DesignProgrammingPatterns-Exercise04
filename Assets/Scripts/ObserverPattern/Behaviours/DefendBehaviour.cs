using UnityEngine;

public class DefendBehaviour : Subject<DefendArgs>, IDefend
{
    [SerializeField] private int defence;

    public void Defend()
    {
        Notify();
    }

    public override void Notify()
    {
        DefendArgs defendArgs = new DefendArgs(defence);

        foreach (var observer in observers)
        {
            observer.OnNotify(defendArgs);
        }
    }
}