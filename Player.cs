using System;

namespace Polimorfismo
{
    public abstract class Player
    {
        public virtual void Correr(){
            Console.WriteLine("Correndo em velocidade 10");
        }
    }
}