using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences; //ť�� ����Ʈ ����, FIFO(First in First Out)

    void Start()
    {
        sentences = new Queue<string>();
    }

}
