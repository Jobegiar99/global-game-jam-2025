using UnityEngine;

public class ToggleBubbleState : MonoBehaviour {
    [SerializeField]private GameObject gameObject1;
    [SerializeField]private GameObject gameObject2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     toggleBubble(gameObject1, gameObject2);   
    }

    public void toggleBubble(GameObject gameObject1, GameObject gameObject2) {
        if(Input.GetKeyDown(KeyCode.Alpha1) && gameObject1 != null && gameObject2 != null) {
            gameObject1.SetActive(true);
            gameObject2.SetActive(false);
        } else if(Input.GetKeyDown(KeyCode.Alpha2) && gameObject1 != null && gameObject2 != null) {
            gameObject2.SetActive(true);
            gameObject1.SetActive(false);
        }
    }
}