using UnityEngine;

public class ToggleBubbleState : MonoBehaviour {
    private GameObject parent;
    private GameObject childGO1;
    private GameObject childGO2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        parent = GameObject.Find("Parent GameObject");
        childGO1 = GameObject.Find("Parent GameObject/Child GameObject1");
        childGO2 = GameObject.Find("Parent GameObject/Child GameObject2");
        if(childGO1 != null) {
            Debug.Log("Child GameObject1 found from Button!");
        }
        if(childGO2 != null) {
            Debug.Log("Child GameObject2 found from Button!");
        }

        childGO2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     toggleBubble(childGO1, childGO2);   
    }

    public void toggleBubble(GameObject childGO1, GameObject childGO2) {
        if(Input.GetKeyDown(KeyCode.Alpha1) && childGO1 != null && childGO2 != null) {
            childGO1.SetActive(true);
            childGO2.SetActive(false);
        } else if(Input.GetKeyDown(KeyCode.Alpha2) && childGO1 != null && childGO2 != null) {
            childGO2.SetActive(true);
            childGO1.SetActive(false);
        }
    }
}