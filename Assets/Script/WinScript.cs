using UnityEngine;

public class WinScript : MonoBehaviour {
    public GameManager gm;
    void OnTriggerEnter()
    {
        gm.YouWon();
    }

}
