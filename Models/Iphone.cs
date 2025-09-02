using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace trilha_net_poo_desafio.Models
{
  public class Iphone : Smartphone
  {
    public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
      int tamanhoApp = 10;
      if (memoriaUsada + tamanhoApp > Memoria)
      {
        Console.WriteLine($"Memória insuficiente para instalar {nomeApp} no {Modelo}");
      }
      else
      {
        memoriaUsada += tamanhoApp;
        Console.WriteLine($"Instalando {nomeApp} no {Modelo} (Usado: {memoriaUsada}/{Memoria} MB)");
      }
    }

    public override void DesinstalarAplicativo(string nomeApp)
    {
      int tamanhoApp = 10;
      if (memoriaUsada >= tamanhoApp)
      {
        memoriaUsada -= tamanhoApp;
        Console.WriteLine($"Desinstalando {nomeApp} do {Modelo} (Usado: {memoriaUsada}/{Memoria} MB)");
      }
      else
      {
        Console.WriteLine($"Nenhum app para desinstalar em {Modelo}");
      }
    }
  }
}