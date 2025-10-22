using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float movementSpeed;
    public float playerJump;
    private Rigidbody playerRB;
    //private bool isPlayerGrounded;

    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        //isPlayerGrounded = true;
    }

    void Update()
    {

        //For Straight, Back, Left and Right movements:
        if (Input.GetKey(KeyCode.W))
        {
            playerRB.position += Vector3.back * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playerRB.position += Vector3.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerRB.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerRB.position += Vector3.left * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector3.up * playerJump, ForceMode.Impulse);
        }

    }

}
