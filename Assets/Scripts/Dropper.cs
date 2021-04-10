using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWaitBeforeDrop = 5f;

    // Cache references
    MeshRenderer meshRenderer;
    new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWaitBeforeDrop && rigidbody.useGravity == false)
        {
            rigidbody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
