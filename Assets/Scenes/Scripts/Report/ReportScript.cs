using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReportScript : MonoBehaviour
{
    [SerializeField] Main_Script myMain_Script;
    [SerializeField] List<Locals_mainscript> myLocalsMain_script;

    [Header("Text Elements")]
    [SerializeField] TextMeshProUGUI[] LocalnameTXT,
        localCrimeTXT;
    [SerializeField] TextMeshProUGUI finalMoneyTXT, fameUpgradeTxt;
    private int payday,finalMoney,contracts,moneyreport;
    private int[] finalCrime = new int[3] ;
    private int[] heroPower = new int[3];
    private int[] localcrimeValue = new int[3];
    private string[] localnames = new string[3]; 
    private string[] heroNames = new string[3];
    

    
    public void ReportStats()
    {
      fameUpgradeTxt.text = "Bônus de fama: ";
        for (int i = 0; i < myLocalsMain_script.Count; i++)
        {

            if(myLocalsMain_script[i].noheroReport == false)
            {
            finalCrime[i] = myLocalsMain_script[i].localcrime;
             heroNames[i] = myLocalsMain_script[i].heroName;
            localnames[i] = myLocalsMain_script[i].localName;
                if (finalCrime[i] == 0)
                {
                    localCrimeTXT[i].text = $"Parece que o {heroNames[i]} acabou com os criminosos";
                    fameUpgradeTxt.text += $"{myLocalsMain_script[i].fameUpgrade} por {heroNames[i]} ";
                }
                else
                {                    
                    heroPower[i] = myLocalsMain_script[i].heroPowerReport;
                    localcrimeValue[i] = myLocalsMain_script[i].localCrimeReport;
                    localCrimeTXT[i].text = $"Crime local:{localcrimeValue[i]} - Força do Herói:{heroPower[i]}" +
                        $" = Crime local restante: {finalCrime[i]}";
                    
                }
            }
            else
            {//no hero in local                
                finalCrime[i] = myLocalsMain_script[i].localcrime;
                if (finalCrime[i] == 0)
                {
                localCrimeTXT[i].text = "Aqui está tudo sobre controle! nada que a policia local não resolva";
                }
                else
                localCrimeTXT[i].text = $"Nenhum herói alocado aqui ;), crime local restante: {finalCrime[i]}";
                               
            }                     
            LocalnameTXT[i].text = $"Localidade:{localnames[i]}";
        }
        //money calculator
        payday      = myMain_Script.totalpayday;
        finalMoney  = myMain_Script.money;
        moneyreport = myMain_Script.ReportMoney;
        contracts   = myMain_Script.contractsTotalMoney;

        finalMoneyTXT.text = $"Finanças: R$:{moneyreport} + R$:{contracts} - R$:{payday} = R$:{finalMoney}.";        
    }

}
