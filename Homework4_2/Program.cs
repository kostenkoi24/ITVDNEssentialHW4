using System;

namespace Homework4_2
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
            

            switch (key)
            {
                case 1:
                    XMLHandler xMLHandler = new XMLHandler();
                    xMLHandler.Show(docType.XML.ToString());
                    break;
                case 2:
                    TXTHandler tXTHandler = new TXTHandler();
                    tXTHandler.Show(docType.TXT.ToString());
                    break;
                case 3:
                    DOCHandler dOCHandler = new DOCHandler();
                    dOCHandler.Show(docType.DOC.ToString());
                    break;
                default:
                    Console.WriteLine("Тип документу обрано не вірно");
                    return;
            }



            

        }
    }


    class XMLHandler : AbstractHandler
    {
        public void Show(string doc)
        {
            Open("Open "+doc);
            Create("Create " + doc);
            Change("Change " + doc);
            Save("Save " + doc);
        }
    }

    class TXTHandler : AbstractHandler
    {
        public void Show(string doc)
        {
            Open("Open " + doc);
            Create("Create " + doc);
            Change("Change " + doc);
            Save("Save " + doc);
        }
    }

    class DOCHandler : AbstractHandler
    {
        public void Show(string doc)
        {
            Open("Open " + doc);
            Create("Create " + doc);
            Change("Change " + doc);
            Save("Save " + doc);
        }
    }



}
