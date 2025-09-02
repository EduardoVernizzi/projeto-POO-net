using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace trilha_net_poo_desafio.Models
{
  public abstract class Smartphone
  {
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    private string IMEI { get; set; }
    protected int Memoria { get; set; }
    protected int memoriaUsada = 0;

    public Smartphone(string numero, string modelo, string imei, int memoria)
    {
      Numero = numero;
      Modelo = modelo;
      IMEI = imei;
      Memoria = memoria;
    }

    public void Ligar()
    {
      Console.WriteLine("Ligando...");
    }

    public void ReceberLigacao()
    {
      Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);

    public virtual void DesinstalarAplicativo(string nomeApp)
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

    public virtual void MostrarInfo()
    {
      Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {IMEI}, " +
                        $"Memória: {Memoria} MB, Usada: {memoriaUsada} MB, Livre: {Memoria - memoriaUsada} MB");
    }
  }
}
