using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public Transform player;
	public Text curScore;
    public GameManager gm;
	// Update is called once per frame
	void Update () {
        curScore.text=player.position.z.ToString("0");
       
        if (gm.gameEnded) {
            curScore.color = Color.red;
            curScore.text = "Game Over\nYour Score is "+curScore.text;
        }
	}
}
