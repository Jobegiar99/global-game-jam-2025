using UnityEngine;
using System.Collections;

public class ToggleObjectActive : MonoBehaviour
{
    [SerializeField]private GameObject[] gameObjects;

    public void ToggleActive([SerializeField]int index) {
        foreach(GameObject gObject in gameObjects) {
            if(gObject.activeSelf == true) {
                gObject.SetActive(false);
                break;
            }
        }    

        gameObjects[index].SetActive(true);
    }

}
