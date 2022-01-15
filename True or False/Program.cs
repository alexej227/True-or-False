using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();

            // Type your code below
            string[] questions = new string[]{
        "\nhaben Enten flossen?",
        "\nIst es wirklich wahr, dass Krokodile Steine als Ballast schlucken, um tief untergetaucht schwimmen zu können?",
        "\nIst es wirklich wahr, dass Russland die längste Küste von allen Staaten der Erde hat?",
        "\nIst es wirklich wahr, dass im Hochmittelalter in Europa im Durchschnitt auf zwei Menschen eine Kirche kam?",
        "\nIst es wirklich wahr, dass der Nil schon einmal zugefroren war?",
         "\nIst es wirklich wahr, dass ein Gesetz aus dem 16. Jahrh. in England den Männern erlaubte, ihre Ehefrauen zu verprügeln, aber nur vor zehn Uhr vormittags?",
         "\nIst es wirklich wahr, dass in den USA statistisch gesehen jede Woche ein US-Bürger vom Blitz erschlagen wird?",
         "\nIst es wirklich wahr, dass eine Raupe etwa genauso viele Muskeln hat, wie ein Mensch?",
         "\nIst es wirklich wahr, dass männliche Affen im Gegensatz zu Männern keine Glatze bekommen können?",
         "\nIst es wirklich wahr, dass Krokodile ihre Zunge nicht herausstrecken können?"};

            string[] answers = new string[]{
     "True", "True", "False", "True", "True", "True","False","False","False","True"};
            

            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning questions are not equal answers!!!");
            }
            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputbool;

                Console.WriteLine($"{question}");
                Console.WriteLine("Richtig oder Falsch?");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputbool);

                while (isBool == false)
                {
                    Console.WriteLine("Bitte antworte mit 'true' oder 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputbool);
                }
                responses[askingIndex] = isBool;
                askingIndex++;
            }
            foreach (bool response in responses)
            {
                Console.WriteLine(response);
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (string answer in answers)
            {
                bool points = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex} Eingabe: {responses[scoringIndex]} | Antwort: {answer}");
                if (Convert.ToString(responses[scoringIndex]) == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"Du hast {score} von {questions.Length} Punkten erzielt");
        }
    }
}
/*           "ja, Die Ente hat einen grünen bis braunen Schnabel und dunkelorange Beinchen und Flossen.",
             "ja",
             "nein, Kanada",
             "ja",
             "ja, schon zweimal im 9. und 11. Jahrhundert",
             "ja",
             "nein, täglich",
             "nein, sie hat etwa dreimal so viele Muskeln",
             "nein",
             "ja"
             */




//    If you wanted to make multiple quizzes, you would have to type out the same code multiple times. 
//    Fix this issue by refactoring your code into a method RunQuiz(). 
//    It should take two arguments: a string[] array of questions and bool[] array of answers. 
//    It should have the same behavior as your current app.


//string[] questions = new string[]
//{
//  /*...*/
//};

//bool[] answers = new bool[]
//{
//  /* ...*/
//};

//RunQuiz(questions, answers);
