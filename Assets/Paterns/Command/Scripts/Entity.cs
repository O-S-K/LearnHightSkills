using UnityEngine;

public class Entity : MonoBehaviour
{
    public void Idle()
    {
        Debug.Log("Hero is Idle");
    }
    
    public void Run(Vector3 position)
    {
        transform.position = position;
        Debug.Log("Hero is Run " + position);
    }

    public void Attack()
    {
        Debug.Log("Hero is attacking");
    }

    public void Jump()
    {
        Debug.Log("Hero is jumping");
    } 
}