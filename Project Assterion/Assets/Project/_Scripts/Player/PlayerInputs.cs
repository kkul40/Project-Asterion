using UnityEngine;

namespace Project._Scripts.Player
{
    public class PlayerInputs : MonoBehaviour
    {
        private Inputs input;

        public Vector2 LastDirection;
        
        
        private void Start()
        {
            input = new Inputs();
            input.Enable();
        }

        public Vector2 GetMoveDirection()
        {
            var moveDir = input.Player.Movement.ReadValue<Vector2>();
            
            if (moveDir.magnitude != 0)
            {
                LastDirection = moveDir;
                return moveDir;
            }

            return Vector2.zero;
        }
    }
}