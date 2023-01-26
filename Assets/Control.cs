using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    int minNum = 1;
    int maxNum = 100;
    int guess;
    bool gameStart = false;
    bool gameOver = false;
    void Start()
    {
        print("Do you want to play a game with me? (Y / N)");
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart)
        {

            if (Input.GetKeyDown(KeyCode.Y))
            {
                print("Perfect ! Keep a number in your mind between 1-100 and press ENTER");
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                print("Maybe next time...");
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ControlNumber();
                gameStart = true;
            }
        }
        else if (!gameOver)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                minNum = guess;
                ControlNumber();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxNum = guess;
                ControlNumber();
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Yeeeeyyyy!");
                gameOver = true;
            }
        }
    }
    void ControlNumber()
    {
        guess = (minNum + maxNum) / 2;
        print(guess + "  is your number ?");
        print("Your number bigger than my guess press UP ARROW  , lower than my guess press DOWN ARROW! Ýf it is true press SPACE");

    }
}
