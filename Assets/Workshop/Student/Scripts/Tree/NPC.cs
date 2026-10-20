using Solution;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class NPC : Identity
{
    public DialogueUI dialogueUI;
    public DialogueSequen sequen;
    public bool canTalk = true;

    private void Awake()
    {
        // DialogueSequen component is missing from the NPC in the scene, so add it here if needed
        if (sequen == null) sequen = GetComponent<DialogueSequen>();
        if (sequen == null) sequen = gameObject.AddComponent<DialogueSequen>();
    }

    public override bool Hit()
    {
        // 돤푭姦뵉脘솝禹톰뮐勵昆루족戾들系⌒촉쵠琨쥡
        if (canTalk)
        {
            dialogueUI.Setup(sequen);
            return false;
        }
        else
        {
            Debug.Log("I not neet to talk to you");
            return false;
        }
    }
}
