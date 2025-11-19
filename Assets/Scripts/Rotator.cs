using UnityEngine;

public class Rotator : MonoBehaviour

{
    [SerializeField] AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
        Destroy(gameObject, audioSource.clip.length);
    }














}
