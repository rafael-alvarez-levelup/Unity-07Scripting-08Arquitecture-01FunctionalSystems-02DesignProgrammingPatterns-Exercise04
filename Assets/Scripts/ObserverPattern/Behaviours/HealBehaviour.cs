using UnityEngine;

public class HealBehaviour : Subject<HealArgs>, IHeal
{
    [SerializeField] private int healing;

    public void Heal()
    {
        Notify();
    }

    public override void Notify()
    {
        HealArgs healArgs = new HealArgs(healing);

        foreach (var observer in observers)
        {
            observer.OnNotify(healArgs);
        }
    }
}