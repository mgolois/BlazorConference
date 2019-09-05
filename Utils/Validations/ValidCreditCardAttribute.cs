﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorConference.Utils.Validations
{
    //Credit to:
    public class ValidCreditCardAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            try
            {
                if (value is string cardNumber)
                {
                    cardNumber = cardNumber.Replace(" ", "");
                    cardNumber = cardNumber.Replace("-", "");
                    if (cardNumber.Length != 16)
                        return false;

                    //FIRST STEP: Double each digit starting from the right
                    int[] doubledDigits = new int[cardNumber.Length / 2];
                    int k = 0;
                    for (int i = cardNumber.Length - 2; i >= 0; i -= 2)
                    {
                        int digit = int.Parse(cardNumber[i].ToString());
                        doubledDigits[k] = digit * 2;
                        k++;
                    }

                    //SECOND STEP: Add up separate digits
                    int total = 0;
                    foreach (int i in doubledDigits)
                    {
                        string number = i.ToString();
                        for (int j = 0; j < number.Length; j++)
                        {
                            total += int.Parse(number[j].ToString());
                        }
                    }

                    //THIRD STEP: Add up other digits
                    int total2 = 0;
                    for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
                    {
                        int digit = int.Parse(cardNumber[i].ToString());
                        total2 += digit;
                    }

                    //FOURTH STEP: Total
                    int final = total + total2;

                    return final % 10 == 0; //Well formed will divide evenly by 10
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
