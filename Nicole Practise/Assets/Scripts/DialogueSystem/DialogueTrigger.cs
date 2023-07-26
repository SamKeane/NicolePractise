using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] private List<string> _dialogue;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DialogueSystem.Instance.ShowDialogue(_dialogue);
        }
    }
}
