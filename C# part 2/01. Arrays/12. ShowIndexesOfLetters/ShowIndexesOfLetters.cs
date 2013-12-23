/*
 * Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.
 */

using System;

class ShowIndexesOfLetters
{
    static void Main()
    {
        //Creating the char array with all lower letters in the alphabet
        char[] letters = new char[26];

        for (int i = 0, letter = 97; i < letters.Length; i++, letter++)
        {
            letters[i] = (char)letter;
        }

        //Reading the word from the console
        Console.Write("Enter the selected word: ");
        string selectedWord = Console.ReadLine();
        selectedWord.ToLower(); //setting all the letters in the word to be lower
        Console.WriteLine(selectedWord);

        //Printing the letter's indexes
        for (int i = 0; i < selectedWord.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                //we need to check if the tested char is in the range of letters
                if ((int)selectedWord[i] >= 97 || (int)selectedWord[i] <= 122)
                {
                    if (selectedWord[i] == letters[j])
                    {
                        Console.WriteLine("'{0}' -> index: {1}", selectedWord[i], j);
                    }
                }
                else
                {
                    Console.WriteLine("'{0}' -> character is not a letter", selectedWord[i]);
                }
            }
        }
    }
}