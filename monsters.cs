using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;
using ClassesGame;
using System.Linq;

namespace monsters
{
    //ENUMERADORES E ESTRUTURAS
    enum functionofmonster{space,reality,time,life,energy }
    public enum ElementalPowers {space,control,limbo,caos,harmony}
    public class MonsterOfCreation : GameObject
    {
        //VARIAVEIS E VETORES
        private functionofmonster monstertype;
        ElementalPowers[] Myelements = new ElementalPowers[5];
        List<ElementalPowers[]> powers = new List<ElementalPowers[]>();
        public int Life;
        //CONSTRUTOR
        public MonsterOfCreation(int Life,int[] Myelements,int monstertype,Texture2D texture, Rectangle area, Color color)
            : base(texture, area, color)
        {
            this.Life = Life;
            for(int i = 0;i<5;i++)
            {
                this.Myelements[i] = (ElementalPowers)Myelements[i];
            }
            var allPowers = Enum.GetValues(typeof(ElementalPowers)).Cast<ElementalPowers>().ToArray();

            // Gerar todas as combinações únicas de três elementos
            for (int i = 0; i < allPowers.Length; i++)
            {
                for (int j = i + 1; j < allPowers.Length; j++)
                {
                    for (int k = j + 1; k < allPowers.Length; k++)
                    {
                        ElementalPowers[] combination = { allPowers[i], allPowers[j], allPowers[k] };
                        powers.Add(combination);
                    }
                }
            }
        }
        //UPDATE
        public override void Update(KeyboardState currentKeyboardState)
        {
            base.Update(currentKeyboardState);
            if(currentKeyboardState.IsKeyDown(Keys.A))
            {
                monster_attack();
            }
        }
        //SELECIONAR HABILIDADE
        public void select_power(ElementalPowers[] elementos)
        {
            if (!elementos.Except(powers[0]).Any() && !powers[0].Except(elementos).Any()) teste1();
            else
                if (!elementos.Except(powers[1]).Any() && !powers[1].Except(elementos).Any()) teste2();
            else
                if (!elementos.Except(powers[2]).Any() && !powers[2].Except(elementos).Any()) teste3();
            else
                if (!elementos.Except(powers[3]).Any() && !powers[3].Except(elementos).Any()) teste4();
            else
                if (!elementos.Except(powers[4]).Any() && !powers[4].Except(elementos).Any()) teste5();
            else
                if (!elementos.Except(powers[5]).Any() && !powers[5].Except(elementos).Any()) teste6();
            else
                if (!elementos.Except(powers[6]).Any() && !powers[6].Except(elementos).Any()) teste7();
            else
                if (!elementos.Except(powers[7]).Any() && !powers[7].Except(elementos).Any()) teste8();
            else
                if (!elementos.Except(powers[8]).Any() && !powers[8].Except(elementos).Any()) teste9();
            else
                if (!elementos.Except(powers[9]).Any() && !powers[9].Except(elementos).Any()) teste10();
            else Console.WriteLine("error");
        }
        //ATAQUE A SER EXECUTADO
        public void monster_attack()
        {
            List<ElementalPowers> copy = new List<ElementalPowers>(Myelements);
            ElementalPowers[] habilidade = new ElementalPowers[3];
            for (int i = 0; i < 3; i++)
            {
                Random random = new Random();
                int indice = random.Next(copy.Count);
                habilidade[i] = copy[indice];
                copy.RemoveAt(indice);
            }
            select_power(habilidade);
        }
        //ATAQUES COM BASE NOS 3 ELEMENTOS
        public void teste1()
        {
            Console.WriteLine("teste1");
        }
        public void teste2()
        {
            Console.WriteLine("teste2");
        }
        public void teste3()
        {
            Console.WriteLine("teste3");
        }
        public void teste4()
        {
            Console.WriteLine("teste4");
        }
        public void teste5()
        {
            Console.WriteLine("teste5");
        }
        public void teste6()
        {
            Console.WriteLine("teste6");
        }
        public void teste7()
        {
            Console.WriteLine("teste7");
        }
        public void teste8()
        {
            Console.WriteLine("teste8");
        }
        public void teste9()
        {
            Console.WriteLine("teste9");
        }
        public void teste10()
        {
            Console.WriteLine("teste10");
        }
    }
}
