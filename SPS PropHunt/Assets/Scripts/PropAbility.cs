using UnityEngine;
using UnityEngine.UI;

public class PropAbility : MonoBehaviour
{
    public PlayerMovement pmscript;
    public GameObject lockedIndicator;
    public GameObject PropMenu;

    void Start()
    {
        
    }

    void Update()
    {
        input();
    }

    private void input(){
        if (Input.GetKeyDown("c")){pmscript.TogglePropLock();lockedIndicator.SetActive(pmscript.Locked);}
        if (Input.GetKeyDown("q")){
            PropMenu.SetActive(!PropMenu.activeSelf);
            pmscript.LookLock = !(pmscript.LookLock);        
            Cursor.visible = !(Cursor.visible);
            if(Cursor.lockState == CursorLockMode.Locked){Cursor.lockState = CursorLockMode.Confined;} else{Cursor.lockState = CursorLockMode.Locked;}
        }
    }
}

