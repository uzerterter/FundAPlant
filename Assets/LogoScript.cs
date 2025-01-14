using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;
using System.Collections;

public class LogoScript : MonoBehaviour
{
    public GameObject logo; // Das Logo-GameObject
    public float displayTime = 3f; // Wie lange das Logo angezeigt wird
    public GameObject arCamera; // Die AR-Kamera
    public GameObject scanArea; // Der Scan-Bereich, wie in deinem Screenshot
    public GameObject scrollView;

    private void Start()
    {
        // Das Logo anzeigen und AR-Kamera vorbereiten
        logo.SetActive(true);
        arCamera.SetActive(false); // AR-Kamera zunächst deaktivieren
        scanArea.SetActive(false); // Den Scan-Bereich ausblenden, bis das Logo verschwunden ist
        scrollView.SetActive(false); // Verstecke die ScrollView zu Beginn
        StartCoroutine(HideLogoAfterTime());
    }

    private IEnumerator HideLogoAfterTime()
    {
        yield return new WaitForSeconds(displayTime); // Warte, bis die angegebene Zeit vergangen ist
        logo.SetActive(false); // Logo ausblenden
        arCamera.SetActive(true); // AR-Kamera aktivieren, um die reale Welt zu zeigen
        scanArea.SetActive(true); // Den Scan-Bereich einblenden
    }

     // Methode, die aufgerufen wird, wenn der Scanbereich angeklickt wird
    public void OnScanAreaClicked()
    {
        // Zeige die ScrollView an, wenn der Scanbereich angeklickt wurde
        scrollView.SetActive(true);
        scanArea.SetActive(false);
    }
}
