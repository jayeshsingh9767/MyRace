using UnityEngine;

public class RotateCoin : MonoBehaviour {
    
    public Transform trans;
    public Vector3 coin,force;
    public GameObject curCoin;
    public Rigidbody coinBody;
    

    // Update is called once per frame
	void Update () {
        //trans.rotation.x = trans.rotation.x + 1;
        trans.Rotate(coin,1);
	}
    private void OnTriggerEnter(Collider other)
    {
        coinBody.AddForce(force,ForceMode.VelocityChange);// = transform.up * 100f;
        //transform.TransformPoint();
        //curCoin.SetActive(false);
        //Debug.Log("Coin Collected");
    }
    


}
