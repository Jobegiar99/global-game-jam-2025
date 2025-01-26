using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text diaglogText;
    public DialogNode current;

    public void DisplayNode()
    {
        if (current != null && diaglogText != null)
        {
            diaglogText.text = current.diaText;
        }
    }

    public void goNextTrigger()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            DisplayNode();
        }
        else
        {
            Debug.Log("Assign text my friend");
        }
    }

    public void goPrevTrigger()
    {
        if (current != null && current.prev != null) 
            {
                current = current.prev;
            DisplayNode();
            }
        else
        {
            Debug.Log("nah");
        }
    }

    private void Start()
    {
        if (current != null)
        {
            DisplayNode();
        }
        else
        {
            Debug.Log("Assign text my friend");
        }
    }

}
