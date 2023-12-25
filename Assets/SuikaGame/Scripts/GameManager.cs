using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fruitPrefab;
    public GameObject[] fruitPrefabs;

    /// <summary>
    /// Instantiates the fruit prefab with the given parameters
    /// </summary>
    public GameObject InstantiateFruit(Vector3 position, int id) {
        GameObject combinedFruit = Instantiate(fruitPrefabs[id], position, Quaternion.identity);
        combinedFruit.GetComponent<Fruit>().id = id;
        return combinedFruit;
    }
}
