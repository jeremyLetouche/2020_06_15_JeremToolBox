using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider))]
public class Trigger_Collision : MonoBehaviour
{

    Collider _collider;


    public UnityEvent OnEnter;
    public UnityEvent OnStay;
    public UnityEvent OnExit;

    public SensitiveToVirtualTriggerZone.BodyPart[] partAccepted;


    private void Awake()
    {
        _collider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        SensitiveToVirtualTriggerZone sensitiveVRZone = other.gameObject.GetComponent<SensitiveToVirtualTriggerZone>();
        if (sensitiveVRZone != null)
        {
            SensitiveToVirtualTriggerZone.BodyPart bodyPart = sensitiveVRZone.bodyPart;
            for (int i = 0; i < partAccepted.Length; i++)
            {
                if (bodyPart == partAccepted[i])
                {
                    OnEnter.Invoke();
                }
            }

        }


    }
    private void OnTriggerStay(Collider other)
    {
        SensitiveToVirtualTriggerZone sensitiveVRZone = other.gameObject.GetComponent<SensitiveToVirtualTriggerZone>();

        if (sensitiveVRZone != null)
        {
            SensitiveToVirtualTriggerZone.BodyPart bodyPart = sensitiveVRZone.bodyPart;
            for (int i = 0; i < partAccepted.Length; i++)
            {
                if (bodyPart == partAccepted[i])
                {
                    OnStay.Invoke();
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SensitiveToVirtualTriggerZone sensitiveVRZone = other.gameObject.GetComponent<SensitiveToVirtualTriggerZone>();

        if (sensitiveVRZone != null)
        {
            SensitiveToVirtualTriggerZone.BodyPart bodyPart = sensitiveVRZone.bodyPart;
            for (int i = 0; i < partAccepted.Length; i++)
            {
                if (bodyPart == partAccepted[i])
                {
                    OnExit.Invoke();
                }
            }
        }
    }


}
