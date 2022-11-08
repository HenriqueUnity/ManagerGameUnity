using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FacenoteScript : MonoBehaviour
{
    private string[] userNames = { "Anne", "Enzo", "Jair", "In�cio", "Neymar", "Rose", "Jeremias" };
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
        userPost[3] = "Her�is na cidade? ser� que isso vai dar bom?";
        userPost[4] = "S� eu acho que essa hist�ria de her�is ta mal contada.";

        positiveReply[0] = "Isso a� os her�is est�o na �rea!\n";
        positiveReply[1] = "Eles arrasam n�o � mesmo?\n";
        positiveReply[2] = "Nada segura os her�is\n";
        positiveReply[3] = "Sai da frente que eles est�o vindo com tudo\n";
        positiveReply[4] = "Mando na DM seu her�i favorito!\n";

        negativeReply[0] = "Vai achar o que fazer! os her�is que mandam agora!\n";
        negativeReply[1] = "Ta ai uma pessoa desocupada! vai dormir!\n";
        negativeReply[2] = "L� vem mimimi! Sa� pra l�!\n";
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
        feedText.text = $"{userNames[RandomIndexes[0]]}:Postou a 1 minuto atr�s\n{userPost[RandomIndexes[1]]}";
            
    }
    public void PositiveReply()
    {
        feedText.text += $"\nComent�rios:\nVoc�: {positiveReply[RandomIndexes[3]]}";
    }
    public void NegativeReply()
    {
        feedText.text += $"\nComent�rios:\nVoc�: {negativeReply[RandomIndexes[4]]}";  
    }
}
