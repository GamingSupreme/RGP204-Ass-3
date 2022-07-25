using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    public float timeBetweenShots;
    public GameObject laserBlastPrefab; //change this goddamn line when the assets are ready
    public Transform firePoint;
    private Vector2 leftStickInput;
    private Vector2 rightStickInput;
    private Vector2 mouseInput;
    private bool canShoot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerInput();
    }

    //Get mouse input to work later?
    private void GetPlayerInput()
    {
        leftStickInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rightStickInput = new Vector2(Input.GetAxis("R_Horizontal"), Input.GetAxis("R_Vertical"));
        mouseInput = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
    }

    private void Shoot()
    {
        canShoot=false;
        Instantiate(laserBlastPrefab, firePoint.position, transform.rotation);
        StartCoroutine(ShotCooldown());
    }

    IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(timeBetweenShots);
        canShoot = true;
    }

    //mouse input should get character to look towards cursor, shooting afterwards. Shooting is automagic
    private void FixedUpdate()
    {
        Vector2 curMovement = leftStickInput * playerSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + curMovement);

        if(rightStickInput.magnitude > 0f)
        {
            Vector3 curRotation = Vector3.left * rightStickInput.x + Vector3.up * rightStickInput.y;
            _ = mouseInput;
            Quaternion playerRotation = Quaternion.LookRotation(curRotation, Vector3.forward);

            rb.SetRotation(playerRotation);

            if (canShoot){
                Shoot();
            }
        }
    }
}
