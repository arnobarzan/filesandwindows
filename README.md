# C# Opening extra Windows and parsing of data

We maken een applicatie om de komende verkiezingen wat voor te bereiden. In de app kan de user per partij bijhouden welke mensen hij onlangs op televisie/socials heeft gezien in een lijstje per partij. (*nvdr: er werden willekeurig enkele partijen gekozen ter demo*).

## Opdracht 1: 

Zorg dat de `partyListBox` opgevuld wordt met politieke partijen. Je vindt de partijen in de folder 'partijen' in deze git-repo. Gebruik een `FolderBrowserDialog`, die je toont als een dialoog (`ShowDialog()`), om een map te kiezen. Haal vervolgens de namen van de aanwezige bestanden op via `Directory.GetFiles()`.  

Zorg ervoor dat je enkel de partijnaam toont (dus geen .txt), hier mag je kiezen hoe je dit doet. (*tip: gebruik eventueel een handige functie uit `Path`*).

## Opdracht 2:

Als de gebruiker dubbelklikt op een partijnaam opent er een nieuw venster (je mag kiezen hoe dit heet, bv: `DetailWindow`). Ook dit nieuwe venster open je als een dialog. Plaats in het nieuwe venster de partijnaam in een `Label`. Je moet hiervoor de partijnaam op een of andere manier doorgeven aan het nieuwe venster.

## Opdracht 3: 

In het nieuwe venster gebeurt bij het openen iets extra: de namenlijst van de partij in kwestie wordt ingelezen uit het bestand. Je hebt hiervoor de partijnaam en het pad naar het bestand nodig. Toon in eerste instantie de namen onder elkaar in een `TextBox` (zie voorbeeld *FileInput* uit de boekcode).

## Opdracht 4: 

In plaats van de namen gewoon te tonen in een `TextBox`, doe je het volgende: 
* Maak een klasse `Person` aan, deze klasse heeft twee properties: `FirstName` en `LastName`. Zorg er via de **getter** van LastName voor dat deze telkens in uppercase wordt teruggegeven. 
* Maak in de `Person` klasse ook een `ToString()` die de achternaam en voornaam toont als: `ACHTERNAAM -> Voornaam`. 
* Bij het uitlezen van de personen op een partijlijst: parse de persoon en vorm deze om naar een object van de klasse Person. 
* Voeg de string representatie van de personen toe aan de `TextBox`.

## Opdracht 5: 

Zorg er via twee simpele `TextBox`s voor dat je een voornaam en een naam kan ingeven en met behulp van een knop **een nieuwe persoon toevoegt in het tekstbestand (*append*)**. De personen staan in het tekstbestand als `Achternaam,Voornaam`.

## Opdracht 6 (EXTRA): 

Zorg voor eenvoudige validatie op de nieuwe personen: zorg dat de voornaam en naam niet leeg zijn (voeg de persoon **niet** toe in dit geval). Werp een exception op indien dit wel het geval is. In de UI toon je een MessageBox zodat de gebruiker weet dat het niet gelukt is.


