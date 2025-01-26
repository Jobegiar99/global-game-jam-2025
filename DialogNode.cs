using UnityEngine;

[CreateAssetMenu(fileName = "newDialogNode", menuName ="Dialog/Node")]
public class DialogNode : ScriptableObject
{
    [TextArea(3, 10)]
    public string diaText;
    public DialogNode next; 
    public DialogNode prev;
}


