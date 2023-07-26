using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : Singleton<DialogueSystem>
{
    public void ShowDialogue(List<string> dialogue)
    {
        // do your display

        foreach(string line in dialogue)
        {
            Debug.Log(line);
        }
    }
}
