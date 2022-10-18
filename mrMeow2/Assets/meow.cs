using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meow : MonoBehaviour
{
    // Player Details
    float playerSpeed = 0.0f;
    // Hero Details
    string heroName = "|| Mr.Meow ||";
    int heroPower = 1500;
    // Villain Details
    string villainName = "|| Dog Scoobar ||";
    int villainPower = 480;
 // -----------------------------------
    // Functions
    void setSpeed(float speed)
    {
        playerSpeed = speed;
        print(playerSpeed);
    }
    void compareSpeed(float oldSpeed, float newSpeed)
    {
        if(oldSpeed > newSpeed)
        {
            print(oldSpeed);
        }else if(newSpeed > oldSpeed)
        {
            print(newSpeed);
        }else
        {
            // áÃä åäí ÑÇÍ íßæäæä ãÊÛíÑíä äÝÓ ÇáÔí¡ íÚäí ãÇ ÊÝÑÞ ÅÐÇ ØÈÚäÇ åÐÇ æáÇ åÐÇ
            print(oldSpeed);
        }
    }

    void Start()
    {
        if(heroPower > villainPower)
        {
            print($"{heroName} Is The Winner, Horraaaayyyyy! :) ");
        } else if (villainPower > heroPower)
        {
            print($"{villainName} Defeated the Glorious {heroName}, sad :( ");
        } else
        {
            print("Tiee!!");
        }
        setSpeed(2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
