using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject fruitPrefab;
    public GameObject[] fruitPrefabs;
    public int score = 0;
    public TMP_Text scoreText;
    public GameObject playAgainButton;
    public GameObject scoreTextObject;
    public bool gameOver = false;

    /// <summary>
    /// Instantiates the fruit prefab with the given parameters
    /// </summary>
    public GameObject InstantiateFruit(Vector3 position, int id) {
        GameObject combinedFruit = Instantiate(fruitPrefabs[id], position, Quaternion.identity);
        combinedFruit.GetComponent<Fruit>().id = id;
        return combinedFruit;

        
    }

    /// <summary>
    /// Adds score based on the id of the fruit
    /// </summary>
    public void addScore(int id) {
        switch (id) {
            case 0:
                score += 1;
                break;
            case 1:
                score += 3;
                break;
            case 2:
                score += 6;
                break;
            case 3:
                score += 10;
                break;
            case 4:
                score += 15;
                break;
            case 5:
                score += 21;
                break;
            case 6:
                score += 28;
                break;
            case 7:
                score += 36;
                break;
            case 8:
                score += 45;
                break;
            case 9:
                score += 55;
                break;
            case 10:
                score += 66;
                break;
        }
        scoreText.text = "Score: " + score.ToString();
    }

    public void endGame() {
        gameOver = true;
        playAgainButton.SetActive(true);
    }

    public void playAgain() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
