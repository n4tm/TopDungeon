using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        private float inputHorizontal;
        private float inputVertical;
        private Transform playerSprite;
        [SerializeField] private float speed;
        private Rigidbody2D rig;
        private BoxCollider2D boxCol;

        private void Start()
        {
            playerSprite = gameObject.transform.GetChild(0).GetComponent<Transform>();
            rig = GetComponent<Rigidbody2D>();
            boxCol = GetComponent<BoxCollider2D>();
        }

        private void FixedUpdate()
        {
            inputHorizontal = Input.GetAxisRaw("Horizontal");
            inputVertical = Input.GetAxisRaw("Vertical");

            if (inputHorizontal > 0.1) playerSprite.eulerAngles = new Vector3(0, 0, 0);
            else if (inputHorizontal < -0.1) playerSprite.eulerAngles = new Vector3(0, 180, 0);
            
            rig.velocity = new Vector2(inputHorizontal * speed,
                inputVertical * speed);
        }
    }
}
