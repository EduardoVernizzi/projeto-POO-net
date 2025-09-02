# Simulação de Smartphones em C#

Este projeto simula o comportamento de **smartphones** usando **Programação Orientada a Objetos (POO) em C#**.  
Ele implementa **classes abstratas, herança e sobrescrita de métodos**, permitindo instalar e desinstalar aplicativos, controlar memória e exibir informações dos aparelhos.

---

## Funcionalidades

- Criação de diferentes modelos de smartphones (Nokia e iPhone).  
- Instalação e desinstalação de aplicativos com controle de memória.  
- Exibição das informações do smartphone, incluindo memória total, usada e livre.  
- Métodos de interação básica: `Ligar` e `ReceberLigacao`

## Classes

### Smartphone (abstract)

- **Propriedades:** `Numero`, `Modelo`, `IMEI`, `Memoria`, `memoriaUsada`.  
- **Métodos:**
  - `Ligar()`  
  - `ReceberLigacao()`  
  - `InstalarAplicativo(string nomeApp)` → abstrato, sobrescrito nas classes filhas.  
  - `DesinstalarAplicativo(string nomeApp)` → virtual, permite sobrescrita.  
  - `MostrarInfo()` → virtual, mostra todas as informações do smartphone.  

### Iphone e Nokia

- Herdam de `Smartphone`.  
- Sobrescrevem `InstalarAplicativo()` para simular instalação de apps com limite de memória.  
- Sobrescrevem `DesinstalarAplicativo()` para atualizar memória ao remover apps.

---
