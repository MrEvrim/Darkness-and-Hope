using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform[] pathPoints; 
    public float speed = 2.0f;     
    public float reachDistance = 0.1f; 

    private int currentPoint = 0;

    void Update()
    {
        if (pathPoints.Length == 0) return;

        // Noktaya hareket kodu
        Transform targetPoint = pathPoints[currentPoint];
        Vector3 direction = targetPoint.position - transform.position;

        // Y ekseninde rotasyonu model de test oldugu için - aldım
        Vector3 lookDirection = new Vector3(targetPoint.position.x, transform.position.y, targetPoint.position.z);
        Quaternion targetRotation = Quaternion.LookRotation(lookDirection - transform.position);

        // 180 derece döndürme
        targetRotation *= Quaternion.Euler(0, 180, 0);
        transform.rotation = targetRotation;

        // Karakteri hareket ettir
        transform.position += direction.normalized * speed * Time.deltaTime;

     
        if (direction.magnitude <= reachDistance)
        {
            currentPoint++;
            if (currentPoint >= pathPoints.Length)
            {
                currentPoint = 0; 
            }
        }
    }

    void OnDrawGizmos()
    {
        if (pathPoints.Length == 0) return;

        Gizmos.color = Color.cyan;
        for (int i = 0; i < pathPoints.Length; i++)
        {
            if (pathPoints[i] == null) continue; 

            if (i + 1 < pathPoints.Length && pathPoints[i + 1] != null)
            {
                Gizmos.DrawLine(pathPoints[i].position, pathPoints[i + 1].position);
            }
        }
    }
}
