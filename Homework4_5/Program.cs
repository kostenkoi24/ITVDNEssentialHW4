using System;

namespace Homework4_5
{
    class Program
    {
        enum docType
        {
            XML = 1,
            TXT,
            DOC
        };


        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            
            Console.WriteLine($"1 - {docType.XML}; \n2 - {docType.TXT}; \n3 - {docType.DOC} \nВведіть номер ключа або натисніть Enter: ");

            int.TryParse(Console.ReadLine(), out int key);

            Document document = new Document();


            switch (key)
            {
                case 1:
                    XMLHandler xMLHandler = new XMLHandler();
                    document.ShowMethods(xMLHandler);
                    
                    break;
                case 2:
                    TXTHandler tXTHandler = new TXTHandler();
                    document.ShowMethods(tXTHandler);
                    break;
                case 3:
                    DOCHandler dOCHandler = new DOCHandler();
                    document.ShowMethods(dOCHandler);
                    break;
                default:
                    Console.WriteLine("Тип документу обрано не вірно");
                    return;
            }

        }
    }


    class Document
    {
        public void ShowMethods(AbstractHandler handler)
        {
            handler.Change();
            handler.Create();
            handler.Open();
            handler.Save();
        }
    }




    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine($"{GetType().Name} Change");
        }

        public override void Create()
        {
            Console.WriteLine($"{GetType().Name} Create");
        }

        public override void Open()
        {
            Console.WriteLine($"{GetType().Name} Open");
        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} Save");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine($"{GetType().Name} Change");
        }

        public override void Create()
        {
            Console.WriteLine($"{GetType().Name} Create");
        }

        public override void Open()
        {
            Console.WriteLine($"{GetType().Name} Open");
        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} Save");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine($"{GetType().Name} Change");
        }

        public override void Create()
        {
            Console.WriteLine($"{GetType().Name} Create");
        }

        public override void Open()
        {
            Console.WriteLine($"{GetType().Name} Open");
        }

        public override void Save()
        {
            Console.WriteLine($"{GetType().Name} Save");
        }
    }



}
