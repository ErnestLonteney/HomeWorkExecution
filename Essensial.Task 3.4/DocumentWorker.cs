namespace Essensial.Task_3._4
{
    class DocumentWorker
    {
        public void OpenDocument() => Console.WriteLine("Document has been opened");
        public virtual void EditDocument() => Console.WriteLine("Document has been edited in a trial varsion");
        public virtual void SaveDocument() => Console.WriteLine("Document has saved in a trial version");
    }
}
