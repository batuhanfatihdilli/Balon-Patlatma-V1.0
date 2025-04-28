using UnityEngine;

public class BalonKontrol : MonoBehaviour
{
    public GameObject patlama_0;
    OyunKontrol oyunKontrolScripti;

    void Start()
    {
        oyunKontrolScripti = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    void OnMouseDown()
    {
        GameObject go = Instantiate(patlama_0,transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.333f);
        oyunKontrolScripti.BalonEkle();    
    }
   
}
