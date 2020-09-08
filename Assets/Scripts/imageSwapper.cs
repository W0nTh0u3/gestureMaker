using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class imageSwapper : MonoBehaviour {
    public Button changeImage;
    public Sprite[] Pics;
    public Text thisImage;
    private int nextValue = 0;
    // Start is called before the first frame update
    void Start () {

        Object[] baybayin = Resources.LoadAll ("BaybayinLetters/", typeof (Sprite));
        Pics = new Sprite[baybayin.Length];
        for (int x = 0; x < baybayin.Length; x++) {
            Pics[x] = (Sprite) baybayin[x];
        }

        Button chngBtn = changeImage.GetComponent<Button> ();
        chngBtn.onClick.AddListener (changeOnClick);
        thisImage.text = "Image Shown\n" + gameObject.GetComponent<Image> ().sprite.name;
    }

    void changeOnClick () {
        if (nextValue < Pics.Length)
            gameObject.GetComponent<Image> ().sprite = Pics[nextValue];
        else {
            nextValue = 0;
            gameObject.GetComponent<Image> ().sprite = Pics[nextValue];
        }
        nextValue++;
        thisImage.text = "Image Shown\n" + gameObject.GetComponent<Image> ().sprite.name;
    }

    // Update is called once per frame
    void Update () {

    }
}