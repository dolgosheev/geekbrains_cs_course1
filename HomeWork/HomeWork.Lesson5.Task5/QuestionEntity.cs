namespace HomeWork.Lesson5.Task5
{
    internal class QuestionEntity
    {
        internal string Question { get; }
        internal string Answer { get; }

        internal QuestionEntity(string q,string a)
        {
            Question = q;
            Answer = a;
        }

    }
}