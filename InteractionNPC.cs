using UnityEngine;
using System.Collections;

public class InteractionNPC : MonoBehaviour
{
    public GUIText ChatNPC;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "maid")
        {
            SetChatNPC();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "maid")
        {
            ChatNPC.text = "";
        }
    }

    void SetChatNPC()
    {
        ChatNPC.text = "Bienvenu dans notre hotel";
    }
}
