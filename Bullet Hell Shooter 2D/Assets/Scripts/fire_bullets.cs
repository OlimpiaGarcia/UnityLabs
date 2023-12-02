using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fire_bullets : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount1 = 5;
    
    [SerializeField]
    private float startAngle1 = 1f, endAngle1 = 359f;

    [SerializeField]
    private int bulletsAmount2 = 25;
    
    [SerializeField]
    private float startAngle2 = 0f, endAngle2 = 270f;

    [SerializeField]
    private int bulletsAmount3 = 50;
    
    [SerializeField]
    private float startAngle3 = 90f, endAngle3 = 270f;
    
    private Vector2 bulletMoveDirection;

    public TMPro.TextMeshProUGUI bulletQuantityText;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire1", 0f, 2f);
    }

    private void Fire1()
    {
        float angleStep1 = (endAngle1 - startAngle1) / bulletsAmount1;
        float angle1 = startAngle1;

        for (int i = 0; i < bulletsAmount1 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle1 * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle1 * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = bullet_pool.bulletPoolInstance.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<bullet>().SetMoveDirection(bulDir);

            angle1 += angleStep1;
        }
        
    }

    private void Fire2()
    {
        float angleStep2 = (endAngle2 - startAngle2) / bulletsAmount2;
        float angle2 = 40;


        for (int i = 0; i < bulletsAmount2 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle2 * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle2 * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 5f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;


            GameObject bul2 = bullet_pool.bulletPoolInstance.GetBullet();
            bul2.transform.position = transform.position;
            bul2.transform.rotation = transform.rotation;
            bul2.SetActive(true);
            bul2.GetComponent<bullet>().SetMoveDirection(bulDir);

            angle2 += angleStep2;
        }

    }

    private void Fire3()
    {
        float angleStep3 = (endAngle3 - startAngle3) / bulletsAmount3;
        float angle3 = 72;

        for (int i = 0; i < bulletsAmount3 + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle3 * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle3 * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 5f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul3 = bullet_pool.bulletPoolInstance.GetBullet();
            bul3.transform.position = transform.position;
            bul3.transform.rotation = transform.rotation;
            bul3.SetActive(true);
            bul3.GetComponent<bullet>().SetMoveDirection(bulDir);

            angle3 += angleStep3;
        }
    }

    void Update()
    {
        
        
        if (Time.time >= 10f && Time.time < 11f)
        {
            // Cancela InvokeRepeating para detener Fire1
            CancelInvoke("Fire1");

            // Inicia la función Fire2 
            InvokeRepeating("Fire2", 0f, 7f);
        }

        

        if (Time.time >= 31f && Time.time < 41f)
        {
            // Cancela InvokeRepeating para detener Fire2
            CancelInvoke("Fire2");
            
            //Inicia la función Fire3 
            InvokeRepeating("Fire3", 0f, 10f);

        }

        
        if (Time.time >= 42f && Time.time < 61f)
        {
            // Cancela InvokeRepeating para detener Fire3
            CancelInvoke("Fire3");
        }
    }
}
