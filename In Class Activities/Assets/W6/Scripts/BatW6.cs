using UnityEngine;
using UnityEngine.AI;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private int _speed = 5;

    [SerializeField] Transform target;

    public void StartChase()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
    }

    public void StopChase()
    {
        
    }
}

    