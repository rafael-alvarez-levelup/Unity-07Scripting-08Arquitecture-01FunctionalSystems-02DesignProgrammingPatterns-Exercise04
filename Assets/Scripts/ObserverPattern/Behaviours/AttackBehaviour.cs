using UnityEngine;

// TODO: Serialize Animator and SetTrigger("Attack")

public class AttackBehaviour : Subject<AttackArgs>, IAttack
{
    [SerializeField] private int damage;

    public void Attack()
    {
        Notify();
    }

    public override void Notify()
    {
        // It won't change, cache
        AttackArgs attackArgs = new AttackArgs(damage);

        foreach (var observer in observers)
        {
            observer.OnNotify(attackArgs);
        }
    }
}