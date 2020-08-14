namespace Curso.Udemy.CSharpCompleto2020.Capitulo9.Composition2.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
