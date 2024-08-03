using UnityEngine;

public class PuzzleKey : MonoBehaviour
{
    public Animator animator; // Animatör bileşenine referans
    public string triggerName = "KeyTriggered"; // Animasyonu tetiklemek için kullanılan trigger adı

    private void OnTriggerEnter(Collider other)
    {
        // Eğer oyun objesi "Key" tag'ine sahipse
        if (other.CompareTag("BUBİRKEYDİR"))
        {
            // Animasyonu tetikle
            animator.SetTrigger("GateOpen");
            Debug.Log("Anahtar bulundu, animasyon tetiklendi.");
        }
    }
}
