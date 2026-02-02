using UnityEngine;

public interface Iinteractable_Script
{
    public string InteractionPrompt { get; }    
    public bool Interact(Interactor interactor);
}
