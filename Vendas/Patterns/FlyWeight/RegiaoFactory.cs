using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Models;
using Vendas.Patterns.FlyWeight.Regioes;

namespace Vendas.Patterns.FlyWeight
{
    //FlyweightFactory

    public class RegiaoFactory

    {

        //flyweights

        Dictionary<int, Regiao> _regioes = new Dictionary<int, Regiao>();

        public Regiao GetRegiao(int key)
        {
            Regiao regiao = null;

            //If we've already created one of the 
            //requested type of slider, just use that.
            if (_regioes.ContainsKey(key))
            {
                regiao = _regioes[key];
            }
            else //Otherwise, create a brand new instance of the slider.
            {
                switch (key)
                {
                    case 1: regiao = new Sul(); break;
                    case 2: regiao = new Oeste(); break;
                    case 3: regiao = new Norte(); break;
                    case 4: regiao = new Central(); break;
                }
                _regioes.Add(key, regiao);
            }
            return regiao;
        }



    }
}
