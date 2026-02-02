using UnityEngine;

public interface Iinteractable_Script
{
    public string InteractionPrompt { get; }    
    public bool Interact(Interactor interactor);
}

public class Interactor
{
    // Add properties or methods as needed for your application.
}
