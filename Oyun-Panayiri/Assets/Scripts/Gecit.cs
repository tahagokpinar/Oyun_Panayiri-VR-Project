using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gecit : MonoBehaviour
{
    public XRSocketInteractor socketInteractor;
    public Transform doorTransform;
    public float maxHeight = 3.0f;
    public float moveSpeed = 0.5f;
    public AudioClip openSound;
    private AudioSource audioSource;

    private bool isMoving = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Audio kaynağını al
        audioSource.playOnAwake = false; // Oynatma otomatik başlamasın
        audioSource.loop = false; // Döngüde çalma olmasın
        if (socketInteractor != null)
        {
            socketInteractor.onSelectEntered.AddListener(OnObjectPlaced);
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            if (doorTransform.position.y < maxHeight)
            {
                doorTransform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            }
            else
            {
                if (audioSource != null && openSound != null)
                {
                    audioSource.PlayOneShot(openSound); // Açılma sesini çal
                }
                if(doorTransform.position.y >= maxHeight)
                {
                    audioSource.Stop();
                }

                isMoving = false; // Maksimum yüksekliğe ulaşıldığında hareketi durdur
            }
        }
    }

    private void OnObjectPlaced(XRBaseInteractable interactable)
    {
        // Nesne yerleştirildiğinde hareketi başlat
        isMoving = true;
        if (audioSource != null && openSound != null)
        {
            audioSource.PlayOneShot(openSound); // Açılma sesini çal
        }
    }
}
