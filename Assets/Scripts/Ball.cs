using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Ball ball;


    public Vector3 Position => rb.position;

    public bool IsMoving => rb.velocity != Vector3.zero;

    public bool IsTeleporting => IsTeleporting;

    [SerializeField] Vector3 lastPosition;

    bool isTeleporting;

    private void Awake()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        lastPosition = this.transform.position;
    }

    internal void AddForce(Vector3 force)
    {
        rb.isKinematic = false;
        lastPosition = this.transform.position;
        rb.AddForce(force, ForceMode.Impulse);
    }

    private void FixedUpdate()
    {
        if (rb.velocity != Vector3.zero &&
            rb.velocity.magnitude < 0.5f)
        {
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Out")
        {
            StartCoroutine(DelayedTeleport());
        }
    }

    IEnumerator DelayedTeleport()
    {
        isTeleporting = true;
        rb.isKinematic = true;
        yield return new WaitForSeconds(0);
        this.transform.position = lastPosition;
        isTeleporting = false;
    }
}
