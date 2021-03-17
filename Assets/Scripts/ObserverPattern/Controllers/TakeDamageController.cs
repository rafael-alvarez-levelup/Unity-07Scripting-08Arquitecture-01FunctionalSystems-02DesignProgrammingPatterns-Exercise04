using UnityEngine;

public class TakeDamageController : MonoBehaviour, IObserver<AttackArgs>
{
    [SerializeField] private GameObject target;

    private ISubject<AttackArgs> subject;

    private void Awake()
    {
        subject = target.GetComponent<ISubject<AttackArgs>>();
    }

    private void OnEnable()
    {
        subject.Add(this);
    }

    private void OnDisable()
    {
        subject.Remove(this);
    }

    public void OnNotify(AttackArgs param)
    {
        // TODO: Implement damage taken.
        print($"{gameObject.name} received {param.damage} damage!");
    }
}