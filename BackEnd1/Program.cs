using BackEnd1;

Veicolo veicolo1 = new Veicolo()
{
    Modello = "Mito",
    Marca = "AlfaRomeo",
    Anno = "2018",
};
Console.WriteLine(" Modello:" + veicolo1.Modello + " Marca:" + veicolo1.Marca + " Anno:" + veicolo1.Anno);


Animale animale1 = new Animale()
{
    Nome = "Attila",
    Razza = "Maremmano",
    Proprietario = "Ettore",
};
Console.WriteLine(" Nome:" + animale1.Nome + " Razza:" + animale1.Razza + " Proprietario:" + animale1.Proprietario);

Dipendente dipendente1 = new Dipendente()
{
    Nome = "Rachele",
    Cognome = "Barberis",
    Azienda = "Epicode",
};
Console.WriteLine(" Nome:" + dipendente1.Nome + " Cognome:" + dipendente1.Cognome + " Azienda:" + dipendente1.Azienda);

Atleta atleta1 = new Atleta()
{
    Nome = "Federica",
    Cognome = "Pellegrini",
    Sport = "Nuoto",
};
Console.WriteLine(" Nome:" + atleta1.Nome + " Cognome:" + atleta1.Cognome + " Sport:" + atleta1.Sport);
