using UnityEngine;

public class Character : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        switch (Input.inputString)
        {
            case "a":
                animator.SetFloat("Character", 0);
                break;
            case "s":
                animator.SetFloat("Character", 1);
                break;
            case "d":
                animator.SetFloat("Character", 2);
                break;
            case "w":
                animator.SetFloat("Character", 3);
                break;
        }
    }
}
