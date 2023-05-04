using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;


    public void Move(Vector2 moveDir)
    {
        transform.Translate(moveDir * speed * Time.deltaTime);
    }
}