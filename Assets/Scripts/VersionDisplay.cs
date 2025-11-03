using UnityEngine;
using TMPro;

public class VersionDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text versiontext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        versiontext.text = $"Version: {Application.version}";
    }
}
