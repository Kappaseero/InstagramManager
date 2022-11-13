﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.Models;

namespace InstagramPrivateAPI.Helpers.Captions
{
    internal static class QuizCaption
    {
        public static string MakeCaption(IQuestionAnswerModel questionAnswerModel, DateTime dateTime, out int rightAnswerNumber)
        {
            List<string> answersList = questionAnswerModel.WrongAnswers.ToList();
            answersList.Add(questionAnswerModel.Answer);
            List<string> scrambledAnswersList = ListMethods.ScrambleList(answersList);

            //+1 because count below starts from 1
            rightAnswerNumber = scrambledAnswersList.IndexOf(questionAnswerModel.Answer) + 1;


            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(dateTime.Date + ".");
            stringBuilder.Append("Possible answers are:");
            int count = 1;
            foreach(string answer in scrambledAnswersList)
            {
                stringBuilder.Append($" {count}:{answer}.");
                count++;
            }
            stringBuilder.Append(" Type the number of your answer as a comment.");

            return stringBuilder.ToString();
        }

    }
}