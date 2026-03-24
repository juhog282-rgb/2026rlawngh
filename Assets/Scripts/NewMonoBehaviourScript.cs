using System.Runtime.CompilerServices;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name + " 와 충돌 ");
        if(collision.gameObject.tag == "Groud")
        {
            Debug.Log("땅과 충돌");
        }
    }
}
private void OnTriggerEnter(Collider other)
{
    Debug.Log("트리거 밖으로 나감");
}

private void OnTriggerEnter(Collider collison)
{
    Debug.Log("트리거 안에 들어옴");
}