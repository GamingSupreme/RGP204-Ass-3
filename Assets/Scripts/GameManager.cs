using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This Tracks the traps and children, uses input to spawn in traps and children and also detects collision
/// 
/// NEED TO DOS
/// i still need to fix the collision between children and traps, theyre both tagged but i forgot the syntax so im
/// still trial and erroring stuff
/// 
/// ALSO
/// the children need to spawn at randomly generated times but i have it so they spawn with player input at the moment
/// </summary>
public class GameManager : MonoBehaviour
{
    //uses the prefabs as a base for the children and trap
    public GameObject Trap;
    public GameObject Child1;
    public GameObject Child2;
    public GameObject Child3;
    public GameObject Child4;

    //lists of children and traps in the scnene
    public Transform ChildList;
    public Transform TrapList;

    public Camera PlayerCamera;

    //headers used in the heirachy to help with visual appeal
    public List<GameObject> Children;
    public List<GameObject> Traps;

    public Vector3 worldPosition;
    bool spawned = false;
    float Height;
    float Width;

    private void Start()
    {
        //instantiate the player camera as the main camera
        PlayerCamera = Camera.main;

        Height = PlayerCamera.orthographicSize + 1;
        Width = PlayerCamera.orthographicSize * PlayerCamera.aspect + 1;
    }

    void PlaceTrap(Vector3 worldPos)
    {
        //checks for player input then spawns a trap at the mouse location
        if (Input.GetKeyDown(KeyCode.A) && (worldPos.y < -2))
        {
            GameObject placeTrap = Instantiate(Trap, worldPos, Quaternion.identity);
            placeTrap.transform.position += new Vector3(0, 0, 1);
            placeTrap.transform.SetParent(TrapList);
            Traps.Add(placeTrap);
        }
    }

    void SpawnChild(float width, float height)
    {
        //the camera position is used to spawn the children anywhere inside the scene and 1 unit oputside the scene using random range
        //id like its so they could only spawn at the max or the min not anything inbetween but i forgot how to do that
        int randNumber = Random.Range(1, 5);
        if (randNumber == 1)
        {
            randNumber = Random.Range(1, 3);
            if (randNumber == 1)
            {
                GameObject spawnedChild = Instantiate(Child1, new Vector3(PlayerCamera.transform.position.x + width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
            else if (randNumber == 2)
            {
                GameObject spawnedChild = Instantiate(Child1, new Vector3(PlayerCamera.transform.position.x + -width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
            
        }
        if (randNumber == 2)
        {
            randNumber = Random.Range(1, 3);
            if (randNumber == 1)
            {
                GameObject spawnedChild = Instantiate(Child2, new Vector3(PlayerCamera.transform.position.x + width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
            else if (randNumber == 2)
            {
                GameObject spawnedChild = Instantiate(Child2, new Vector3(PlayerCamera.transform.position.x + -width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
        }
        if (randNumber == 3)
        {
            randNumber = Random.Range(1, 3);
            if (randNumber == 1)
            {
                GameObject spawnedChild = Instantiate(Child3, new Vector3(PlayerCamera.transform.position.x + width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
            else if (randNumber == 2)
            {
                GameObject spawnedChild = Instantiate(Child3, new Vector3(PlayerCamera.transform.position.x + -width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
        }
        if (randNumber == 4)
        {
            randNumber = Random.Range(1, 3);
            if (randNumber == 1)
            {
                GameObject spawnedChild = Instantiate(Child4, new Vector3(PlayerCamera.transform.position.x + width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
            else if (randNumber == 2)
            {
                GameObject spawnedChild = Instantiate(Child4, new Vector3(PlayerCamera.transform.position.x + -width, -2.50f, 0), Quaternion.identity);
                spawnedChild.transform.SetParent(ChildList);
                Children.Add(spawnedChild);
            }
        }
    }

    private IEnumerator SpawnKids(float width, float height)
    {
        yield return new WaitForSeconds(5.0f);
        spawned = false;
        SpawnChild(width, height);
    }

    void Update()
    {
        //gets the vector three position of the mouse in the scene
        worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //checks if these functions need to be called
        if (!spawned)
        {
            spawned = true;
            StartCoroutine(SpawnKids(Width, Height));
        }
        PlaceTrap(worldPosition);
    }
}
