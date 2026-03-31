using UnityEngine;

public class myjump : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float power = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input . GetKeyDown(Keycode.Spcae))
        {
            power = power + Random.Range(-100, 200);
            rigidbody.AddForce(transform.up* power );
        }

        if(this.gameObject.transform.position.y > 5 this gameObject .transform.position.y < 3)

         {
                Destory(this.game0bject);
            }
    }
}
