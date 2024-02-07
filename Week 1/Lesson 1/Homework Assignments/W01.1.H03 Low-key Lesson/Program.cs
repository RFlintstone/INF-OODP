  using System;
using System.Collections.Generic;

namespace W01._1.H03_Low_key_Lesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //creating a dictionary using collection-initializer syntax
            // 1:[C], 2:[D], 3:[A, D]
            var expectedAnswers = new Dictionary<string, List<string>>()
            {
                {"1", new List<string> {"C"}},
                {"2", new List<string> {"D"}},
                {"3", new List<string> {"A", "D"}}
            };

            List<string> input;
            int currentScore = 0;

            int questionCount = 1;
            input = ask_question(
                "Answer the following MCQs:\nWhich of the following is NOT a valid type in C#?\nA: bool\nB: int\nC: var\nD: string",
                questionCount);
            currentScore = check_answer(input, expectedAnswers, questionCount, currentScore);

            questionCount = 2;
            input = ask_question(
                "What happens if you execute the following line C#?\nint x = 1.23;\nA: x will be 1.23\nB: x will be 1\nC: x will be 1.0\nD: you will get a compiler error",
                questionCount);
            currentScore = check_answer(input, expectedAnswers, questionCount, currentScore);

            questionCount = 3;
            input = ask_question(
                "Consider the following line:\ndouble d = 1.23;\nWhat are TWO ways to convert variable d to an int?\nA: int i = (int)d;\nB: int i = int(d)\nC: int i = 0 + d\nD: int i = Convert.ToInt32(d)",
                questionCount);
            currentScore = check_answer(input, expectedAnswers, questionCount, currentScore);

            string msg;
            if (currentScore >= 3)
            {
                msg = $"Your score: {currentScore} out of 3. Well done!";
            }
            else
            {
                msg = $"Your score: {currentScore} out of 3";
            }

            Console.WriteLine(msg);
        }

        static List<string> ask_question(string question, int count)
        {
            string input;
            List<string> inputStorage = new List<string>();

            Console.WriteLine(question);

            if (count == 3)
            {
                input = Console.ReadLine();
                inputStorage.Add(input);
            }

            input = Console.ReadLine();
            inputStorage.Add(input);

            return inputStorage;
        }

        static int check_answer(List<string> inputs, Dictionary<string, List<string>> expectedAnswers,
            int questionCount, int score)
        {
            string questionCountStr = questionCount.ToString();

            if (expectedAnswers.ContainsKey(questionCountStr))
            {
                List<string> values = expectedAnswers[questionCountStr];

                int numCorrect = 0;
                foreach (string value in values)
                {
                    foreach (var input in inputs)
                    {
                        if (input.ToUpper() == value)
                        {
                            numCorrect++;
                            break;
                        }
                    }

                    Console.WriteLine($"Value: {value}");
                }

                Console.WriteLine($"numCorrect: {numCorrect}");

                if (numCorrect > 0 && questionCount != 3)
                {
                    score += 1;
                }

                if (numCorrect == 2 && questionCount == 3)
                {
                    score += 1;
                }
            }

            return score;
        }
    }
}