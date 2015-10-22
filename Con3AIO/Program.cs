using System;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;

namespace Con3AIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Espera até que o jogo seja carregado
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            //Verifica qual campeão o jogador está usando
            switch(Player.Instance.ChampionName)
            {
                case "Alistar":     //TODO
                case "Amumu":       //TODO
                case "Annie":       //TODO
                case "Ashe":        //TODO
                case "Dr. Mundo":   //TODO
                case "Garen":       //TODO
                case "Jax":         //TODO
                case "Kayle":       //TODO
                case "Master Yi":   //TODO
                case "Miss Fortune"://TODO
                case "Nunu":        //TODO
                case "Ryze":        //TODO
                case "Sivir":       //TODO
                case "Tristana":    //TODO
                case "Volibear":    //TODO
                case "Warwick":     //TODO
                default:
                    return;
            }
        }

        private static void Game_OnGameLoad(EventArgs args)
        {

        }
    }
}
