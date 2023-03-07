using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bau_36365
{
    internal class Bau
    {
        #region Criação das Propriedades

        private bool _estadoBau;
        public bool EstadoBau
        {
            get
            {
                return _estadoBau;
            }
            set
            {
                if(BauTrancado == true)
                {
                    _estadoBau = false;
                }
                else
                {
                    _estadoBau = value;
                }
                    
                
            }
        }
        

        private bool _bautrancado;

        public bool BauTrancado
        {
            get
            {
                return _bautrancado;
            }
            set
            {
                    
                    _bautrancado = value;
                
            }
        }

        private int _qtdMoedas;
        public int QtdMoedas
        {
            get
            {
                return _qtdMoedas;
            }
            set
            {
                if (value >= 0 || value <= 200)
                {
                    _qtdMoedas = value;
                }
               else
                {
                    throw new Exception("O baú suporta até apenas 200 moedas");
                }
            }

        }

        #endregion

        #region Criação dos Métodos
        public string Abrir()
        {
           
                EstadoBau = true;
                return "O Baú foi aberto, aperte ENTER para coletar as moedas";
           
        }

        public string TrancadoOuDestrancado()
        {
            if(BauTrancado == true)
            {
                
                return "O Baú está Trancado, aperte ENTER para destranca-lo";
            }
            else
            {
                

                return BauAbertoOuFechado();
            }
        }
        public string BauAbertoOuFechado()
        {
            if(BauTrancado == false)

            { 
                if (EstadoBau == true)
                {
    

                   if(QtdMoedas == 0)
                    {
                        return "O Baú está aberto mas está vazio";
                    }
                   else
                    {
                        return "O Baú está aberto, para coletar as moedas aperte ENTER";
                    }
                    

                }
                else
                {

                    return "O Baú está fechado, aperte ENTER para abri-lo";
                    

                }
           
            }
            else
            {
                return Destrancar();
            }
        }

        public string Destrancar()
        {
            if(BauTrancado == true)
            {
                
                return "O Baú foi destrancado, aperte ENTER para abri-lo";
            }
            else
            {
               
                return "O Baú está destrancado";
            }
        }


        public string ColetarMoedas()
        {
           if(QtdMoedas == 0)
            {
                return "O Baú está vazio";
            }
           else
            {
                return "As moedas foram coletadas, você coletou " + QtdMoedas + " moedas";
            }
           
        }
        #endregion

    }
}
