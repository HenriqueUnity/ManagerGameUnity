using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FacenoteScript : MonoBehaviour
{
    private string[] userNames = { "Anne", "Enzo", "Jair", "Inácio", "Neymar", "Rose", "Jeremias" };
    private string[] userPost = new string[5];
    private string[] positiveReply = new string[5];
    private string[] negativeReply = new string[5];
    private string[] userPositiveReply = new string[5];
    private string[] userNegativeReply = new string[5];
    private int[] RandomIndexes = new int[5];
    [SerializeField] TextMeshProUGUI feedText;

    void Start()
    {
        userPost[0] = "Como assim tem uns maluco de capa?";
        userPost[1] = "Acho que bebi demais, vi um maluco de capa!";
        userPost[2] = "Agora sim que a policia se aposenta.";
        userPost[3] = "Heróis na cidade? será que isso vai dar bom?";
        userPost[4] = "Só eu acho que essa história de heróis ta mal contada.";

        positiveReply[0] = "Isso aí os heróis estão na área!\n";
        positiveReply[1] = "Eles arrasam não é mesmo?\n";
        positiveReply[2] = "Nada segura os heróis\n";
        positiveReply[3] = "Sai da frente que eles estão vindo com tudo\n";
        positiveReply[4] = "Mando na DM seu herói favorito!\n";

        negativeReply[0] = "Vai achar o que fazer! os heróis que mandam agora!\n";
        negativeReply[1] = "Ta ai uma pessoa desocupada! vai dormir!\n";
        negativeReply[2] = "Lá vem mimimi! Saí pra lá!\n";
        negativeReply[3] = "Deleta que ainda da tempo!\n";
        negativeReply[4] = "Vai botar um trabalho nesse coro ai!\n";
    }

    private void RandomizeFeedDialogue()
    {
        for (int i = 0; i < RandomIndexes.Length; i++)
        {
            RandomIndexes[i] = Random.Range(0, 5);

        }
    }
   
    public void FeedTextUpdate()
    {
        RandomizeFeedDialogue();
        feedText.text = $"{userNames[RandomIndexes[0]]}:Postou a 1 minuto atrás\n{userPost[RandomIndexes[1]]}";
            
    }
    public void PositiveReply()
    {
        feedText.text += $"\nComentários:\nVocê: {positiveReply[RandomIndexes[3]]}";
    }
    public void NegativeReply()
    {
        feedText.text += $"\nComentários:\nVocê: {negativeReply[RandomIndexes[4]]}";  
    }
}
