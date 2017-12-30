using UnityEngine;

public class Mover : MonoBehaviour {
    Rigidbody rb;
    public float speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start ()
    {
        rb.velocity = transform.forward * speed;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
