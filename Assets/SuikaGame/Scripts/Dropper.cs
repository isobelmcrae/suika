using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// import fruit.cs


// have the dropper follow the mouse 
// when the player clicks, instantiate a fruit at the dropper's position (limited one at random of the first 5 small fruits)
public class Dropper : MonoBehaviour
{
    private GameManager game;
    public GameObject currentFruit;
    private bool hasFruit = false;

    // gets game manager
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        // sets the starting fruit to a cherry ALWAYS
        currentFruit = game.InstantiateFruit(this.transform.position, 0);
        currentFruit.GetComponent<Rigidbody2D>().gravityScale = 0;
        
    }

    public void SpawnNewFruit()
    {
        int randomFruit = Random.Range(0, 5);
        currentFruit = game.InstantiateFruit(this.transform.position, randomFruit);
        currentFruit.GetComponent<Rigidbody2D>().gravityScale = 0;
    }   

    

    // Update is called once per frame
    void Update()
    {
        // follows the mouse's position on the x axis, and permanently sets the y and z to 4 and 0 respectively
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (!game.gameOver && mousePos.x < 2.3f && mousePos.x > -2.4f) {
            mousePos.z = 0; // sets z to 0
            mousePos.y = 5; // sets y to 4  
            transform.position = mousePos; // sets dropper position to mouse position
        } 

        if (currentFruit != null && currentFruit.GetComponent<Rigidbody2D>().gravityScale == 0) {
            currentFruit.transform.position = this.transform.position;
        }

        if (!game.gameOver && Input.GetMouseButtonDown(0)) {
            currentFruit.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

}
