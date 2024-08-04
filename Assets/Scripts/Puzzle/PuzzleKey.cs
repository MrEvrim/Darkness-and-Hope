using UnityEngine;

public class PuzzleKey : MonoBehaviour
{
    public Animator animator; // Animator bileşenine referans
    public string triggerName = "GateOpen"; // Animasyonu tetiklemek için trigger ismi

    private void OnTriggerEnter(Collider other)
    {
        // Eğer oyun objesi "Key" tag'ine sahipse
        if (other.CompareTag("BUBİRKEYDİR"))
        {
            // Animasyonu tetikle
            animator.SetTrigger("GateOpen");
            Debug.Log("Anahtar bulundu, animasyon tetiklendi.");

            // GateSoundEffect script'ine eriş
            GateSoundEffect gateSoundEffect = GetComponent<GateSoundEffect>();
            // Eğer script varsa
            if (gateSoundEffect != null)
            {
                // GateSoundEffect script'indeki PlayGateOpenSound metodunu çağır
                gateSoundEffect.PlayGateOpenSound();
            }
            else
            {
                Debug.LogWarning("GateSoundEffect script'i bulunamadı.");
            }
        }
    }
}
