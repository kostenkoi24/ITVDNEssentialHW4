using System;

namespace Homework4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();

            player.Play();

            IPlayable playable = (IPlayable)player;
            playable.Play();
            playable.Pause();
            playable.Stop();


            
            IRecodable recodable = (IRecodable)player;
            recodable.Record();
            recodable.Pause();
            recodable.Stop();


            Console.ReadKey();
        }
    }

    class Player : IPlayable, IRecodable
    {
        public void Play() //var1
        {
            Console.WriteLine("Player Play in class Play");
        }

        void IPlayable.Play() //var2
        {
            Console.WriteLine("Player Play by Interface IPlayable");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Player Pause");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Player Stop");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Record Play");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Record Pause");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record Stop");
        }




    }
}
