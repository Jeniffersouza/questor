using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public  class Lacos
    {
        public void MeuLacos()
        {
            #region for
            for (int ano = 2022; ano > 2018; ano--)
            {
                Console.WriteLine(ano);
            }
            #endregion

            #region anoWhile
            int anoWhile = 2022;
            while (anoWhile > 2018)
            {
                Console.WriteLine(anoWhile);
                anoWhile--;
            }
            #endregion

            #region DoWhile
            int anoDo = 2022;
            do
            {
                Console.WriteLine(anoDo);
                anoDo--;
            } while (anoDo > 2018);
            #endregion

            #region foreach
            string[] anosForeach = { "2022", "2021", "2020", "2019", "2018" };
            foreach (string anoForeach in anosForeach)
            {
                Console.WriteLine(anoForeach);
            }
            #endregion

        }
    }   

}
