namespace Essensial.Task_3._4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument() => Console.WriteLine("Document has been edited in a Pro version");
        public override void SaveDocument() => Console.WriteLine("Document has saved in a Pro version");
    }
}
