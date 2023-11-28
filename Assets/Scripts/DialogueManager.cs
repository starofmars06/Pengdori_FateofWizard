using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences; //큐는 리스트 형식, FIFO(First in First Out)

    void Start()
    {
        sentences = new Queue<string>();
    }

}
