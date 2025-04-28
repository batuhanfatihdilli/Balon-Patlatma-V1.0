using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText,balonText;
    public GameObject patlama_0;
    public float zamanSayaci = 10;
    int patlayanBalon = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        balonText.text = "Balon :" + patlayanBalon;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zamanSayaci > 0){
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "Süre : " + (int)zamanSayaci;
        } else {
            GameObject[] go = GameObject.FindGameObjectsWithTag ("Balon");
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama_0, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }
        }

    }
    public void BalonEkle() {
        patlayanBalon += 1;
        balonText.text = "Balon :" + patlayanBalon;
    }
}
